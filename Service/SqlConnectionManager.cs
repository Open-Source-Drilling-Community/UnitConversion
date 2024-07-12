using System;
using System.IO;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace OSDC.UnitConversion.Service
{
    /// <summary>
    /// A singleton manager for the sql database connection
    /// Prior to creating a database, existing database structure is checked for consistency with the structure defined in tableStructureDict_
    /// If inconsistent (table count, table names, fields count, fields names), a timestamped backup of the existing database is generated first
    /// </summary>
    public class SqlConnectionManager
    {
        private static SqlConnectionManager instance_ = null;
        private static SqliteConnection connection_ = null;
        private static ILogger logger_;
        private static string homeDirectory_ = ".." + Path.DirectorySeparatorChar + "home";
        private static string databaseFileName_ = "UnitConversion.db";

        // dictionary describing tables format
        private static Dictionary<string, string[]> tableStructureDict_ = new Dictionary<string, string[]>()
            {
                { "UnitSystemTable", new string[] {
                    "ID text primary key",
                    "Name text",
                    "Description text",
                    "IsDefault bool",
                    "IsSI bool",
                    "UnitSystem text" }
            },
                { "UnitSystemConversionSetTable", new string[] {
                    "ID text primary key",
                    "MetaInfo text",
                    "CreationDate text",
                    "LastModificationDate text",
                    "UnitSystemConversionSet text" }
            },
                { "UnitConversionSetTable", new string[] {
                    "ID text primary key",
                    "MetaInfo text",
                    "CreationDate text",
                    "LastModificationDate text",
                    "UnitConversionSet text" }
            }
            };


        /// <summary>
        /// default constructor is private when implementing a singleton pattern
        /// </summary>
        private SqlConnectionManager(ILogger logger)
        {
            logger_ = logger;
        }

        public static SqlConnectionManager GetInstance(ILogger logger)
        {
            if (instance_ == null)
            {
                instance_ = new SqlConnectionManager(logger);
            }
            return instance_;
        }

        public SqliteConnection Connection
        {
            get
            {
                if (connection_ == null)
                {
                    if (Initialize())
                        ManageDataBase();
                }
                return connection_;
            }
        }

        /// <summary>
        /// This function parses the existing database and check that its structure matches the expected one.
        /// If not, the existing database is backed-up and the actual database is recreated from scratch
        /// </summary>
        private static void ManageDataBase()
        {
            bool parseOk = true;
            bool createDb = false;

            List<string> tableNameList = new();
            string query = "SELECT name FROM sqlite_master WHERE type = 'table' AND name NOT LIKE 'sqlite_%';";

            using (var command = new SqliteCommand(query, connection_))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tableNameList.Add(reader.GetString(0));
                    }
                }
            }

            if (tableNameList.Count != tableStructureDict_.Count) // unexpected number of tables
            {
                parseOk = false;
            }
            else
            {
                foreach (var tableStruct in tableStructureDict_)
                {
                    bool tmpSuccess = false;
                    foreach (string name in tableNameList)
                    {
                        if (name == tableStruct.Key) // unexpected table names
                        {
                            tmpSuccess = true;
                            break;
                        }
                    }
                    if (!tmpSuccess ||
                        !CheckDatabaseStructure(tableStruct)) // badly formatted table
                    {
                        parseOk = false;
                        break;
                    }
                }
            }
            if (!parseOk)
            {
                createDb = true;
                if (tableNameList.Count > 0)
                {
                    logger_.LogWarning("Unexpected structure of the existing database. A timestamped backup copy will be generated");
                    // backup existing database
                    string backupFileName = homeDirectory_ + Path.DirectorySeparatorChar + databaseFileName_;
                    string timeStamp = DateTime.UtcNow.ToString("yyyy-MM-dd-HH-mm-ss") + "Z";
                    backupFileName = backupFileName.Insert(backupFileName.Length - 3, "-" + timeStamp);
                    try
                    {
                        File.Copy(homeDirectory_ + Path.DirectorySeparatorChar + databaseFileName_, backupFileName);
                    }
                    catch (Exception ex)
                    {
                        logger_.LogError(ex, "Problem while generating a timestamped backup copy of the existing database");
                    }
                    // drop existing tables
                    logger_.LogWarning("Dropping tables from existing database");
                    foreach (string name in tableNameList)
                    {
                        if (!DropTable(name))
                        {
                            createDb = false;
                            logger_.LogError($"Impossible to drop {name}. Database may be corrupted, consider deleting it");
                            break;
                        }
                    }
                }
                else
                {
                    logger_.LogError("Nothing done: existing database is not empty and corrupted, consider deleting it manually");
                }
            }
            if (createDb)
            {
                logger_.LogInformation("Creating database tables");
                bool success = true;
                foreach (var tableStruct in tableStructureDict_)
                {
                    if (CreateTable(tableStruct))
                    {
                        if (!IndexTable($"{tableStruct.Key}"))
                            success = false;
                    }
                    else
                    {
                        success = false;
                    }
                    if (!success)
                    {
                        if (!DropTable($"{tableStruct.Key}"))
                            logger_.LogError($"Impossible to drop {tableStruct.Key}. Database may be corrupted, consider deleting it");
                    }

                }
            }
        }

        private static bool Initialize()
        {
            if (!Directory.Exists(homeDirectory_))
            {
                logger_.LogInformation("Creating home directory");
                try
                {
                    Directory.CreateDirectory(homeDirectory_);
                }
                catch (Exception ex)
                {
                    logger_.LogError(ex, "Impossible to create home directory for local storage");
                    return false;
                }
            }
            if (Directory.Exists(homeDirectory_))
            {
                try
                {
                    string databaseFileName = homeDirectory_ + Path.DirectorySeparatorChar + databaseFileName_;
                    if (File.Exists(databaseFileName))
                    {
                        logger_.LogInformation($"Opening database {databaseFileName_}");
                    }
                    else
                    {
                        logger_.LogInformation($"Creating database {databaseFileName_}");
                    }
                    string connectionString = $"Data Source={databaseFileName}";
                    connection_ = new SqliteConnection(connectionString);
                    connection_.Open();
                }
                catch (Exception ex)
                {
                    logger_.LogError(ex, $"Impossible to create {databaseFileName_}");
                    return false;
                }
            }
            else
            {
                logger_.LogError("Home directory for local storage should have been created, check for access");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Check that expected fields (in tableStructure.Value) exactly match those of the stored database
        /// </summary>
        /// <param name="tableStructure"></param>
        /// <returns>true if the expected fields exactly match fields of the stored database</returns>
        private static bool CheckDatabaseStructure(KeyValuePair<string, string[]> tableStructure)
        {
            var command = connection_.CreateCommand();
            StringBuilder sb = new StringBuilder();
            sb.Append($"SELECT * FROM {tableStructure.Key}");
            command.CommandText = sb.ToString();
            try
            {
                using (var reader = command.ExecuteReader(CommandBehavior.SchemaOnly))
                {
                    var schema = reader.GetSchemaTable();
                    if (tableStructure.Value.Length != schema.Rows.Count)
                        return false; // unexpected number of fields in table
                    foreach (string field in tableStructure.Value)
                    {
                        bool tmpSuccess = false;
                        foreach (DataRow col in schema.Rows)
                        {
                            if (field.Split(" ").ElementAt(0) == col.Field<String>("ColumnName"))
                            {
                                tmpSuccess = true;
                                break;
                            }
                        }
                        if (!tmpSuccess)
                            return false; // at least one expected field is not found in stored database
                    }
                }
            }
            catch (SqliteException ex)
            {
                logger_.LogError(ex, $"Impossible to retrieve schema from table {tableStructure.Key}");
            }
            return true;
        }

        private static bool CreateTable(KeyValuePair<string, string[]> tabStruct)
        {
            var command = connection_.CreateCommand();
            StringBuilder sb = new StringBuilder();
            sb.Append($"CREATE TABLE {tabStruct.Key} ()");
            foreach (string col in tabStruct.Value)
            {
                sb.Insert(sb.Length - 1, col + ",");
            };
            sb.Remove(sb.Length - 2, 1);
            command.CommandText = sb.ToString();

            try
            {
                int res = command.ExecuteNonQuery();
                logger_.LogInformation($"{tabStruct.Key} has been successfully created");
            }
            catch (SqliteException ex)
            {
                logger_.LogError(ex, $"Impossible to create {tabStruct.Key} which will be dropped");
                return false;
            }
            return true;
        }

        private static bool IndexTable(string dbName)
        {
            var command = connection_.CreateCommand();
            command.CommandText = $"CREATE UNIQUE INDEX {dbName}Index ON {dbName} (ID)";
            try
            {
                int res = command.ExecuteNonQuery();
                logger_.LogInformation($"{dbName} has been successfully indexed");
            }
            catch (SqliteException ex)
            {
                logger_.LogError(ex, $"Impossible to index {dbName} which will be dropped");
                return false;
            }
            return true;
        }

        private static bool DropTable(string dbName)
        {
            var command = connection_.CreateCommand();
            command.CommandText =
                        $"DROP TABLE {dbName}";
            try
            {
                int res = command.ExecuteNonQuery();
                logger_.LogWarning($"{dbName} has been successfully dropped");
            }
            catch (SqliteException ex)
            {
                logger_.LogError(ex, $"Impossible to drop {dbName}");
                return false;
            }
            return true;
        }
    }
}
