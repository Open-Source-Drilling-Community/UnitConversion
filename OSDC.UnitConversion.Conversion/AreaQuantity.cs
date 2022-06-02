using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class AreaQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = "A";
        public override string SIUnitName { get; } = "SquareMeter";
        public override string SIUnitLabel { get; } = "m²";
        private static AreaQuantity instance_ = null;

        public static AreaQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new AreaQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        protected AreaQuantity() : base()
        {
            Name = "Area";
            ID = new Guid("2a892bab-1b39-4ae4-b2d2-989621b09557");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("6225a0d7-d2f1-4bb1-9721-5b260bac26ee"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "SquareKilometer",
          UnitLabel = "km²",
          ID = new Guid("6353513a-6e38-4a58-b20c-d3e8d7b70fb8"),
          ConversionFactorFromSI = 1E-06
        },
        new UnitChoice
        {
          UnitName = "Hectar",
          UnitLabel = "ha",
          ID = new Guid("14313265-7985-4010-a19a-5ffaebe05092"),
          ConversionFactorFromSI = 1.0/10000.0
        },
        new UnitChoice
        {
          UnitName = "SquareDecimeter",
          UnitLabel = "dm²",
          ID = new Guid("125fd8d6-d1eb-4826-a952-5219603409ab"),
          ConversionFactorFromSI = 100
        },
         new UnitChoice
        {
          UnitName = "SquareCentimeter",
          UnitLabel = "cm²",
          ID = new Guid("d74bb2bc-9c86-4be4-bff1-88cac7b1049b"),
          ConversionFactorFromSI = 10000
        },
        new UnitChoice
        {
          UnitName = "SquareMillimeter",
          UnitLabel = "mm²",
          ID = new Guid("0b87d221-284a-4e8c-8a60-50c522f9ade4"),
          ConversionFactorFromSI = 1000000
        },
        new UnitChoice
        {
          UnitName = "SquareMicrometer",
          UnitLabel = "µm²",
          ID = new Guid("bec98c97-72c7-4485-9138-058ed14e7fbe"),
          ConversionFactorFromSI = 1000000000000
        },
        new UnitChoice
        {
          UnitName = "SquareFoot",
          UnitLabel = "ft²",
          ID = new Guid("5a59332e-17b3-4fa2-9527-12d06a2b4248"),
          ConversionFactorFromSI = 10.763910416709722
        },
        new UnitChoice
        {
          UnitName = "SquareInch",
          UnitLabel = "in²",
          ID = new Guid("294bc6d0-5be7-4c70-95f3-ad9dc50f02cf"),
          ConversionFactorFromSI = 1550.0031000062002
        },
        new UnitChoice
        {
          UnitName = "SquareYard",
          UnitLabel = "yd²",
          ID = new Guid("ae3df24c-e5db-4b88-9e81-228f29855f1b"),
          ConversionFactorFromSI = 1.0/0.83612736
        },
        new UnitChoice
        {
          UnitName = "Acre",
          UnitLabel = "ac",
          ID = new Guid("bc94456a-b8b9-49ac-b349-eaded6c984c6"),
          ConversionFactorFromSI = 1.0/4046.8564224
        },
        new UnitChoice
        {
          UnitName = "SquareMile",
          UnitLabel = "mi²",
          ID = new Guid("5bbe8c59-cce9-47c8-b357-c5a15610af72"),
          ConversionFactorFromSI = 1.0/2589988.110336
        },

      };
        }
    }
}
