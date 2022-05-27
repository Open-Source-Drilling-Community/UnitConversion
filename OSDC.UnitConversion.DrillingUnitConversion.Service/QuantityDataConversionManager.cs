using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OSDC.UnitConversion.DrillingUnitConversion.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading;

namespace OSDC.UnitConversion.DrillingUnitConversion.Service
{
    public class QuantityDataConversionManager
    {
        private readonly ILogger logger_;
        private readonly object lock_ = new object();
        private readonly SQLiteConnection connection_;

        public QuantityDataConversionManager(ILoggerFactory loggerFactory)
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
                    command.CommandText = @"SELECT COUNT(*) FROM QuantityDataConversionsTable";
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
                        logger_.LogError(ex, "Impossible to count records in the QuantityDataConversionsTable");
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
                        command.CommandText = @"DELETE FROM QuantityDataConversionsTable";
                        command.ExecuteNonQuery();

                        transaction.Commit();
                        success = true;
                    }
                    catch (SQLiteException ex)
                    {
                        transaction.Rollback();
                        logger_.LogError(ex, "Impossible to clear the QuantityDataConversionsTable");
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
                command.CommandText = @"SELECT COUNT(*) FROM QuantityDataConversionsTable WHERE ID = '" + guid + "'";
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
                    logger_.LogError(ex, "Impossible to count rows from QuantityDataConversionsTable");
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
            List<Guid> ids = new List<Guid>();
            if (connection_ != null)
            {
                var command = connection_.CreateCommand();
                command.CommandText = @"SELECT ID FROM QuantityDataConversionsTable";
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
                    logger_.LogError(ex, "Impossible to get IDs from QuantityDataConversionsTable");
                }
            }
            else
            {
                logger_.LogWarning("Impossible to access the SQLite database");
            }
            return ids;
        }

        public QuantityDataConversion Get(Guid guid)
        {
            QuantityDataConversion result = null;
            if (guid != null && !guid.Equals(Guid.Empty))
            {
                if (connection_ != null)
                {
                    string json;
                    // retrieve the DataUnitConversionSet itself
                    var command = connection_.CreateCommand();
                    command.CommandText = @"SELECT Data FROM QuantityDataConversionsTable " +
                        "WHERE ID = '" + guid.ToString() + "'";
                    try
                    {
                        using SQLiteDataReader reader = command.ExecuteReader();
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            json = reader.GetString(0);
                            if (!string.IsNullOrEmpty(json))
                            {
                                result = JsonConvert.DeserializeObject<QuantityDataConversion>(json);
                            }
                        }
                        else
                        {
                            logger_.LogInformation("No QuantityDataConversion in the database");
                            return null;
                        }
                    }
                    catch (SQLiteException ex)
                    {
                        logger_.LogError(ex, "Impossible to get the QuantityDataConversion with the given ID from QuantityDataConversionsTable");
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
                logger_.LogWarning("The given QuantityDataConversion ID is null or empty");
            }
            return result;
        }

        /// <summary>
        /// performs calculations on the given DataUnitConversionSet and adds it to the database
        /// </summary>
        public bool Add(QuantityDataConversion quantityDataConversion)
        {
            if (quantityDataConversion != null)
            {
                // first apply calculations
                if (!quantityDataConversion.Calculate())
                {
                    logger_.LogWarning("Impossible to calculate outputs for the given QuantityDataConversion");
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
                            // first add the QuantityDataConversion to the QuantityDataConversionsTable
                            string json = JsonConvert.SerializeObject(quantityDataConversion);
                            var command = connection_.CreateCommand();
                            command.CommandText = @"INSERT INTO QuantityDataConversionsTable " +
                                "(ID, Data, TimeStamp) VALUES (" +
                                "'" + quantityDataConversion.ID.ToString() + "', " +
                                "'" + json + "', " +
                                "'" + (DateTime.UtcNow - DateTime.MinValue).TotalSeconds.ToString() + "'" +
                                ")";
                            int count = command.ExecuteNonQuery();
                            if (count != 1)
                            {
                                logger_.LogWarning("Impossible to insert the QuantityDataConversion into the QuantityDataConversionsTable");
                                success = false;
                            }
                        }
                        catch (SQLiteException ex)
                        {
                            logger_.LogError(ex, "Impossible to add the QuantityDataConversion into QuantityDataConversionsTable");
                            success = false;
                        }
                        // Finalizing
                        if (success)
                        {
                            transaction.Commit();
                            logger_.LogInformation("Added the QuantityDataConversion of given ID into the QuantityDataConversionsTable successfully");
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
                logger_.LogWarning("The QuantityDataConversion ID or the ID of its input are null or empty");
            }
            return false;
        }

        /// <summary>
        /// removes the QuantityDataConversion of given guid from the database
        /// </summary>
        public bool Remove(Guid guid)
        {
            if (!guid.Equals(Guid.Empty))
            {
                QuantityDataConversion quantityDataConversion = Get(guid);

                if (quantityDataConversion != null)
                {
                    if (connection_ != null)
                    {
                        lock (lock_)
                        {
                            using var transaction = connection_.BeginTransaction();
                            bool success = true;
                            // delete QuantityDataConversion from QuantityDataConversionsTable
                            try
                            {
                                var command = connection_.CreateCommand();
                                command.CommandText = @"DELETE FROM QuantityDataConversionsTable WHERE ID = '" + guid.ToString() + "'";
                                int count = command.ExecuteNonQuery();
                                if (count < 0)
                                {
                                    logger_.LogWarning("Impossible to delete the QuantityDataConversion of given ID from the QuantityDataConversionsTable");
                                    success = false;
                                }
                            }
                            catch (SQLiteException ex)
                            {
                                logger_.LogError(ex, "Impossible to delete the QuantityDataConversion of given ID from QuantityDataConversionsTable");
                                success = false;
                            }
                            if (success)
                            {
                                transaction.Commit();
                                logger_.LogInformation("Removed the QuantityDataConversion of given ID from the QuantityDataConversionsTable successfully");
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
                    logger_.LogWarning("Impossible to remove the QuantityDataConversion of given ID because it is null or one of its attributes is");
                }
            }
            else
            {
                logger_.LogWarning("The QuantityDataConversion ID is null or empty");
            }
            return false;
        }

        /// <summary>
        /// removes all QuantityDataConversion older than the given date
        /// </summary>
        public bool Remove(DateTime old)
        {
            if (connection_ != null)
            {
                var command = connection_.CreateCommand();
                command.CommandText = @"SELECT ID FROM QuantityDataConversionsTable WHERE TimeStamp < '" + (old - DateTime.MinValue).TotalSeconds.ToString() + "'";
                try
                {
                    using SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Guid guid = reader.GetGuid(0);
                        if (Remove(guid))
                        {
                            logger_.LogInformation("An old QuantityDataConversion has been cleaned from the QuantityDataConversionsTable successfully");
                            return true;
                        }
                        else
                        {
                            logger_.LogWarning("Impossible to clean an old QuantityDataConversion from the QuantityDataConversionsTable");
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    logger_.LogError(ex, "Impossible to clean old QuantityDataConversion from the QuantityDataConversionsTable");
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
        public bool Update(Guid guid, QuantityDataConversion quantityDataConversion)
        {
            bool success = true;
            if (guid != null && !guid.Equals(Guid.Empty) && quantityDataConversion != null && !quantityDataConversion.ID.Equals(Guid.Empty))
            {
                // first apply calculations
                if (!quantityDataConversion.Calculate())
                {
                    logger_.LogWarning("Impossible to calculate the output of the given QuantityDataConversion");
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
                            string json = JsonConvert.SerializeObject(quantityDataConversion);
                            var command = connection_.CreateCommand();
                            command.CommandText = @"UPDATE QuantityDataConversionsTable SET " +
                                "Data = '" + json + "', " +
                                "TimeStamp = '" + (DateTime.UtcNow - DateTime.MinValue).TotalSeconds.ToString() + "' " +
                                "WHERE ID = '" + guid.ToString() + "'";
                            int count = command.ExecuteNonQuery();
                            if (count != 1)
                            {
                                logger_.LogWarning("Impossible to update the QuantityDataConversion");
                                success = false;
                            }
                        }
                        catch (SQLiteException ex)
                        {
                            logger_.LogError(ex, "Impossible to update the QuantityDataConversion");
                            success = false;
                        }
                        // Finalizing
                        if (success)
                        {
                            transaction.Commit();
                            logger_.LogInformation("Updated the given QuantityDataConversion successfully");
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
                logger_.LogWarning("The QuantityDataConversion ID or the ID of some of its attributes are null or empty");
            }
            return false;
        }

     }
}