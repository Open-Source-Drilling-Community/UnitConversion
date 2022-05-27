using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.DrillingUnitConversion.ModelClientShared
{
    public partial class QuantityUnitConversion
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public QuantityUnitConversion() : base()
        {

        }

        /// <summary>
        /// main constructor (the exact copy of the original from namespace OSDC.UnitConversion.DrillingUnitConversion.Model
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

    }
}
