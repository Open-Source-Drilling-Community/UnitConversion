using System;
using System.Collections.Generic;
using System.Text.Json;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Logging;
using OSDC.DotnetLibraries.General.DataManagement;
using OSDC.UnitConversion.Model;

namespace OSDC.UnitConversion.Service
{
    /// <summary>
    /// A manager for UnitConversionSet. The manager implements the singleton pattern as defined by 
    /// Gamma, Erich, et al. "Design patterns: Abstraction and reuse of object-oriented design." 
    /// European Conference on Object-Oriented Programming. Springer, Berlin, Heidelberg, 1993.
    /// </summary>
    public class UnitConversionSetManager
    {
        private static UnitConversionSetManager instance_ = null;
        private readonly ILogger logger_;
        private readonly object lock_ = new();
        private readonly SqliteConnection connection_;

        private UnitConversionSetManager(ILogger logger)
        {
            logger_ = logger;
            connection_ = SqlConnectionManager.GetInstance(logger_).Connection;
        }

        public static UnitConversionSetManager GetInstance(ILogger logger)
        {
            instance_ ??= new UnitConversionSetManager(logger);
            return instance_;
        }

        public int Count
        {
            get
            {
                int count = 0;
                if (connection_ != null)
                {
                    var command = connection_.CreateCommand();
                    command.CommandText = "SELECT COUNT(*) FROM UnitConversionSetTable";
                    try
                    {
                        using SqliteDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            count = (int)reader.GetInt64(0);
                        }
                    }
                    catch (SqliteException ex)
                    {
                        logger_.LogError(ex, "Impossible to count records in the UnitConversionSetTable");
                    }
                }
                else
                {
                    logger_.LogWarning("Impossible to access the SQLite database");
                }
                return count;
            }
        }

        public bool Clear()
        {
            if (connection_ != null)
            {
                bool success = false;
                lock (lock_)
                {
                    using var transaction = connection_.BeginTransaction();
                    try
                    {
                        //empty UnitConversionSetTable
                        var command = connection_.CreateCommand();
                        command.CommandText = "DELETE FROM UnitConversionSetTable";
                        command.ExecuteNonQuery();

                        transaction.Commit();
                        success = true;
                    }
                    catch (SqliteException ex)
                    {
                        transaction.Rollback();
                        logger_.LogError(ex, "Impossible to clear the UnitConversionSetTable");
                    }
                }
                return success;
            }
            else
            {
                logger_.LogWarning("Impossible to access the SQLite database");
                return false;
            }
        }

