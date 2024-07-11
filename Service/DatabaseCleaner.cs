using Microsoft.Extensions.Logging;
using System;
using System.Threading;

namespace OSDC.UnitConversion.Service
{
    public sealed class DatabaseCleaner
    {
        private static readonly Lazy<DatabaseCleaner> lazy =
            new(() => new DatabaseCleaner());

        public static DatabaseCleaner Instance { get { return lazy.Value; } }

        private readonly ILogger logger_;
        private readonly UnitSystemConversionSetManager unitSystemConversionSetManager_;
        private readonly UnitConversionSetManager unitConversionSetManager_;
        private readonly int SleepTime = 10; // in seconds
        private readonly int UnitSystemConversionSetRetirementTime = 2500000; // 1 month in seconds
        private readonly int UnitConversionSetRetirementTime = 2500000; // 1 month in seconds

        /// <summary>
        /// thread-safe implementation of a unique singleton database cleaner acting on a set of managers (following https://csharpindepth.com/Articles/Singleton)
        /// </summary>
        private DatabaseCleaner()
        {
            logger_ = new LoggerFactory().CreateLogger("DatabaseCleaner");
            unitSystemConversionSetManager_ = UnitSystemConversionSetManager.GetInstance(logger_);
            unitConversionSetManager_ = UnitConversionSetManager.GetInstance(logger_);

            // execute database cleaning on a unique thread which automatically removes old calculations from the database
            Thread thread = new(new ThreadStart(Clean));
            thread.Start();
        }

        /// <summary>
        /// Removes from tables records that have not been modified since a defined retirement time (in seconds)
        /// </summary>
        private void Clean()
        {
            unitSystemConversionSetManager_.DeleteUnitSystemConversionSetByDateTime(TimeSpan.FromSeconds(UnitSystemConversionSetRetirementTime));
            Thread.Sleep(SleepTime * 1000);
            unitConversionSetManager_.DeleteUnitConversionSetByDateTime(TimeSpan.FromSeconds(UnitConversionSetRetirementTime));
            Thread.Sleep(SleepTime * 1000);
        }

        public void Activate()
        {
            //activation immediately follows the instantiation of this singleton pattern class
        }
    }
}
