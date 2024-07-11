using System;
using System.Collections.Generic;
using System.Text.Json;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Logging;
using OSDC.UnitConversion.Conversion.DrillingEngineering;

namespace OSDC.UnitConversion.Service
{
    /// <summary>
    /// A manager for UnitSystem. The manager implements the singleton pattern as defined by 
    /// Gamma, Erich, et al. "Design patterns: Abstraction and reuse of object-oriented design." 
    /// European Conference on Object-Oriented Programming. Springer, Berlin, Heidelberg, 1993.
    /// </summary>
    public class UnitSystemManager
    {
        private static UnitSystemManager instance_ = null;
        private readonly ILogger logger_;
        private readonly object lock_ = new();
        private readonly SqliteConnection connection_;

        private UnitSystemManager(ILogger logger)
        {
            logger_ = logger;
            connection_ = SqlConnectionManager.GetInstance(logger_).Connection;

            // make sure database contains default UnitSystems
            if (GetAllUnitSystemId().Count < 4)
            {
                FillDefault();
            }
        }

        public static UnitSystemManager GetInstance(ILogger logger)
        {
            instance_ ??= new UnitSystemManager(logger);
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
                    command.CommandText = "SELECT COUNT(*) FROM UnitSystemTable";
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
                        logger_.LogError(ex, "Impossible to count records in the UnitSystemTable");
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
                        //empty UnitSystemTable
                        var command = connection_.CreateCommand();
                        command.CommandText = "DELETE FROM UnitSystemTable";
                        command.ExecuteNonQuery();

                        transaction.Commit();
                        success = true;
                    }
                    catch (SqliteException ex)
                    {
                        transaction.Rollback();
                        logger_.LogError(ex, "Impossible to clear the UnitSystemTable");
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
                command.CommandText = $"SELECT COUNT(*) FROM UnitSystemTable WHERE ID = ' {guid}'";
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
                    logger_.LogError(ex, "Impossible to count rows from UnitSystemTable");
                }
            }
            else
            {
                logger_.LogWarning("Impossible to access the SQLite database");
            }
            return count >= 1;
        }

        /// <summary>
        /// Returns the list of Guid of all UnitSystem present in the microservice database 
        /// </summary>
        /// <returns>the list of Guid of all UnitSystem present in the microservice database</returns>
        public List<Guid> GetAllUnitSystemId()
        {
            List<Guid> ids = new();
            if (connection_ != null)
            {
                var command = connection_.CreateCommand();
                command.CommandText = "SELECT ID FROM UnitSystemTable";
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
                    logger_.LogError(ex, "Impossible to get IDs from UnitSystemTable");
                }
            }
            else
            {
                logger_.LogWarning("Impossible to access the SQLite database");
            }
            return ids;
        }

        /// <summary>
        /// Returns a UnitSystem identified by its Guid from the microservice database 
        /// </summary>
        /// <param name="guid"></param>
        /// <returns>the UnitSystem retrieved from the database</returns>
        public UnitSystem GetUnitSystemById(Guid guid)
        {
            if (!guid.Equals(Guid.Empty))
            {
                if (connection_ != null)
                {
                    UnitSystem unitSystem;
                    var command = connection_.CreateCommand();
                    command.CommandText = $"SELECT UnitSystem FROM UnitSystemTable WHERE ID = '{guid}'";
                    try
                    {
                        using var reader = command.ExecuteReader();
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            string data = reader.GetString(0);
                            unitSystem = JsonSerializer.Deserialize<UnitSystem>(data);
                            if (!unitSystem.ID.Equals(guid))
                                throw (new SqliteException("SQLite database corrupted: retrieved UnitSystem is null or has been jsonified with the wrong ID.", 1));
                        }
                        else
                        {
                            logger_.LogInformation("No UnitSystem of given ID in the database");
                            return null;
                        }
                    }
                    catch (SqliteException ex)
                    {
                        logger_.LogError(ex, "Impossible to get the UnitSystem with the given ID from UnitSystemTable");
                        return null;
                    }

                    // Finalizing
                    logger_.LogInformation("Returning the UnitSystem of given ID from UnitSystemTable");
                    return unitSystem;
                }
                else
                {
                    logger_.LogWarning("Impossible to access the SQLite database");
                }
            }
            else
            {
                logger_.LogWarning("The given UnitSystem ID is null or empty");
            }
            return null;
        }

        /// <summary>
        /// Returns the list of all UnitSystem present in the microservice database 
        /// </summary>
        /// <returns>the list of all UnitSystem present in the microservice database</returns>
        public List<UnitSystem> GetAllUnitSystem()
        {
            List<UnitSystem> vals = new();
            if (connection_ != null)
            {
                var command = connection_.CreateCommand();
                command.CommandText = "SELECT UnitSystem FROM UnitSystemTable";
                try
                {
                    using var reader = command.ExecuteReader();
                    while (reader.Read() && !reader.IsDBNull(0))
                    {
                        string data = reader.GetString(0);
                        UnitSystem unitSystem = JsonSerializer.Deserialize<UnitSystem>(data);
                        vals.Add(unitSystem);
                    }
                }
                catch (SqliteException ex)
                {
                    logger_.LogError(ex, "Impossible to get UnitSystem from UnitSystemTable");
                }
            }
            else
            {
                logger_.LogWarning("Impossible to access the SQLite database");
            }
            return vals;
        }

        /// <summary>
        /// Adds the given UnitSystem to the microservice database
        /// </summary>
        /// <param name="unitSystem"></param>
        /// <returns>true if the given UnitSystem has been added successfully</returns>
        public bool AddUnitSystem(UnitSystem unitSystem)
        {
            if (unitSystem != null && !unitSystem.ID.Equals(Guid.Empty))
            {
                //update UnitSystemTable
                if (connection_ != null)
                {
                    lock (lock_)
                    {
                        using SqliteTransaction transaction = connection_.BeginTransaction();
                        bool success = true;
                        try
                        {
                            //add the UnitSystem to the UnitSystemTable
                            string data = JsonSerializer.Serialize(unitSystem);
                            var command = connection_.CreateCommand();
                            command.CommandText = "INSERT INTO UnitSystemTable " +
                                "(ID, UnitSystem) VALUES (" +
                                $"'{unitSystem.ID}', " +
                                $"'{data}'" +
                                ")";
                            int count = command.ExecuteNonQuery();
                            if (count != 1)
                            {
                                logger_.LogWarning("Impossible to insert the given UnitSystem into the UnitSystemTable");
                                success = false;
                            }
                        }
                        catch (SqliteException ex)
                        {
                            logger_.LogError(ex, "Impossible to add the given UnitSystem into UnitSystemTable");
                            success = false;
                        }
                        // Finalizing
                        if (success)
                        {
                            transaction.Commit();
                            logger_.LogInformation("Added the given UnitSystem of given ID into the UnitSystemTable successfully");
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
                logger_.LogWarning("The UnitSystem ID or the ID of its input are null or empty");
            }
            return false;
        }

        /// <summary>
        /// Performs calculation on the given UnitSystem and updates it in the microservice database
        /// </summary>
        /// <param name="unitSystem"></param>
        /// <returns>true if the given UnitSystem has been updated successfully</returns>
        public bool UpdateUnitSystemById(Guid guid, UnitSystem unitSystem)
        {
            bool success = true;
            if (!guid.Equals(Guid.Empty) && unitSystem != null && unitSystem.ID.Equals(guid))
            {
                //update UnitSystemTable
                if (connection_ != null)
                {
                    lock (lock_)
                    {
                        using SqliteTransaction transaction = connection_.BeginTransaction();
                        //update fields in UnitSystemTable
                        try
                        {
                            string data = JsonSerializer.Serialize(unitSystem);
                            var command = connection_.CreateCommand();
                            command.CommandText = $"UPDATE UnitSystemTable SET " +
                                $"UnitSystem = '{data}' " +
                                $"WHERE ID = '{guid}'";
                            int count = command.ExecuteNonQuery();
                            if (count != 1)
                            {
                                logger_.LogWarning("Impossible to update the UnitSystem");
                                success = false;
                            }
                        }
                        catch (SqliteException ex)
                        {
                            logger_.LogError(ex, "Impossible to update the UnitSystem");
                            success = false;
                        }

                        // Finalizing
                        if (success)
                        {
                            transaction.Commit();
                            logger_.LogInformation("Updated the given UnitSystem successfully");
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
                logger_.LogWarning("The UnitSystem ID or the ID of some of its attributes are null or empty");
            }
            return false;
        }

        /// <summary>
        /// Deletes the UnitSystem of given ID from the microservice database
        /// </summary>
        /// <param name="guid"></param>
        /// <returns>true if the UnitSystem was deleted from the microservice database</returns>
        public bool DeleteUnitSystemById(Guid guid)
        {
            if (!guid.Equals(Guid.Empty))
            {
                if (connection_ != null)
                {
                    lock (lock_)
                    {
                        using var transaction = connection_.BeginTransaction();
                        bool success = true;
                        //delete UnitSystem from UnitSystemTable
                        try
                        {
                            var command = connection_.CreateCommand();
                            command.CommandText = $"DELETE FROM UnitSystemTable WHERE ID = '{guid}'";
                            int count = command.ExecuteNonQuery();
                            if (count < 0)
                            {
                                logger_.LogWarning("Impossible to delete the UnitSystem of given ID from the UnitSystemTable");
                                success = false;
                            }
                        }
                        catch (SqliteException ex)
                        {
                            logger_.LogError(ex, "Impossible to delete the UnitSystem of given ID from UnitSystemTable");
                            success = false;
                        }
                        if (success)
                        {
                            transaction.Commit();
                            logger_.LogInformation("Removed the UnitSystem of given ID from the UnitSystemTable successfully");
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
                logger_.LogWarning("The UnitSystem ID is null or empty");
            }
            return false;
        }

        /// <summary>
        /// populate database with default UnitSystems
        /// </summary>
        private void FillDefault()
        {
            List<UnitSystem> unitSystems =
            [
                UnitSystem.SIUnitSystem,
                UnitSystem.MetricUnitSystem,
                UnitSystem.USUnitSystem,
                UnitSystem.ImperialUnitSystem
            ];


            foreach (UnitSystem uSys in unitSystems)
            {
                if (GetUnitSystemById(uSys.ID) == null)
                {
                    AddUnitSystem(uSys);
                }
                else
                {
                    UpdateUnitSystemById(uSys.ID, uSys);
                }
            }
        }
    }
}