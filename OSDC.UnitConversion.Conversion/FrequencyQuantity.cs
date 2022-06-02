using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class FrequencyQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "Hertz";
        public override string SIUnitLabel { get; } = "Hz";
        public override double TimeDimension { get; } = -1;
        private static FrequencyQuantity instance_ = null;

        public static FrequencyQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new FrequencyQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public FrequencyQuantity() : base()
        {
            Name = "Frequency";
            ID = new Guid("8a1ff3d9-95c9-43e1-abb4-4ae9b8df861e");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("7c572c06-0699-4187-9d0c-397f479fe93d"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "KiloHertz",
          UnitLabel = "kHz",
          ID = new Guid("acf483c1-5d7a-4914-afa2-de7abed9be3e"),
          ConversionFactorFromSI = 0.001
        },
        new UnitChoice
        {
          UnitName = "MegaHertz",
          UnitLabel = "MHz",
          ID = new Guid("6dea9f29-d4f4-49a7-86fe-0205d4bab45e"),
          ConversionFactorFromSI = 0.000001
        },
        new UnitChoice
        {
          UnitName = "GigaHertz",
          UnitLabel = "MHz",
          ID = new Guid("655ee4f9-1782-4ec0-894a-afff9b75cac7"),
          ConversionFactorFromSI = 0.000000001
        }
      };
        }
    }
}
