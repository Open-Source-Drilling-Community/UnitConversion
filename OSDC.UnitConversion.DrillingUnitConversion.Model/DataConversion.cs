using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.DrillingUnitConversion.Model
{
    /// <summary>
    /// a class to contain a data that needs to be converted, either from SI or to SI
    /// </summary>
    public class DataConversion
    {
        /// <summary>
        /// the direction of the conversion
        /// </summary>
        public enum ConversionType { FromSI, ToSI}
        /// <summary>
        /// the input data either in SI or end-user unit, depending on the conversion type
        /// </summary>
        public double DataIn { get; set; }
        /// <summary>
        /// the out data either in end-user or SI unit, depending on the conversion type
        /// </summary>
        public double? DataOut { get; set; }
        /// <summary>
        /// the formatted string to represent the converted data: filled in only when Conversion is FromSI otherwise null
        /// </summary>
        public string DataOutString { get; set; }
        /// <summary>
        /// a string label that represents the unit choice label of the output
        /// </summary>
        public string DataOutUnitChoiceLabel { get; set; }
        /// <summary>
        /// The direction of the conversion
        /// </summary>
        public ConversionType Conversion { get; set; }
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
