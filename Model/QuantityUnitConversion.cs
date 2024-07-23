﻿using OSDC.UnitConversion.Conversion;
using OSDC.UnitConversion.Conversion.DrillingEngineering;
using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Model
{
    /// <summary>
    /// An intermediate class that contains a list of ValueConversion assigned to a given Quantity and a given UnitChoice
    /// </summary>
    public class QuantityUnitConversion
    {
        /// <summary>
        /// the ID of the physical quantity used for the conversion
        /// </summary>
        public Guid QuantityID { get; set; }
        /// <summary>
        /// the ID of the unit choice for the value to convert
        /// </summary>
        public Guid UnitChoiceIDIn { get; set; }
        /// <summary>
        /// the ID of the unit choice for the converted value
        /// </summary>
        public Guid UnitChoiceIDOut { get; set; }
        /// <summary>
        /// a list of numerical data to be converted.
        /// </summary>
        public List<ValueConversion>? ValueConversionList { get; set; }

        /// <summary>
        /// default constructor required for parsing the data model as a json file
        /// </summary>
        public QuantityUnitConversion()
        {
        }

        /// <summary>
        /// the main calculation method for QuantityUnitConversion
        /// </summary>
        /// <returns></returns>
        public bool Calculate()
        {
            bool success = false;
            BasePhysicalQuantity quantity = PhysicalQuantity.GetQuantity(QuantityID);
            if (quantity != null)
            {
                UnitChoice unitChoiceOut = quantity.GetUnitChoice(UnitChoiceIDOut);
                UnitChoice unitChoiceIn = quantity.GetUnitChoice(UnitChoiceIDIn);

                if (ValueConversionList != null)
                    success = ValueConversion.Calculate(quantity, unitChoiceIn, unitChoiceOut, ValueConversionList);
            }
            return success;
        }
    }
}
