using System;
using System.Globalization;

namespace OSDC.UnitConversion.Conversion
{
    public class UnitChoice
    {
        public enum DefaultUnitSetChoiceEnum { SI = 1, Metric = 2, Imperial = 4, US = 8}

        private byte unitSystem_ = 0;

        /// <summary>
        /// the name for that unit choice
        /// </summary>
        public string UnitName { get; set; } = null;
        /// <summary>
        /// the label used for that unit choice
        /// </summary>
        public string UnitLabel { get; set; }
        /// <summary>
        /// a global unique identifier
        /// </summary>
        public Guid ID { get; set; } = Guid.Empty;
        /// <summary>
        /// the conversion factor from SI unit: value_in_unit_choice = ConversionFactorFromSI * value_in_SI + ConversionBiasFromSI
        /// </summary>
        public double ConversionFactorFromSI { get; set; } = 1.0;
        /// <summary>
        /// the conversion bias used when converting from SI unit: value_in_unit_choice = ConversionFactorFromSI * value_in_SI + ConversionBiasFromSI
        /// </summary>
        public double ConversionBiasFromSI { get; set; } = 0.0;
        /// <summary>
        /// true if it is the standard SI unit
        /// </summary>
        public bool IsSI
        {
            get { return (unitSystem_ & (byte)DefaultUnitSetChoiceEnum.SI) != 0; }
            set
            {
                unitSystem_ |= (byte)DefaultUnitSetChoiceEnum.SI;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        internal bool IsDefault(DefaultUnitSetChoiceEnum choice)
        {
            return (unitSystem_ & (byte)choice) != 0;
        }
        /// <summary>
        /// default constructor
        /// </summary>
        public UnitChoice() : base()
        {

        }
        /// <summary>
        /// copy constructor. Copy only the name and conversion parameters
        /// </summary>
        /// <param name="reference"></param>
        public UnitChoice(UnitChoice reference) : base()
        {
            if (reference != null)
            {
                UnitName = reference.UnitName;
                ConversionFactorFromSI = reference.ConversionFactorFromSI;
                ConversionBiasFromSI = reference.ConversionBiasFromSI;
            }
        }

        /// <summary>
        /// convert a SI value into the unit choice
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public double FromSI(double val)
        {
            return val * ConversionFactorFromSI + ConversionBiasFromSI;
        }
        /// <summary>
        /// convert a value in the unit choice into a SI value
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public double ToSI(double val)
        {
            return (val - ConversionBiasFromSI) / ConversionFactorFromSI;
        }

        public string FromSI(double val, double? meaningfulPrecisionInSI)
        {
            double valInUnit = FromSI(val);
            if (meaningfulPrecisionInSI != null)
            {
                int digits = DigitAccuracy(FromSI((double)meaningfulPrecisionInSI));
                return valInUnit.ToString("N" + ((digits >= 0) ? digits : 0), CultureInfo.InvariantCulture.NumberFormat);
            }
            else
            {
                return valInUnit.ToString(CultureInfo.InvariantCulture.NumberFormat);
            }
        }

        public string ToSI(double val, double? meaningfulPrecisionInSI)
        {
            double valInSI = ToSI(val);
            if (meaningfulPrecisionInSI != null)
            {
                int digits = DigitAccuracy((double)meaningfulPrecisionInSI);
                return valInSI.ToString("N" + ((digits >= 0) ? digits : 0), CultureInfo.InvariantCulture.NumberFormat);
            }
            else
            {
                return valInSI.ToString(CultureInfo.InvariantCulture.NumberFormat);
            }
        }

        /// <summary>
        /// return the number of digits after the decimal separator that corresponds to this accuracy
        /// </summary>
        /// <param name="accuracy"></param>
        /// <returns></returns>
        private int DigitAccuracy(double accuracy)
        {
            if (accuracy <= 0)
            {
                return 0;
            }
            else
            {
                return (int)Math.Round(Math.Log10(1 / accuracy));
            }
        }
    }
}
