using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OSDC.UnitConversion.Model
{
    public struct CountPerDay
    {
        public DateTime Date { get; set; }
        public ulong Count { get; set; }
        /// <summary>
        /// default constructor
        /// </summary>
        public CountPerDay() { }
        /// <summary>
        /// initialization constructor
        /// </summary>
        /// <param name="date"></param>
        /// <param name="count"></param>
        public CountPerDay(DateTime date, ulong count)
        {
            Date = date;
            Count = count;
        }
    }

    public class History 
    {
        public List<CountPerDay> Data { get; set; } = new List<CountPerDay>();
        /// <summary>
        /// default constructor
        /// </summary>
        public History() 
        {
            if (Data == null)
            {
                Data = new List<CountPerDay>();
            }
        }

        public void Increment()
        {
            if (Data.Count == 0)
            {
                Data.Add(new CountPerDay(DateTime.UtcNow.Date, 1));
            }
            else
            {
                if (Data[Data.Count - 1].Date < DateTime.UtcNow.Date)
                {
                    Data.Add(new CountPerDay(DateTime.UtcNow.Date, 1));
                }
                else
                {
                    Data[Data.Count - 1] = new CountPerDay(Data[Data.Count - 1].Date, Data[Data.Count - 1].Count + 1);
                }
            }
        }
    }
    public class UsageStatistics
    {
        public static readonly string HOME_DIRECTORY = ".." + Path.DirectorySeparatorChar + "home" + Path.DirectorySeparatorChar;

        public DateTime LastSaved { get; set; } = DateTime.MinValue;
        public TimeSpan BackInterval { get; set; } = TimeSpan.FromMinutes(15);

        public History PhysicalQuantityControllerGetAllIDPerDay { get; set; } = new History();
        public History PhysicalQuantityControllerGetAllPerDay { get; set; } = new History();
        public History PhysicalQuantityControllerGetByIDPerDay { get; set; } = new History();

        public History UnitConversionSetControllerGetAllIDPerDay { get; set; } = new History();
        public History UnitConversionSetControllerGetAllMetaInfoPerDay { get; set; } = new History();
        public History UnitConversionSetControllerGetAllPerDay { get; set; } = new History();
        public History UnitConversionSetControllerGetByIDPerDay { get; set; } = new History();
        public History UnitConversionSetControllerPostPerDay { get; set; } = new History();
        public History UnitConversionSetControllerPutPerDay { get; set; } = new History();
        public History UnitConversionSetControllerDeletePerDay { get; set; } = new History();

        public History UnitSystemControllerGetAllIDPerDay { get; set; } = new History();
        public History UnitSystemControllerGetAllLightPerDay { get; set; } = new History();
        public History UnitSystemControllerGetAllPerDay { get; set; } = new History();
        public History UnitSystemControllerGetByIDPerDay { get; set; } = new History();
        public History UnitSystemControllerPostPerDay { get; set; } = new History();
        public History UnitSystemControllerPutPerDay { get; set; } = new History();
        public History UnitSystemControllerDeletePerDay { get; set; } = new History();

        public History UnitSystemConversionSetControllerGetAllIDPerDay { get; set; } = new History();
        public History UnitSystemConversionSetControllerGetAllMetaInfoPerDay { get;  set; } = new History();
        public History UnitSystemConversionSetControllerGetAllPerDay { get; set; } = new History();
        public History UnitSystemConversionSetControllerGetByIDPerDay { get;  set; } = new History();
        public History UnitSystemConversionSetControllerPostPerDay { get;  set; } = new History();
        public History UnitSystemConversionSetControllerPutPerDay { get; set; } = new History();
        public History UnitSystemConversionSetControllerDeletePerDay { get; set; } = new History();

        private static UsageStatistics? instance_ = null;

        public static UsageStatistics Instance
        {
            get
            {
                if (instance_ == null)
                {
                    if (File.Exists(HOME_DIRECTORY + "history.json"))
                    {
                        try
                        {
                            string? jsonStr = null;
                            using (StreamReader reader = new StreamReader(HOME_DIRECTORY + "history.json"))
                            {
                                jsonStr = reader.ReadToEnd();
                            }
                            if (!string.IsNullOrEmpty(jsonStr))
                            {
                                instance_ = JsonSerializer.Deserialize<UsageStatistics>(jsonStr);
                            }
                            if (instance_ == null)
                            {
                                instance_ = new UsageStatistics();
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    instance_ = new UsageStatistics();
                }
                return instance_;
            }
        }

        public void IncrementPhysicalQuantityControllerGetAllIDPerDay()
        {
            if (PhysicalQuantityControllerGetAllIDPerDay == null)
            {
                PhysicalQuantityControllerGetAllIDPerDay = new History();
            }
            PhysicalQuantityControllerGetAllIDPerDay.Increment();
            ManageBackup();
        }

        public void IncrementPhysicalQuantityControllerGetAllPerDay()
        {
            if (PhysicalQuantityControllerGetAllPerDay == null)
            {
                PhysicalQuantityControllerGetAllPerDay = new History();
            }
            PhysicalQuantityControllerGetAllPerDay.Increment();
            ManageBackup();
        }
        public void IncrementPhysicalQuantityControllerGetByIDPerDay()
        {
            if (PhysicalQuantityControllerGetByIDPerDay == null)
            {
                PhysicalQuantityControllerGetByIDPerDay = new History();
            }
            PhysicalQuantityControllerGetByIDPerDay.Increment();
            ManageBackup();
        }

        public void IncrementUnitConversionSetControllerGetAllIDPerDay()
        {
            if (UnitConversionSetControllerGetAllIDPerDay == null)
            {
                UnitConversionSetControllerGetAllIDPerDay = new History();
            }
            UnitConversionSetControllerGetAllIDPerDay.Increment();
            ManageBackup();
        }
        public void IncrementUnitConversionSetControllerGetAllMetaInfoPerDay()
        {
            if (UnitConversionSetControllerGetAllMetaInfoPerDay == null)
            {
                UnitConversionSetControllerGetAllMetaInfoPerDay = new History();
            }
            UnitConversionSetControllerGetAllMetaInfoPerDay.Increment();
            ManageBackup();
        }
        public void IncrementUnitConversionSetControllerGetAllPerDay()
        {
            if (UnitConversionSetControllerGetAllPerDay == null)
            {
                UnitConversionSetControllerGetAllPerDay = new History();
            }
            UnitConversionSetControllerGetAllPerDay.Increment();
            ManageBackup();
        }
        public void IncrementUnitConversionSetControllerGetByIDPerDay()
        {
            if (UnitConversionSetControllerGetByIDPerDay == null)
            {
                UnitConversionSetControllerGetByIDPerDay = new History();
            }
            UnitConversionSetControllerGetByIDPerDay.Increment();
            ManageBackup();
        }
        public void IncrementUnitConversionSetControllerPostPerDay()
        {
            if (UnitConversionSetControllerPostPerDay == null)
            {
                UnitConversionSetControllerPostPerDay = new History();
            }
            UnitConversionSetControllerPostPerDay.Increment();
            ManageBackup();
        }
        public void IncrementUnitConversionSetControllerPutPerDay()
        {
            if (UnitConversionSetControllerPutPerDay == null)
            {
                UnitConversionSetControllerPutPerDay = new History();
            }
            UnitConversionSetControllerPutPerDay.Increment();
            ManageBackup();
        }
        public void IncrementUnitConversionSetControllerDeletePerDay()
        {
            if (UnitConversionSetControllerDeletePerDay == null)
            {
                UnitConversionSetControllerDeletePerDay = new History();
            }
            UnitConversionSetControllerDeletePerDay.Increment();
            ManageBackup();
        }
        public void IncrementUnitSystemControllerGetAllIDPerDay()
        {
            if (UnitSystemControllerGetAllIDPerDay == null)
            {
                UnitSystemControllerGetAllIDPerDay = new History();
            }
            UnitSystemControllerGetAllIDPerDay.Increment();
            ManageBackup();
        }

        public void IncrementUnitSystemControllerGetAllPerDay()
        {
            if (UnitSystemControllerGetAllPerDay == null)
            {
                UnitSystemControllerGetAllPerDay = new History();
            }
            UnitSystemControllerGetAllPerDay.Increment();
            ManageBackup();
        }
        public void IncrementUnitSystemControllerGetAllLightPerDay()
        {
            if (UnitSystemControllerGetAllLightPerDay == null)
            {
                UnitSystemControllerGetAllLightPerDay = new History();
            }
            UnitSystemControllerGetAllLightPerDay.Increment();
            ManageBackup();
        }
        public void IncrementUnitSystemControllerGetByIDPerDay()
        {
            if (UnitSystemControllerGetByIDPerDay == null)
            {
                UnitSystemControllerGetByIDPerDay = new History();
            }
            UnitSystemControllerGetByIDPerDay.Increment();
            ManageBackup();
        }
        public void IncrementUnitSystemControllerPostPerDay()
        {
            if (UnitSystemControllerPostPerDay == null)
            {
                UnitSystemControllerPostPerDay = new History();
            }
            UnitSystemControllerPostPerDay.Increment();
            ManageBackup();
        }
        public void IncrementUnitSystemControllerPutPerDay()
        {
            if (UnitSystemControllerPutPerDay == null)
            {
                UnitSystemControllerPutPerDay = new History();
            }
            UnitSystemControllerPutPerDay.Increment();
            ManageBackup();
        }
        public void IncrementUnitSystemControllerDeletePerDay()
        {
            if (UnitSystemControllerDeletePerDay == null)
            {
                UnitSystemControllerDeletePerDay = new History();
            }
            UnitSystemControllerDeletePerDay.Increment();
            ManageBackup();
        }

        public void IncrementUnitSystemConversionSetControllerGetAllIDPerDay()
        {
            if (UnitSystemConversionSetControllerGetAllIDPerDay == null)
            {
                UnitSystemConversionSetControllerGetAllIDPerDay = new History();
            }
            UnitSystemConversionSetControllerGetAllIDPerDay.Increment();
            ManageBackup();
        }
        public void IncrementUnitSystemConversionSetControllerGetAllMetaInfoPerDay()
        {
            if (UnitSystemConversionSetControllerGetAllMetaInfoPerDay == null)
            {
                UnitSystemConversionSetControllerGetAllMetaInfoPerDay = new History();
            }
            UnitSystemConversionSetControllerGetAllMetaInfoPerDay.Increment();
            ManageBackup();
        }
        public void IncrementUnitSystemConversionSetControllerGetAllPerDay()
        {
            if (UnitSystemConversionSetControllerGetAllPerDay == null)
            {
                UnitSystemConversionSetControllerGetAllPerDay = new History();
            }
            UnitSystemConversionSetControllerGetAllPerDay.Increment();
            ManageBackup();
        }
        public void IncrementUnitSystemConversionSetControllerGetByIDPerDay()
        {
            if (UnitSystemConversionSetControllerGetByIDPerDay == null)
            {
                UnitSystemConversionSetControllerGetByIDPerDay = new History();
            }
            UnitSystemConversionSetControllerGetByIDPerDay.Increment();
            ManageBackup();
        }
        public void IncrementUnitSystemConversionSetControllerPostPerDay()
        {
            if (UnitSystemConversionSetControllerPostPerDay == null)
            {
                UnitSystemConversionSetControllerPostPerDay = new History();
            }
            UnitSystemConversionSetControllerPostPerDay.Increment();
            ManageBackup();
        }
        public void IncrementUnitSystemConversionSetControllerPutPerDay()
        {
            if (UnitSystemConversionSetControllerPutPerDay == null)
            {
                UnitSystemConversionSetControllerPutPerDay = new History();
            }
            UnitSystemConversionSetControllerPutPerDay.Increment();
            ManageBackup();
        }
        public void IncrementUnitSystemConversionSetControllerDeletePerDay()
        {
            if (UnitSystemConversionSetControllerDeletePerDay == null)
            {
                UnitSystemConversionSetControllerDeletePerDay = new History();
            }
            UnitSystemConversionSetControllerDeletePerDay.Increment();
            ManageBackup();
        }

        private void ManageBackup()
        {
            if (DateTime.UtcNow > LastSaved + BackInterval)
            {
                LastSaved = DateTime.UtcNow;
                try
                {
                    string jsonStr = JsonSerializer.Serialize(this);
                    if (!string.IsNullOrEmpty(jsonStr) && Directory.Exists(HOME_DIRECTORY))
                    {
                        using (StreamWriter writer = new StreamWriter(HOME_DIRECTORY + "history.json"))
                        {
                            writer.Write(jsonStr);
                            writer.Flush();
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
