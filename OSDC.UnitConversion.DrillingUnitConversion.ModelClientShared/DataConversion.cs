using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.DrillingUnitConversion.ModelClientShared
{
    public partial class DataConversion
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public DataConversion() : base()
        {

        }
        /// <summary>
        /// copy constructor
        /// </summary>
        /// <param name="conversion"></param>
        public DataConversion(DataConversion conversion) : base()
        {
            if (conversion != null)
            {
                DataIn = conversion.DataIn;
                DataOut = conversion.DataOut;
                DataOutString = conversion.DataOutString;
                DataOutUnitChoiceLabel = conversion.DataOutUnitChoiceLabel;
                Conversion = conversion.Conversion;
            }
        }
    }
}
