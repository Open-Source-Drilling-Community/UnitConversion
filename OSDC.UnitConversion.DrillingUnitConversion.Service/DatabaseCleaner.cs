using Microsoft.Extensions.Logging;
using System;
using System.Threading;

namespace OSDC.UnitConversion.DrillingUnitConversion.Service
{
    public sealed class DatabaseCleaner
    {
        private static readonly Lazy<DatabaseCleaner> lazy =
            new Lazy<DatabaseCleaner>(() => new DatabaseCleaner());

        public static DatabaseCleaner Instance { get { return lazy.Value; } }

        private readonly DataUnitConversionSetManager dataUnitConversionSetManager_;
        private readonly QuantityDataConversionManager quantityDataConversionManager_;
        private readonly int SleepTime = 10; // in seconds
        private readonly int RetirementTime = 360000; // in seconds

        /// <summary>
        /// thread-safe implementation of a unique singleton database cleaner acting on all managers (following https://csharpindepth.com/Articles/Singleton)
        /// </summary>
        private DatabaseCleaner()
        {
            ILoggerFactory loggerFactory = new LoggerFactory(); // TODO: warning, this factory is not configured through dependency injection. Hence, no messages are sent through DataUnitConversionSetManager.Remove() method
            dataUnitConversionSetManager_ = new DataUnitConversionSetManager(loggerFactory, new DrillingUnitChoiceSetManager(loggerFactory));
            quantityDataConversionManager_ = new QuantityDataConversionManager(loggerFactory);

            // execute database cleaning on a unique thread which automatically removes old calculations from the database
            Thread thread = new Thread(new ThreadStart(Clean));
            thread.Start();
        }

        /// <summary>
        /// database garbage collector
        /// </summary>
        private void Clean()
        {
            while (true)
            {
                dataUnitConversionSetManager_.Remove(DateTime.UtcNow - TimeSpan.FromSeconds(RetirementTime));
                quantityDataConversionManager_.Remove(DateTime.UtcNow - TimeSpan.FromSeconds(RetirementTime));
                Thread.Sleep(SleepTime * 1000);
            }
        }

        public void Activate()
        {
        }
    }
}
