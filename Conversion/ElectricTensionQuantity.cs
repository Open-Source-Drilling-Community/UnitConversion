using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class ElectricTensionQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "volt";
        public override string SIUnitLabel { get; } = "V";
        public override double LengthDimension { get; } = 2;
        public override double MassDimension { get; } = 1;
        public override double TimeDimension { get; } = -3;
        public override double ElectricCurrentDimension { get; } = -1;
        public override double? MeaningfulPrecisionInSI { get; } = 0.01;
        private static ElectricTensionQuantity instance_ = null;

        public static ElectricTensionQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new ElectricTensionQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public ElectricTensionQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Electric Tension" };
            ID = new Guid("da5094a4-7481-4246-9def-1bd3b6f893a1");
            UnitChoices = new List<UnitChoice>()
            {
        new UnitChoice
        {
          UnitName = "volt",
          UnitLabel = "V",
          ID = new Guid("618fafff-fc9c-4d22-a64d-b7579931aa93"),
          ConversionFactorFromSI = 1.0/Factors.Unit,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "millivolt",
          UnitLabel = "mV",
          ID = new Guid("f186f5d4-2b0b-4cfe-b24c-0c02d3155cf8"),
          ConversionFactorFromSI = 1.0/Factors.Milli
        },
        new UnitChoice
        {
          UnitName = "centivolt",
          UnitLabel = "cV",
          ID = new Guid("ee01194e-dee3-4b50-8312-5fde3c8f774e"),
          ConversionFactorFromSI = 1.0/Factors.Centi
        },
        new UnitChoice
        {
          UnitName = "microvolt",
          UnitLabel = "µV",
          ID = new Guid("ede7e093-3e7d-429a-8c22-3b35ab5b20f2"),
          ConversionFactorFromSI = 1.0/Factors.Micro
        },
        new UnitChoice
        {
          UnitName = "nanovolt",
          UnitLabel = "nV",
          ID = new Guid("86dfcbe1-af8c-4081-b6ed-481eb44ab890"),
          ConversionFactorFromSI = 1.0/Factors.Nano
        },
        new UnitChoice
        {
          UnitName = "picovolt",
          UnitLabel = "pV",
          ID = new Guid("19fb81d7-4991-4902-a1fd-55420789ac59"),
          ConversionFactorFromSI = 1.0/Factors.Pico
        },
        new UnitChoice
        {
          UnitName = "kilovolt",
          UnitLabel = "kV",
          ID = new Guid("6ffc60bc-ec9f-44d4-961b-79d9e593bf64"),
          ConversionFactorFromSI = 1.0/Factors.Kilo
        },
        new UnitChoice
        {
          UnitName = "megavolt",
          UnitLabel = "MV",
          ID = new Guid("3342ddbc-b1b2-46f8-addc-216ce94a616a"),
          ConversionFactorFromSI = 1.0/Factors.Mega
        },
        new UnitChoice
        {
          UnitName = "gigavolt",
          UnitLabel = "GV",
          ID = new Guid("640f2693-dd92-472b-b2ec-0052fc7b7a11"),
          ConversionFactorFromSI = 1.0/Factors.Giga
        }
      };
        }
    }
}
