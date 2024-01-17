using Microsoft.Extensions.Logging;
using System.Text.Json;
using OSDC.UnitConversion.DrillingUnitConversion.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading;

namespace OSDC.UnitConversion.DrillingUnitConversion.Service
{
    public class DataUnitConversionSetManager
    {
        private readonly ILogger logger_;
        private readonly object lock_ = new();
        private readonly SQLiteConnection connection_;

        public DataUnitConversionSetManager(ILoggerFactory loggerFactory)
        {
            logger_ = loggerFactory.CreateLogger<DataUnitConversionSetManager>();
            connection_ = SQLConnectionManager.GetConnection(loggerFactory);
        }

        public int Count
        {
            get
            {
                int count = 0;
                if (connection_ != null)
                {
                    var command = connection_.CreateCommand();
                    command.CommandText = @"SELECT COUNT(*) FROM DataUnitConversionSetsTable";
                    try
                    {
                        using SQLiteDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            count = (int)reader.GetInt64(0);
                        }
                    }
                    catch (SQLiteException ex)
                    {
                        logger_.LogError(ex, "Impossible to count records in the DataUnitConversionSetsTable");
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
                        // then empty DataUnitConversionSetsTable
                        var command = connection_.CreateCommand();
                        command.CommandText = @"DELETE FROM DataUnitConversionSetsTable";
                        command.ExecuteNonQuery();

                        transaction.Commit();
                        success = true;
                    }
                    catch (SQLiteException ex)
                    {
                        transaction.Rollback();
                        logger_.LogError(ex, "Impossible to clear the DataUnitConversionSetsTable");
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
                command.CommandText = @"SELECT COUNT(*) FROM DataUnitConversionSetsTable WHERE ID = '" + guid + "'";
                try
                {
                    using SQLiteDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        count = (int)reader.GetInt64(0);
                    }
                }
                catch (SQLiteException ex)
                {
                    logger_.LogError(ex, "Impossible to count rows from DataUnitConversionSetsTable");
                }
            }
            else
            {
                logger_.LogWarning("Impossible to access the SQLite database");
            }
            return count >= 1;
        }

        public List<Guid> GetIDs()
        {
            List<Guid> ids = new();
            if (connection_ != null)
            {
                var command = connection_.CreateCommand();
                command.CommandText = @"SELECT ID FROM DataUnitConversionSetsTable";
                try
                {
                    using SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                            ids.Add(reader.GetGuid(0));
                    }
                }
                catch (SQLiteException ex)
                {
                    logger_.LogError(ex, "Impossible to get IDs from DataUnitConversionSetsTable");
                }
            }
            else
            {
                logger_.LogWarning("Impossible to access the SQLite database");
            }
            return ids;
        }

        public List<Tuple<Guid, string, string>> GetNames()
        {
            List<Tuple<Guid, string, string>> names = new();
            if (connection_ != null)
            {
                var command = connection_.CreateCommand();
                command.CommandText = @"SELECT ID, Name, Description FROM DataUnitConversionSetsTable";
                try
                {
                    using SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            names.Add(new Tuple<Guid, string, string>(reader.GetGuid(0), reader.GetString(1), reader.GetString(2)));
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    logger_.LogError(ex, "Impossible to get IDs from DataUnitConversionSetsTable");
                }
            }
            else
            {
                logger_.LogWarning("Impossible to access the SQLite database");
            }
            return names;
        }


