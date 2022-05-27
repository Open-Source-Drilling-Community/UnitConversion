using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class AmountSubstanceQuantity : BasePhysicalQuantity
    {
        public override string DimensionSymbol { get; } = "N";
        public override string SIUnitName { get; } = "mole";

        public override string SIUnitLabel { get; } = "mol";
        public override double AmountSubstanceDimension { get; } = 1;

        private static AmountSubstanceQuantity instance_ = null;

        public static AmountSubstanceQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new AmountSubstanceQuantity();
                }
                return instance_;
            }
        }

        protected AmountSubstanceQuantity() : base()
        {
            Name = "Amount Substance";
            ID = new Guid("200be1eb-c278-447c-9b15-32d20fc778b9");
            UnitChoices = new List<UnitChoice>()
            {
                 new UnitChoice
                {
                    UnitName = SIUnitName,
                    UnitLabel = SIUnitLabel,
                    ID = new Guid("d1072bb3-265e-400a-91b2-9c49616dc3de"),
                    ConversionFactorFromSI = 1.0,
                    IsSI = true
                },
                new UnitChoice
                {
                    UnitName = "decimole",
                    UnitLabel ="dmol",
                    ID = new Guid("b458e56b-edc3-48c3-8858-75d507f1f1f2"),
                    ConversionFactorFromSI = 10.0
                },
                new UnitChoice
                {
                    UnitName = "centimole",
                    UnitLabel ="cmol",
                    ID = new Guid("4d83c0db-ddc4-4087-ae50-076148976cad"),
                    ConversionFactorFromSI = 100.0
                },
                new UnitChoice
                {
                    UnitName = "millimole",
                    UnitLabel ="mmol",
                    ID = new Guid("0a83a1b6-cef4-4899-bcd4-4aa1e10d232a"),
                    ConversionFactorFromSI = 1000.0
                },
                new UnitChoice
                {
                    UnitName = "micromole",
                    UnitLabel ="µmol",
                    ID = new Guid("ec2669ad-9742-4667-8a14-76e00c47a41e"),
                    ConversionFactorFromSI = 1000000.0
                },
                new UnitChoice
                {
                    UnitName = "nanomole",
                    UnitLabel ="nmol",
                    ID = new Guid("dc8d0034-ecfa-4dbf-a24c-f1851c4aaf9c"),
                    ConversionFactorFromSI = 1000000000.0
                },
                new UnitChoice
                {
                    UnitName = "picomole",
                    UnitLabel ="pmol",
                    ID = new Guid("642555ea-37f0-49b9-9f21-8dd616d477c4"),
                    ConversionFactorFromSI = 1000000000000.0
                },
                new UnitChoice
                {
                    UnitName = "kilomole",
                    UnitLabel ="kmol",
                    ID = new Guid("01157606-070e-41a2-8c78-84a7ae950bd6"),
                    ConversionFactorFromSI = 0.001
                }
            };
            PostProcess();
        }
    }

}
