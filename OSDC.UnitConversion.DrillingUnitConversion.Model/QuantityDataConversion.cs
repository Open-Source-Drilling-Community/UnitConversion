using System;
using System.Collections.Generic;
using System.Text;
using OSDC.UnitConversion.Conversion;
using OSDC.UnitConversion.Conversion.DrillingEngineering;

namespace OSDC.UnitConversion.DrillingUnitConversion.Model
{
    public class QuantityDataConversion : DataConversion
    {

        public Guid ID { get; set; }
        public Guid QuantityID { get; set; }
        public Guid UnitChoiceID { get; set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public QuantityDataConversion(): base()
        {

        }
        /// <summary>
        /// copy constructor
        /// </summary>
        /// <param name="src"></param>
        public QuantityDataConversion(QuantityDataConversion src): base(src)
        {
            if (src != null)
            {
                ID = src.ID;
                QuantityID = src.QuantityID;
            }
        }
        public bool Calculate()
        {
            bool success = false;
            PhysicalQuantity quantity = DrillingPhysicalQuantity.GetQuantity(QuantityID);
            if (quantity != null)
            {
                UnitChoice unitChoice = quantity.GetUnitChoice(UnitChoiceID);
                if (unitChoice != null)
                {
                    switch (Conversion)
                    {
                        case ConversionType.FromSI:
                            DataOut = unitChoice.FromSI(DataIn);
                            DataOutString = unitChoice.FromSI(DataIn, quantity.MeaningfulPrecisionInSI);
                            break;
                        default:
                            DataOut = unitChoice.ToSI(DataIn);
                            DataOutString = unitChoice.ToSI(DataIn, quantity.MeaningfulPrecisionInSI);
                            break;
                    }
                    success = true;
                }
            }
            return success;
        }
    }
}