        public DataUnitConversionSet Get(Guid guid)
        {
            DataUnitConversionSet result = null;
            if (!guid.Equals(Guid.Empty))
            {
                if (connection_ != null)
                {
                    string json;
                    // retrieve the DataUnitConversionSet itself
                    var command = connection_.CreateCommand();
                    command.CommandText = @"SELECT Data FROM DataUnitConversionSetsTable " +
                        "WHERE ID = '" + guid.ToString() + "'";
                    try
                    {
                        using SQLiteDataReader reader = command.ExecuteReader();
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            json = reader.GetString(0);
                            if (!string.IsNullOrEmpty(json))
                            {
                                result = JsonSerializer.Deserialize<DataUnitConversionSet>(json);
                            }
                        }
                        else
                        {
                            logger_.LogInformation("No DataUnitConversionSet in the database");
                            return null;
                        }
                    }
                    catch (SQLiteException ex)
                    {
                        logger_.LogError(ex, "Impossible to get the DataUnitConversionSet with the given ID from DataUnitConversionSetsTable");
                        return null;
                    }
                }
                else
                {
                    logger_.LogWarning("Impossible to access the SQLite database");
                }
            }
            else
            {
                logger_.LogWarning("The given DataUnitConversionSet ID is null or empty");
            }
            return result;
        }

        /// <summary>
        /// performs calculations on the given DataUnitConversionSet and adds it to the database
        /// </summary>
        public bool Add(DataUnitConversionSet dataUnitConversionSet)
        {
            if (dataUnitConversionSet != null)
            {
                // first apply calculations
                if (!dataUnitConversionSet.CalculateOutputUnitConversionSet())
                {
                    logger_.LogWarning("Impossible to calculate outputs for the given DataUnitConversionSet");
                    return false;
                }
                // then update to database
                if (connection_ != null)
                {
                    lock (lock_)
                    {
                        using SQLiteTransaction transaction = connection_.BeginTransaction();
                        bool success = true;
                        try
                        {
                            // first add the DataUnitConversionSet to the DataUnitConversionSetsTable
                            string json = JsonSerializer.Serialize(dataUnitConversionSet);
                            var command = connection_.CreateCommand();
                            command.CommandText = @"INSERT INTO DataUnitConversionSetsTable " +
                                "(ID, Name, Description, Data, TimeStamp) VALUES (" +
                                "'" + dataUnitConversionSet.ID.ToString() + "', " +
                                "'" + dataUnitConversionSet.Name + "', " +
                                "'" + dataUnitConversionSet.Description + "', " +
                                "'" + json + "', " +
                                "'" + (DateTime.UtcNow - DateTime.MinValue).TotalSeconds.ToString() + "'" +
                                ")";
                            int count = command.ExecuteNonQuery();
                            if (count != 1)
                            {
                                logger_.LogWarning("Impossible to insert the DataUnitConversionSet into the DataUnitConversionSetsTable");
                                success = false;
                            }
                        }
                        catch (SQLiteException ex)
                        {
                            logger_.LogError(ex, "Impossible to add the DataUnitConversionSet into DataUnitConversionSetsTable");
                            success = false;
                        }
                        // Finalizing
                        if (success)
                        {
                            transaction.Commit();
                            logger_.LogInformation("Added the DataUnitConversionSet of given ID into the DataUnitConversionSetsTable successfully");
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
                logger_.LogWarning("The DataUnitConversionSet ID or the ID of its input are null or empty");
            }
            return false;
        }

        /// <summary>
        /// removes the DataUnitConversionSet of given guid from the database
        /// </summary>
        public bool Remove(Guid guid)
        {
            if (!guid.Equals(Guid.Empty))
            {
                DataUnitConversionSet dataUnitConversionSet = Get(guid);

                if (dataUnitConversionSet != null)
                {
                    if (connection_ != null)
                    {
                        lock (lock_)
                        {
                            using var transaction = connection_.BeginTransaction();
                            bool success = true;
                            // first delete DataUnitConversionSet from DataUnitConversionSetsTable
                            try
                            {
                                var command = connection_.CreateCommand();
                                command.CommandText = @"DELETE FROM DataUnitConversionSetsTable WHERE ID = '" + guid.ToString() + "'";
                                int count = command.ExecuteNonQuery();
                                if (count < 0)
                                {
                                    logger_.LogWarning("Impossible to delete the DataUnitConversionSet of given ID from the DataUnitConversionSetsTable");
                                    success = false;
                                }
                            }
                            catch (SQLiteException ex)
                            {
                                logger_.LogError(ex, "Impossible to delete the DataUnitConversionSet of given ID from DataUnitConversionSetsTable");
                                success = false;
                            }
                            if (success)
                            {
                                transaction.Commit();
                                logger_.LogInformation("Removed the DataUnitConversionSet of given ID from the DataUnitConversionSetsTable successfully");
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
                    logger_.LogWarning("Impossible to remove the DataUnitConversionSet of given ID because it is null or one of its attributes is");
                }
            }
            else
            {
                logger_.LogWarning("The DataUnitConversionSet ID is null or empty");
            }
            return false;
        }

        /// <summary>
        /// removes all DataUnitConversionSets older than the given date
        /// </summary>
        public bool Remove(DateTime old)
        {
            if (connection_ != null)
            {
                var command = connection_.CreateCommand();
                command.CommandText = @"SELECT ID FROM DataUnitConversionSetsTable WHERE TimeStamp < '" + (old - DateTime.MinValue).TotalSeconds.ToString() + "'";
                try
                {
                    using SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Guid guid = reader.GetGuid(0);
                        if (Remove(guid))
                        {
                            logger_.LogInformation("An old DataUnitConversionSet has been cleaned from the DataUnitConversionSetsTable successfully");
                            return true;
                        }
                        else
                        {
                            logger_.LogWarning("Impossible to clean an old DataUnitConversionSet from the DataUnitConversionSetsTable");
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    logger_.LogError(ex, "Impossible to clean old DataUnitConversionSets from the DataUnitConversionSetsTable");
                }
            }
            else
            {
                logger_.LogWarning("Impossible to access the SQLite database");
            }
            return false;
        }

        /// <summary>
        /// performs calculations on the given DataUnitConversionSet and updates the DataUnitConversionSet of given ID in the database
        /// </summary>
        public bool Update(Guid guid, DataUnitConversionSet dataUnitConversionSet)
        {
            bool success = true;
            if (!guid.Equals(Guid.Empty) && dataUnitConversionSet != null && !dataUnitConversionSet.ID.Equals(Guid.Empty))
            {
                // first apply calculations
                if (!dataUnitConversionSet.CalculateOutputUnitConversionSet())
                {
                    logger_.LogWarning("Impossible to calculate the output of the given DataUnitConversionSet");
                    return false;
                }

                // then update to database
                if (connection_ != null)
                {
                    lock (lock_)
                    {
                        using SQLiteTransaction transaction = connection_.BeginTransaction();
                        // first update the relevant fields in DataUnitConversionSetsTable (other fields never change)
                        try
                        {
                            string json = JsonSerializer.Serialize(dataUnitConversionSet);
                            var command = connection_.CreateCommand();
                            command.CommandText = @"UPDATE DataUnitConversionSetsTable SET " +
                                "Name = '" + dataUnitConversionSet.Name + "', " +
                                "Description = '" + dataUnitConversionSet.Description + "', " +
                                "Data = '" + json + "', " +
                                "TimeStamp = '" + (DateTime.UtcNow - DateTime.MinValue).TotalSeconds.ToString() + "' " +
                                "WHERE ID = '" + guid.ToString() + "'";
                            int count = command.ExecuteNonQuery();
                            if (count != 1)
                            {
                                logger_.LogWarning("Impossible to update the DataUnitConversionSet");
                                success = false;
                            }
                        }
                        catch (SQLiteException ex)
                        {
                            logger_.LogError(ex, "Impossible to update the DataUnitConversionSet");
                            success = false;
                        }
                        // Finalizing
                        if (success)
                        {
                            transaction.Commit();
                            logger_.LogInformation("Updated the given DataUnitConversionSet successfully");
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
                logger_.LogWarning("The DataUnitConversionSet ID or the ID of some of its attributes are null or empty");
            }
            return false;
        }

     }
}