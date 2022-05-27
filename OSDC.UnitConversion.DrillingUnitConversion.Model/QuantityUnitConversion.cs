using System;
using System.Collections.Generic;
using OSDC.UnitConversion.Conversion.DrillingEngineering;

namespace OSDC.UnitConversion.DrillingUnitConversion.Model
{
    /// <summary>
    /// a class to contain data conversions requests for a specific drilling physical quantity
    /// </summary>
    public class QuantityUnitConversion
    {
        /// <summary>
        /// the Drilling Physical Quantity used for the conversion
        /// </summary>
        public Guid PhysicalQuantityID { get; set; }
        /// <summary>
        /// a list of data to be converted.
        /// </summary>
        public List<DataConversion> DataConversions { get; set; }

        /// <summary>
        /// default constructor required for parsing the data model as a json file
        /// </summary>
        public QuantityUnitConversion() : base()
        {
        }
        /// <summary>
        /// copy constructor
        /// </summary>
        /// <param name="src"></param>
        public QuantityUnitConversion(QuantityUnitConversion src) : base()
        {
            if (src != null)
            {
                PhysicalQuantityID = src.PhysicalQuantityID;
                if (DataConversions == null)
                {
                    DataConversions = new List<DataConversion>();
                }
                DataConversions.Clear();
                if (src.DataConversions != null)
                {
                    foreach (DataConversion conversion in src.DataConversions)
                    {
                        DataConversions.Add(new DataConversion(conversion));
                    }
                }

            }
        }
        /// <summary>
        /// initialization constructor
        /// </summary>
        public QuantityUnitConversion(Guid physicalQuantityID, List<DataConversion> dataConversions)
        {
            PhysicalQuantityID = physicalQuantityID;
            if (DataConversions == null)
            {
                DataConversions = new List<DataConversion>();
            }
            DataConversions.Clear();
            if (dataConversions != null)
            {
                foreach (DataConversion conversion in dataConversions)
                {
                    DataConversions.Add(new DataConversion(conversion));
                }
            }
        }


    }
}
