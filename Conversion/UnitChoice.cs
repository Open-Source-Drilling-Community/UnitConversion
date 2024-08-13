using System;
using System.Globalization;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace OSDC.UnitConversion.Conversion
{
    public class UnitChoice
    {
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
        /// If the formula for calculating the Conversion factor is put here, then the ConversionFactorFromSI is overwritten by the result of the calculation
        /// </summary>
        public string? ConversionFactorFromSIFormula { get; set; } = null;
        /// <summary>
        /// If the formula for calculating the Conversion bias is put here, then the ConversionBiasFromSI is overwritten by the result of the calculation
        /// </summary>
        public string? ConversionBiasFromSIFormula { get; set; } = null;
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
            get { return (unitSystem_ & (byte)BaseUnitSystem.DefaultUnitSystemEnum.SI) != 0; }
            set
            {
                unitSystem_ |= (byte)BaseUnitSystem.DefaultUnitSystemEnum.SI;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        internal bool IsDefault(BaseUnitSystem.DefaultUnitSystemEnum choice)
        {
            return (unitSystem_ & (byte)choice) != 0;
        }
        /// <summary>
        /// default constructor
        /// </summary>
        public UnitChoice() : base()
        {
            Init();
        }
        /// <summary>
        /// copy constructor. Copy only the name and conversion parametres
        /// </summary>
        /// <param name="reference"></param>
        public UnitChoice(UnitChoice reference) : base()
        {
            if (reference != null)
            {
                UnitName = reference.UnitName;
                ConversionFactorFromSIFormula = reference.ConversionFactorFromSIFormula;
                ConversionBiasFromSIFormula = reference.ConversionBiasFromSIFormula;
                ConversionFactorFromSI = reference.ConversionFactorFromSI;
                ConversionBiasFromSI = reference.ConversionBiasFromSI;
            }
            Init();
        }

        private void Init()
        {
            if (!string.IsNullOrEmpty(ConversionFactorFromSIFormula))
            {
                try
                {
                    double result = CSharpScript.EvaluateAsync<double>(ConversionFactorFromSIFormula, ScriptOptions.Default.WithReferences(AppDomain.CurrentDomain.GetAssemblies()).WithImports("OSDC.UnitConversion.Conversion")).GetAwaiter().GetResult();
                    if (!double.IsNaN(result) && !double.IsInfinity(result))
                    {
                        ConversionFactorFromSI = result;
                    }
                }
                catch (Exception e1)
                {
                }
            }
            if (!string.IsNullOrEmpty(ConversionBiasFromSIFormula))
            {
                try
                {
                    double result = CSharpScript.EvaluateAsync<double>(ConversionBiasFromSIFormula, ScriptOptions.Default.WithReferences(AppDomain.CurrentDomain.GetAssemblies()).WithImports("OSDC.UnitConversion.Conversion")).GetAwaiter().GetResult();
                    if (!double.IsNaN(result) && !double.IsInfinity(result))
                    {
                        ConversionBiasFromSI = result;
                    }
                }
                catch (Exception e2)
                {
                }
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
        /// <summary>
        /// generate the truncated string (to a given meaningful precision given in SI) associated to the given SI value, to be converted into the unit choice
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public string FromSI(double val, double? meaningfulPrecisionInSI)
        {
            double valInUnit = FromSI(val);
            return ToStringInUnit(valInUnit, meaningfulPrecisionInSI);
        }

        /// <summary>
        /// generate the truncated string (to a given meaningful precision given in SI) associated to the given value, already converted into the unit choice (useful when unit conversion has already been done)
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public string ToStringInUnit(double valInUnit, double? meaningfulPrecisionInSI)
        {
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
        /// <summary>
        /// generate the truncated string (to a given meaningful precision given in SI) associated to the given value in the unit choice, to be converted into SI unit
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public string ToSI(double val, double? meaningfulPrecisionInSI)
        {
            double valInSI = ToSI(val);
            return ToStringInSI(valInSI, meaningfulPrecisionInSI);
        }
        /// <summary>
        /// generate the truncated string (to a given meaningful precision given in SI) associated to the given value in the unit choice, already converted in SI unit (useful when unit conversion has already been done)
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public string ToStringInSI(double valInSI, double? meaningfulPrecisionInSI)
        {
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
