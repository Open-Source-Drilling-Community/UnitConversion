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
    /// A manager for UnitSystemConversionSet. The manager implements the singleton pattern as defined by 
    /// Gamma, Erich, et al. "Design patterns: Abstraction and reuse of object-oriented design." 
    /// European Conference on Object-Oriented Programming. Springer, Berlin, Heidelberg, 1993.
    /// </summary>
    public class UnitSystemConversionSetManager
    {
        private static UnitSystemConversionSetManager instance_ = null;
        private readonly ILogger logger_;
        private readonly object lock_ = new();
        private readonly SqliteConnection connection_;

        private UnitSystemConversionSetManager(ILogger logger)
        {
            logger_ = logger;
            connection_ = SqlConnectionManager.GetInstance(logger_).Connection;
        }

        public static UnitSystemConversionSetManager GetInstance(ILogger logger)
        {
            instance_ ??= new UnitSystemConversionSetManager(logger);
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
                    command.CommandText = "SELECT COUNT(*) FROM UnitSystemConversionSetTable";
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
                        logger_.LogError(ex, "Impossible to count records in the UnitSystemConversionSetTable");
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
                        //empty UnitSystemConversionSetTable
                        var command = connection_.CreateCommand();
                        command.CommandText = "DELETE FROM UnitSystemConversionSetTable";
                        command.ExecuteNonQuery();

                        transaction.Commit();
                        success = true;
                    }
                    catch (SqliteException ex)
                    {
                        transaction.Rollback();
                        logger_.LogError(ex, "Impossible to clear the UnitSystemConversionSetTable");
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
                command.CommandText = $"SELECT COUNT(*) FROM UnitSystemConversionSetTable WHERE ID = ' {guid}'";
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
                    logger_.LogError(ex, "Impossible to count rows from UnitSystemConversionSetTable");
                }
            }
            else
            {
                logger_.LogWarning("Impossible to access the SQLite database");
            }
            return count >= 1;
        }

        /// <summary>
        /// Returns the list of Guid of all UnitSystemConversionSet present in the microservice database 
        /// </summary>
        /// <returns>the list of Guid of all UnitSystemConversionSet present in the microservice database</returns>
        public List<Guid> GetAllUnitSystemConversionSetId()
        {
            List<Guid> ids = new();
            if (connection_ != null)
            {
                var command = connection_.CreateCommand();
                command.CommandText = "SELECT ID FROM UnitSystemConversionSetTable";
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
                    logger_.LogError(ex, "Impossible to get IDs from UnitSystemConversionSetTable");
                }
            }
            else
            {
                logger_.LogWarning("Impossible to access the SQLite database");
            }
            return ids;
        }

        /// <summary>
        /// Returns the list of MetaInfo of all UnitSystemConversionSet present in the microservice database 
        /// </summary>
        /// <returns>the list of MetaInfo of all UnitSystemConversionSet present in the microservice database</returns>
        public List<MetaInfo> GetAllUnitSystemConversionSetMetaInfo()
        {
            List<MetaInfo> metaInfos = new();
            if (connection_ != null)
            {
                var command = connection_.CreateCommand();
                command.CommandText = "SELECT MetaInfo FROM UnitSystemConversionSetTable";
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
                    logger_.LogError(ex, "Impossible to get IDs from UnitSystemConversionSetTable");
                }
            }
            else
            {
                logger_.LogWarning("Impossible to access the SQLite database");
            }
            return metaInfos;
        }

        /// <summary>
        /// Returns a UnitSystemConversionSet identified by its Guid from the microservice database 
        /// </summary>
        /// <param name="guid"></param>
        /// <returns>the UnitSystemConversionSet retrieved from the database</returns>
        public UnitSystemConversionSet GetUnitSystemConversionSetById(Guid guid)
        {
            if (!guid.Equals(Guid.Empty))
            {
                if (connection_ != null)
                {
                    UnitSystemConversionSet unitSystemConversionSet;
                    var command = connection_.CreateCommand();
                    command.CommandText = $"SELECT UnitSystemConversionSet FROM UnitSystemConversionSetTable WHERE ID = '{guid}'";
                    try
                    {
                        using var reader = command.ExecuteReader();
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            string data = reader.GetString(0);
                            unitSystemConversionSet = JsonSerializer.Deserialize<UnitSystemConversionSet>(data);
                            if (!unitSystemConversionSet.MetaInfo.ID.Equals(guid))
                                throw (new SqliteException("SQLite database corrupted: retrieved UnitSystemConversionSet is null or has been jsonified with the wrong ID.", 1));
                        }
                        else
                        {
                            logger_.LogInformation("No UnitSystemConversionSet of given ID in the database");
                            return null;
                        }
                    }
                    catch (SqliteException ex)
                    {
                        logger_.LogError(ex, "Impossible to get the UnitSystemConversionSet with the given ID from UnitSystemConversionSetTable");
                        return null;
                    }

                    // Finalizing
                    logger_.LogInformation("Returning the UnitSystemConversionSet of given ID from UnitSystemConversionSetTable");
                    return unitSystemConversionSet;
                }
                else
                {
                    logger_.LogWarning("Impossible to access the SQLite database");
                }
            }
            else
            {
                logger_.LogWarning("The given UnitSystemConversionSet ID is null or empty");
            }
            return null;
        }

        /// <summary>
        /// Returns the list of all UnitSystemConversionSet present in the microservice database 
        /// </summary>
        /// <returns>the list of all UnitSystemConversionSet present in the microservice database</returns>
        public List<UnitSystemConversionSet> GetAllUnitSystemConversionSet()
        {
            List<UnitSystemConversionSet> vals = new();
            if (connection_ != null)
            {
                var command = connection_.CreateCommand();
                command.CommandText = "SELECT UnitSystemConversionSet FROM UnitSystemConversionSetTable";
                try
                {
                    using var reader = command.ExecuteReader();
                    while (reader.Read() && !reader.IsDBNull(0))
                    {
                        string data = reader.GetString(0);
                        UnitSystemConversionSet unitSystemConversionSet = JsonSerializer.Deserialize<UnitSystemConversionSet>(data);
                        vals.Add(unitSystemConversionSet);
                    }
                }
                catch (SqliteException ex)
                {
                    logger_.LogError(ex, "Impossible to get UnitSystemConversionSet from UnitSystemConversionSetTable");
                }
            }
            else
            {
                logger_.LogWarning("Impossible to access the SQLite database");
            }
            return vals;
        }

        /// <summary>
        /// Adds the given UnitSystemConversionSet to the microservice database
        /// </summary>
        /// <param name="unitSystemConversionSet"></param>
        /// <returns>true if the given UnitSystemConversionSet has been added successfully</returns>
        public bool AddUnitSystemConversionSet(UnitSystemConversionSet unitSystemConversionSet)
        {
            if (unitSystemConversionSet != null && unitSystemConversionSet.MetaInfo != null && unitSystemConversionSet.MetaInfo.ID != Guid.Empty)
            {
                //calculate outputs
                if (!unitSystemConversionSet.Calculate())
                {
                    logger_.LogWarning("Impossible to calculate outputs for the given UnitSystemConversionSet");
                    return false;
                }
                //update UnitSystemConversionSetTable
                if (connection_ != null)
                {
                    lock (lock_)
                    {
                        using SqliteTransaction transaction = connection_.BeginTransaction();
                        bool success = true;
                        try
                        {
                            //add the UnitSystemConversionSet to the UnitSystemConversionSetTable
                            string metaInfo = JsonSerializer.Serialize(unitSystemConversionSet.MetaInfo);
                            string data = JsonSerializer.Serialize(unitSystemConversionSet);
                            var command = connection_.CreateCommand();
                            command.CommandText = "INSERT INTO UnitSystemConversionSetTable " +
                                "(ID, MetaInfo, CreationDate, LastModificationDate, UnitSystemConversionSet) VALUES (" +
                                $"'{unitSystemConversionSet.MetaInfo.ID}', " +
                                $"'{metaInfo}', " +
                                $"'{unitSystemConversionSet.CreationDate}', " +
                                $"'{unitSystemConversionSet.LastModificationDate}', " +
                                $"'{data}'" +
                                ")";
                            int count = command.ExecuteNonQuery();
                            if (count != 1)
                            {
                                logger_.LogWarning("Impossible to insert the given UnitSystemConversionSet into the UnitSystemConversionSetTable");
                                success = false;
                            }
                        }
                        catch (SqliteException ex)
                        {
                            logger_.LogError(ex, "Impossible to add the given UnitSystemConversionSet into UnitSystemConversionSetTable");
                            success = false;
                        }
                        // Finalizing
                        if (success)
                        {
                            transaction.Commit();
                            logger_.LogInformation("Added the given UnitSystemConversionSet of given ID into the UnitSystemConversionSetTable successfully");
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
                logger_.LogWarning("The UnitSystemConversionSet ID or the ID of its input are null or empty");
            }
            return false;
        }

        /// <summary>
        /// Performs calculation on the given UnitSystemConversionSet and updates it in the microservice database
        /// </summary>
        /// <param name="unitSystemConversionSet"></param>
        /// <returns>true if the given UnitSystemConversionSet has been updated successfully</returns>
        public bool UpdateUnitSystemConversionSetById(Guid guid, UnitSystemConversionSet unitSystemConversionSet)
        {
            bool success = true;
            if (guid != Guid.Empty && unitSystemConversionSet != null && unitSystemConversionSet.MetaInfo != null && unitSystemConversionSet.MetaInfo.ID == guid)
            {
                //calculate outputs
                if (!unitSystemConversionSet.Calculate())
                {
                    logger_.LogWarning("Impossible to calculate outputs for the given UnitSystemConversionSet");
                    return false;
                }
                //update UnitSystemConversionSetTable
                if (connection_ != null)
                {
                    lock (lock_)
                    {
                        using SqliteTransaction transaction = connection_.BeginTransaction();
                        //update fields in UnitSystemConversionSetTable
                        try
                        {
                            string metaInfo = JsonSerializer.Serialize(unitSystemConversionSet.MetaInfo);
                            string data = JsonSerializer.Serialize(unitSystemConversionSet);
                            var command = connection_.CreateCommand();
                            command.CommandText = $"UPDATE UnitSystemConversionSetTable SET " +
                                $"MetaInfo = '{metaInfo}', " +
                                $"CreationDate = '{unitSystemConversionSet.CreationDate}', " +
                                $"LastModificationDate = '{unitSystemConversionSet.LastModificationDate}', " +
                                $"UnitSystemConversionSet = '{data}' " +
                                $"WHERE ID = '{guid}'";
                            int count = command.ExecuteNonQuery();
                            if (count != 1)
                            {
                                logger_.LogWarning("Impossible to update the UnitSystemConversionSet");
                                success = false;
                            }
                        }
                        catch (SqliteException ex)
                        {
                            logger_.LogError(ex, "Impossible to update the UnitSystemConversionSet");
                            success = false;
                        }

                        // Finalizing
                        if (success)
                        {
                            transaction.Commit();
                            logger_.LogInformation("Updated the given UnitSystemConversionSet successfully");
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
                logger_.LogWarning("The UnitSystemConversionSet ID or the ID of some of its attributes are null or empty");
            }
            return false;
        }

        /// <summary>
        /// Deletes the UnitSystemConversionSet of given ID from the microservice database
        /// </summary>
        /// <param name="guid"></param>
        /// <returns>true if the UnitSystemConversionSet was deleted from the microservice database</returns>
        public bool DeleteUnitSystemConversionSetById(Guid guid)
        {
            if (!guid.Equals(Guid.Empty))
            {
                if (connection_ != null)
                {
                    lock (lock_)
                    {
                        using var transaction = connection_.BeginTransaction();
                        bool success = true;
                        //delete UnitSystemConversionSet from UnitSystemConversionSetTable
                        try
                        {
                            var command = connection_.CreateCommand();
                            command.CommandText = $"DELETE FROM UnitSystemConversionSetTable WHERE ID = '{guid}'";
                            int count = command.ExecuteNonQuery();
                            if (count < 0)
                            {
                                logger_.LogWarning("Impossible to delete the UnitSystemConversionSet of given ID from the UnitSystemConversionSetTable");
                                success = false;
                            }
                        }
                        catch (SqliteException ex)
                        {
                            logger_.LogError(ex, "Impossible to delete the UnitSystemConversionSet of given ID from UnitSystemConversionSetTable");
                            success = false;
                        }
                        if (success)
                        {
                            transaction.Commit();
                            logger_.LogInformation("Removed the UnitSystemConversionSet of given ID from the UnitSystemConversionSetTable successfully");
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
                logger_.LogWarning("The UnitSystemConversionSet ID is null or empty");
            }
            return false;
        }

        /// <summary>
        /// Deletes UnitSystemConversionSet that have not been modified since the given retirement time span (in seconds)
        /// </summary>
        /// <param name="retirementTime">the retirement time span above which records needs to be deleted</param>
        /// <returns>true if older UnitSystemConversionSet were successfully deleted</returns>
        public bool DeleteUnitSystemConversionSetByDateTime(TimeSpan retirementTime)
        {
            if (connection_ != null)
            {
                var command = connection_.CreateCommand();
                DateTimeOffset retirementDate = DateTimeOffset.UtcNow - retirementTime;
                command.CommandText = $"SELECT ID FROM UnitSystemConversionSetTable WHERE " +
                    $"(LastModificationDate < '{retirementDate}') OR " +
                    $"(LastModificationDate IS NULL AND CreationDate < '{retirementDate}')";
                try
                {
                    using SqliteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Guid guid = reader.GetGuid(0);
                        if (DeleteUnitSystemConversionSetById(guid))
                        {
                            logger_.LogInformation("An old UnitSystemConversionSet has been deleted from UnitSystemConversionSetTable successfully");
                            return true;
                        }
                        else
                        {
                            logger_.LogWarning("Impossible to delete old UnitSystemConversionSet from UnitSystemConversionSetTable");
                        }
                    }
                }
                catch (SqliteException ex)
                {
                    logger_.LogError(ex, "Impossible to clean old UnitSystemConversionSet from UnitSystemConversionSetTable");
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