        public bool Contains(Guid guid)
        {
            int count = 0;
            if (connection_ != null)
            {
                var command = connection_.CreateCommand();
                command.CommandText = $"SELECT COUNT(*) FROM UnitConversionSetTable WHERE ID = ' {guid}'";
                try
                {
                    using SqliteDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        count = (int)reader.GetInt64(0);
                    }
                }
                catch (SqliteException ex)
                {
                    logger_.LogError(ex, "Impossible to count rows from UnitConversionSetTable");
                }
            }
            else
            {
                logger_.LogWarning("Impossible to access the SQLite database");
            }
            return count >= 1;
        }

        /// <summary>
        /// Returns the list of Guid of all UnitConversionSet present in the microservice database 
        /// </summary>
        /// <returns>the list of Guid of all UnitConversionSet present in the microservice database</returns>
        public List<Guid> GetAllUnitConversionSetId()
        {
            List<Guid> ids = new();
            if (connection_ != null)
            {
                var command = connection_.CreateCommand();
                command.CommandText = "SELECT ID FROM UnitConversionSetTable";
                try
                {
                    using var reader = command.ExecuteReader();
                    while (reader.Read() && !reader.IsDBNull(0))
                    {
                        Guid id = reader.GetGuid(0);
                        ids.Add(id);
                    }
                }
                catch (SqliteException ex)
                {
                    logger_.LogError(ex, "Impossible to get IDs from UnitConversionSetTable");
                }
            }
            else
            {
                logger_.LogWarning("Impossible to access the SQLite database");
            }
            return ids;
        }

        /// <summary>
        /// Returns the list of MetaInfo of all UnitConversionSet present in the microservice database 
        /// </summary>
        /// <returns>the list of MetaInfo of all UnitConversionSet present in the microservice database</returns>
        public List<MetaInfo> GetAllUnitConversionSetMetaInfo()
        {
            List<MetaInfo> metaInfos = new();
            if (connection_ != null)
            {
                var command = connection_.CreateCommand();
                command.CommandText = "SELECT MetaInfo FROM UnitConversionSetTable";
                try
                {
                    using var reader = command.ExecuteReader();
                    while (reader.Read() && !reader.IsDBNull(0))
                    {
                        string mInfo = reader.GetString(0);
                        MetaInfo metaInfo = JsonSerializer.Deserialize<MetaInfo>(mInfo);
                        metaInfos.Add(metaInfo);
                    }
                }
                catch (SqliteException ex)
                {
                    logger_.LogError(ex, "Impossible to get IDs from UnitConversionSetTable");
                }
            }
            else
            {
                logger_.LogWarning("Impossible to access the SQLite database");
            }
            return metaInfos;
        }

        /// <summary>
        /// Returns a UnitConversionSet identified by its Guid from the microservice database 
        /// </summary>
        /// <param name="guid"></param>
        /// <returns>the UnitConversionSet retrieved from the database</returns>
        public UnitConversionSet GetUnitConversionSetById(Guid guid)
        {
            if (!guid.Equals(Guid.Empty))
            {
                if (connection_ != null)
                {
                    UnitConversionSet unitConversionSet;
                    var command = connection_.CreateCommand();
                    command.CommandText = $"SELECT UnitConversionSet FROM UnitConversionSetTable WHERE ID = '{guid}'";
                    try
                    {
                        using var reader = command.ExecuteReader();
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            string data = reader.GetString(0);
                            unitConversionSet = JsonSerializer.Deserialize<UnitConversionSet>(data);
                            if (!unitConversionSet.MetaInfo.ID.Equals(guid))
                                throw (new SqliteException("SQLite database corrupted: retrieved UnitConversionSet is null or has been jsonified with the wrong ID.", 1));
                        }
                        else
                        {
                            logger_.LogInformation("No UnitConversionSet of given ID in the database");
                            return null;
                        }
                    }
                    catch (SqliteException ex)
                    {
                        logger_.LogError(ex, "Impossible to get the UnitConversionSet with the given ID from UnitConversionSetTable");
                        return null;
                    }

                    // Finalizing
                    logger_.LogInformation("Returning the UnitConversionSet of given ID from UnitConversionSetTable");
                    return unitConversionSet;
                }
                else
                {
                    logger_.LogWarning("Impossible to access the SQLite database");
                }
            }
            else
            {
                logger_.LogWarning("The given UnitConversionSet ID is null or empty");
            }
            return null;
        }

        /// <summary>
        /// Returns the list of all UnitConversionSet present in the microservice database 
        /// </summary>
        /// <returns>the list of all UnitConversionSet present in the microservice database</returns>
        public List<UnitConversionSet> GetAllUnitConversionSet()
        {
            List<UnitConversionSet> vals = new();
            if (connection_ != null)
            {
                var command = connection_.CreateCommand();
                command.CommandText = "SELECT UnitConversionSet FROM UnitConversionSetTable";
                try
                {
                    using var reader = command.ExecuteReader();
                    while (reader.Read() && !reader.IsDBNull(0))
                    {
                        string data = reader.GetString(0);
                        UnitConversionSet unitConversionSet = JsonSerializer.Deserialize<UnitConversionSet>(data);
                        vals.Add(unitConversionSet);
                    }
                }
                catch (SqliteException ex)
                {
                    logger_.LogError(ex, "Impossible to get UnitConversionSet from UnitConversionSetTable");
                }
            }
            else
            {
                logger_.LogWarning("Impossible to access the SQLite database");
            }
            return vals;
        }

        /// <summary>
        /// Adds the given UnitConversionSet to the microservice database
        /// </summary>
        /// <param name="unitConversionSet"></param>
        /// <returns>true if the given UnitConversionSet has been added successfully</returns>
        public bool AddUnitConversionSet(UnitConversionSet unitConversionSet)
        {
            if (unitConversionSet != null && unitConversionSet.MetaInfo != null && unitConversionSet.MetaInfo.ID != Guid.Empty)
            {
                //calculate outputs
                if (!unitConversionSet.Calculate())
                {
                    logger_.LogWarning("Impossible to calculate outputs for the given UnitConversionSet");
                    return false;
                }
                //update UnitConversionSetTable
                if (connection_ != null)
                {
                    lock (lock_)
                    {
                        using SqliteTransaction transaction = connection_.BeginTransaction();
                        bool success = true;
                        try
                        {
                            //add the UnitConversionSet to the UnitConversionSetTable
                            string metaInfo = JsonSerializer.Serialize(unitConversionSet.MetaInfo);
                            string data = JsonSerializer.Serialize(unitConversionSet);
                            var command = connection_.CreateCommand();
                            command.CommandText = "INSERT INTO UnitConversionSetTable " +
                                "(ID, MetaInfo, CreationDate, LastModificationDate, UnitConversionSet) VALUES (" +
                                $"'{unitConversionSet.MetaInfo.ID}', " +
                                $"'{metaInfo}', " +
                                $"'{unitConversionSet.CreationDate}', " +
                                $"'{unitConversionSet.LastModificationDate}', " +
                                $"'{data}'" +
                                ")";
                            int count = command.ExecuteNonQuery();
                            if (count != 1)
                            {
                                logger_.LogWarning("Impossible to insert the given UnitConversionSet into the UnitConversionSetTable");
                                success = false;
                            }
                        }
                        catch (SqliteException ex)
                        {
                            logger_.LogError(ex, "Impossible to add the given UnitConversionSet into UnitConversionSetTable");
                            success = false;
                        }
                        // Finalizing
                        if (success)
                        {
                            transaction.Commit();
                            logger_.LogInformation("Added the given UnitConversionSet of given ID into the UnitConversionSetTable successfully");
                        }
                        else
                        {
                            transaction.Rollback();
                        }
                        return success;
                    }
                }
                else
                {
                    logger_.LogWarning("Impossible to access the SQLite database");
                }
            }
            else
            {
                logger_.LogWarning("The UnitConversionSet ID or the ID of its input are null or empty");
            }
            return false;
        }

        /// <summary>
        /// Performs calculation on the given UnitConversionSet and updates it in the microservice database
        /// </summary>
        /// <param name="unitConversionSet"></param>
        /// <returns>true if the given UnitConversionSet has been updated successfully</returns>
        public bool UpdateUnitConversionSetById(Guid guid, UnitConversionSet unitConversionSet)
        {
            bool success = true;
            if (guid != Guid.Empty && unitConversionSet != null && unitConversionSet.MetaInfo != null && unitConversionSet.MetaInfo.ID == guid)
            {
                //calculate outputs
                if (!unitConversionSet.Calculate())
                {
                    logger_.LogWarning("Impossible to calculate outputs for the given UnitConversionSet");
                    return false;
                }
                //update UnitConversionSetTable
                if (connection_ != null)
                {
                    lock (lock_)
                    {
                        using SqliteTransaction transaction = connection_.BeginTransaction();
                        //update fields in UnitConversionSetTable
                        try
                        {
                            string metaInfo = JsonSerializer.Serialize(unitConversionSet.MetaInfo);
                            string data = JsonSerializer.Serialize(unitConversionSet);
                            var command = connection_.CreateCommand();
                            command.CommandText = $"UPDATE UnitConversionSetTable SET " +
                                $"MetaInfo = '{metaInfo}', " +
                                $"CreationDate = '{unitConversionSet.CreationDate}', " +
                                $"LastModificationDate = '{unitConversionSet.LastModificationDate}', " +
                                $"UnitConversionSet = '{data}' " +
                                $"WHERE ID = '{guid}'";
                            int count = command.ExecuteNonQuery();
                            if (count != 1)
                            {
                                logger_.LogWarning("Impossible to update the UnitConversionSet");
                                success = false;
                            }
                        }
                        catch (SqliteException ex)
                        {
                            logger_.LogError(ex, "Impossible to update the UnitConversionSet");
                            success = false;
                        }

                        // Finalizing
                        if (success)
                        {
                            transaction.Commit();
                            logger_.LogInformation("Updated the given UnitConversionSet successfully");
                            return true;
                        }
                        else
                        {
                            transaction.Rollback();
                        }
                    }
                }
                else
                {
                    logger_.LogWarning("Impossible to access the SQLite database");
                }
            }
            else
            {
                logger_.LogWarning("The UnitConversionSet ID or the ID of some of its attributes are null or empty");
            }
            return false;
        }

        /// <summary>
        /// Deletes the UnitConversionSet of given ID from the microservice database
        /// </summary>
        /// <param name="guid"></param>
        /// <returns>true if the UnitConversionSet was deleted from the microservice database</returns>
        public bool DeleteUnitConversionSetById(Guid guid)
        {
            if (!guid.Equals(Guid.Empty))
            {
                if (connection_ != null)
                {
                    lock (lock_)
                    {
                        using var transaction = connection_.BeginTransaction();
                        bool success = true;
                        //delete UnitConversionSet from UnitConversionSetTable
                        try
                        {
                            var command = connection_.CreateCommand();
                            command.CommandText = $"DELETE FROM UnitConversionSetTable WHERE ID = '{guid}'";
                            int count = command.ExecuteNonQuery();
                            if (count < 0)
                            {
                                logger_.LogWarning("Impossible to delete the UnitConversionSet of given ID from the UnitConversionSetTable");
                                success = false;
                            }
                        }
                        catch (SqliteException ex)
                        {
                            logger_.LogError(ex, "Impossible to delete the UnitConversionSet of given ID from UnitConversionSetTable");
                            success = false;
                        }
                        if (success)
                        {
                            transaction.Commit();
                            logger_.LogInformation("Removed the UnitConversionSet of given ID from the UnitConversionSetTable successfully");
                        }
                        else
                        {
                            transaction.Rollback();
                        }
                        return success;
                    }
                }
                else
                {
                    logger_.LogWarning("Impossible to access the SQLite database");
                }
            }
            else
            {
                logger_.LogWarning("The UnitConversionSet ID is null or empty");
            }
            return false;
        }

        /// <summary>
        /// Deletes UnitConversionSet that have not been modified since the given retirement time span (in seconds)
        /// </summary>
        /// <param name="retirementTime">the retirement time span above which records needs to be deleted</param>
        /// <returns>true if older UnitConversionSet were successfully deleted</returns>
        public bool DeleteUnitConversionSetByDateTime(TimeSpan retirementTime)
        {
            if (connection_ != null)
            {
                var command = connection_.CreateCommand();
                DateTimeOffset retirementDate = DateTimeOffset.UtcNow - retirementTime;
                command.CommandText = $"SELECT ID FROM UnitConversionSetTable WHERE " +
                    $"(LastModificationDate < '{retirementDate}') OR " +
                    $"(LastModificationDate IS NULL AND CreationDate < '{retirementDate}')";
                try
                {
                    using SqliteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Guid guid = reader.GetGuid(0);
                        if (DeleteUnitConversionSetById(guid))
                        {
                            logger_.LogInformation("An old UnitConversionSet has been deleted from UnitConversionSetTable successfully");
                            return true;
                        }
                        else
                        {
                            logger_.LogWarning("Impossible to delete old UnitConversionSet from UnitConversionSetTable");
                        }
                    }
                }
                catch (SqliteException ex)
                {
                    logger_.LogError(ex, "Impossible to clean old UnitConversionSet from UnitConversionSetTable");
                }
            }
            else
            {
                logger_.LogWarning("Impossible to access the SQLite database");
            }
            return false;
        }
    }
}