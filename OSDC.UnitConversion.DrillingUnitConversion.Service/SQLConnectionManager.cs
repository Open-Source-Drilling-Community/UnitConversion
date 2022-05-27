using Microsoft.Extensions.Logging;
using System;
using System.Data.SQLite;
using System.IO;

namespace OSDC.UnitConversion.DrillingUnitConversion.Service
{
    public class SQLConnectionManager
    {
        private static ILogger logger_;
        private static SQLiteConnection connection_;

        public static SQLiteConnection GetConnection(ILoggerFactory loggerFactory)
        {
            if (logger_ == null)
            {
                logger_ = loggerFactory.CreateLogger<SQLConnectionManager>();
            }
            if (connection_ == null)
            {
                Initialize();
            }
            return connection_;
        }

        private static void ManageDrillingUnitConversionDatabases()
        {
            #region DataUnitConversionSetsTable
            var command = connection_.CreateCommand();
            command.CommandText = @"SELECT count(*) FROM DataUnitConversionSetsTable";
            long count = -1;
            try
            {
                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    count = reader.GetInt64(0);
                }
            }
            catch (SQLiteException ex)
            {
                logger_.LogWarning(ex, "DataUnitConversionSetsTable does not exist and will be created");
            }
            if (count < 0)
            {
                bool success = true;
                // table does no exist
                command.CommandText =
                    @"CREATE TABLE DataUnitConversionSetsTable (" +
                    "ID text primary key, " +
                    "Name text, " +
                    "Description text, " +
                    "Data text, " +
                    "TimeStamp" +
                   ")";
                try
                {
                    int res = command.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    logger_.LogError(ex, "Impossible to create DataUnitConversionSetsTable and will be dropped");
                    success = false;
                }
                if (success)
                {
                    Console.WriteLine("DataUnitConversionSetsTable has been successfully created and will be indexed.");
                    command.CommandText =
                        @"CREATE UNIQUE INDEX DataUnitConversionSetsIndex ON DataUnitConversionSetsTable (ID)";
                    try
                    {
                        int res = command.ExecuteNonQuery();
                        logger_.LogInformation("DataUnitConversionSetsTable has been successfully created");
                    }
                    catch (SQLiteException ex)
                    {
                        logger_.LogError(ex, "Impossible to index DataUnitConversionSetsTable which will be dropped");
                        success = false;
                    }
                }
                if (!success)
                {
                    command.CommandText =
                        @"DROP TABLE DataUnitConversionSetsTable";
                    try
                    {
                        int res = command.ExecuteNonQuery();
                        logger_.LogWarning("DataUnitConversionSetsTable has been successfully dropped");
                    }
                    catch (SQLiteException ex)
                    {
                        logger_.LogError(ex, "Impossible to drop DataUnitConversionSetsTable");
                    }
                }
            }
            #endregion
            #region QuantityDataConversionsTable
            command = connection_.CreateCommand();
            command.CommandText = @"SELECT count(*) FROM QuantityDataConversionsTable";
            count = -1;
            try
            {
                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    count = reader.GetInt64(0);
                }
            }
            catch (SQLiteException ex)
            {
                logger_.LogWarning(ex, "QuantityDataConversionsTable does not exist and will be created");
            }
            if (count < 0)
            {
                bool success = true;
                // table does no exist
                command.CommandText =
                    @"CREATE TABLE QuantityDataConversionsTable (" +
                    "ID text primary key, " +
                    "Data text, " +
                    "TimeStamp" +
                   ")";
                try
                {
                    int res = command.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    logger_.LogError(ex, "Impossible to create QuantityDataConversionsTable and will be dropped");
                    success = false;
                }
                if (success)
                {
                    Console.WriteLine("QuantityDataConversionsTable has been successfully created and will be indexed.");
                    command.CommandText =
                        @"CREATE UNIQUE INDEX QuantityDataConversionsIndex ON QuantityDataConversionsTable (ID)";
                    try
                    {
                        int res = command.ExecuteNonQuery();
                        logger_.LogInformation("QuantityDataConversionsTable has been successfully created");
                    }
                    catch (SQLiteException ex)
                    {
                        logger_.LogError(ex, "Impossible to index QuantityDataConversionsTable which will be dropped");
                        success = false;
                    }
                }
                if (!success)
                {
                    command.CommandText =
                        @"DROP TABLE QuantityDataConversionsTable";
                    try
                    {
                        int res = command.ExecuteNonQuery();
                        logger_.LogWarning("QuantityDataConversionsTable has been successfully dropped");
                    }
                    catch (SQLiteException ex)
                    {
                        logger_.LogError(ex, "Impossible to drop QuantityDataConversionsTable");
                    }
                }
            }
            #endregion

            #region DrillingUnitChoiceSetsTable
            command = connection_.CreateCommand();
            command.CommandText = @"SELECT count(*) FROM DrillingUnitChoiceSetsTable";
            count = -1;
            try
            {
                using SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    count = reader.GetInt64(0);
                }
            }
            catch (SQLiteException ex)
            {
                logger_.LogWarning(ex, "DrillingUnitChoiceSetsTable does not exist and will be created");
            }
            if (count < 0)
            {
                bool success = true;
                // table does no exist
                command.CommandText =
                    @"CREATE TABLE DrillingUnitChoiceSetsTable (" +
                    "ID text primary key, " +
                    "Name text, " +
                    "Description text, " +
                    "IsDefault integer, " +
                    "Data text " +
                   ")";
                try
                {
                    int res = command.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    logger_.LogError(ex, "Impossible to create DrillingUnitChoiceSetsTable and will be dropped");
                    success = false;
                }
                if (success)
                {
                    command.CommandText =
                        @"CREATE UNIQUE INDEX DrillingUnitChoiceSetsTableIndex ON DrillingUnitChoiceSetsTable (ID)";
                    try
                    {
                        int res = command.ExecuteNonQuery();
                        logger_.LogInformation("DrillingUnitChoiceSetsTable has been successfully created");
                    }
                    catch (SQLiteException ex)
                    {
                        logger_.LogError(ex, "Impossible to index DrillingUnitChoiceSetsTable and will be dropped");
                        success = false;
                    }
                }
                if (!success)
                {
                    command.CommandText =
                        @"DROP TABLE DrillingUnitChoiceSetsTable";
                    try
                    {
                        int res = command.ExecuteNonQuery();
                        logger_.LogWarning("DrillingUnitChoiceSetsTable has been successfully dropped");
                    }
                    catch (SQLiteException ex)
                    {
                        logger_.LogError(ex, "Impossible to drop DrillingUnitChoiceSetsTable");
                    }
                }
            }
            #endregion
        }

        private static void Initialize()
        {
            string homeDirectory = ".." + Path.DirectorySeparatorChar + "home";
            if (!Directory.Exists(homeDirectory))
            {
                try
                {
                    Directory.CreateDirectory(homeDirectory);
                }
                catch (Exception ex)
                {
                    logger_.LogError(ex, "Impossible to create home directory for local storage");
                }
            }
            if (Directory.Exists(homeDirectory))
            {
                string connectionString = @"URI=file:" + homeDirectory + Path.DirectorySeparatorChar + "DrillingUnitConversion.db";
                connection_ = new SQLiteConnection(connectionString);
                connection_.Open();
                ManageDrillingUnitConversionDatabases();
            }
        }

    }
}
