using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class ThermalConductivityQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "watt per metre kelvin";
        public override string SIUnitLabel { get; } = "W/m•K";
        public override double LengthDimension { get; } = 1;
        public override double MassDimension { get; } = 1;
        public override double TimeDimension { get; } = -3;
        public override double TemperatureDimension { get; } = -1;

        private static ThermalConductivityQuantity instance_ = null;

        public static ThermalConductivityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new ThermalConductivityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public ThermalConductivityQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Thermal Conductivity" };
            ID = new Guid("ca23212e-8f2d-4041-89f6-ac8bfa8604fa");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("3ddba24f-4ccf-4cb1-af6c-2829cac3b88f"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "calorie per metre second degree celsius",
          UnitLabel = "Cal/m•s•°C",
          ID = new Guid("d0386fc4-b97b-4874-8c8d-66e093c391ea"),
          ConversionFactorFromSI = 0.238846
        },
        new UnitChoice
        {
          UnitName = "calorie per centimetre second degree celsius",
          UnitLabel = "Cal/cm•s•°C",
          ID = new Guid("5f8706ed-d938-4715-a0ca-2afff423f6e6"),
          ConversionFactorFromSI = 0.00238846
        },
        new UnitChoice
        {
          UnitName = "british thermal unit per hour foot degree fahrenheit",
          UnitLabel = "BUT/h•ft•°F",
          ID = new Guid("43169695-8f6e-42ad-8c07-566dc7651edb"),
          ConversionFactorFromSI = 0.5777893
        },
        new UnitChoice
        {
          UnitName = "british thermal unit inch per hour square foot degree fahrenheit",
          UnitLabel = "BUT•in/h•ft²•°F",
          ID = new Guid("c79c2b27-c956-49a3-9caf-8653017777ca"),
          ConversionFactorFromSI = 6.933472
        }
      };
        }
    }
}
