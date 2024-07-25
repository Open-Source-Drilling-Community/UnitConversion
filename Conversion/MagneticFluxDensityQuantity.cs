using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class MagneticFluxDensityQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "tesla";
        public override string SIUnitLabel { get; } = "T";
        public override double MassDimension { get; } = 1;
        public override double TimeDimension { get; } = -2;
        public override double ElectricCurrentDimension { get; } = -1;
        private static MagneticFluxDensityQuantity instance_ = null;

        public static MagneticFluxDensityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new MagneticFluxDensityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public MagneticFluxDensityQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Magnetic Flux Density" };
            ID = new Guid("b9a3f96b-8861-4b03-9c8a-3c0d7d6ec139");
            UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                    UnitName = SIUnitName,
                    UnitLabel = SIUnitLabel,
                    ID = new Guid("33c3b59d-9876-4918-9f31-f22de88d7bde"),
                    ConversionFactorFromSI = 1.0,
                    IsSI = true
                },
                new UnitChoice
                {
                    UnitName = "gauss",
                    UnitLabel = "G",
                    ID = new Guid("c09cd87d-8a84-45d0-88d3-20bb5cc48559"),
                    ConversionFactorFromSI = 10000.0,
                    IsSI = true
                },
                new UnitChoice
                {
                    UnitName = "milligauss",
                    UnitLabel = "mG",
                    ID = new Guid("41ace729-a2ff-4047-adc3-375829de64c6"),
                    ConversionFactorFromSI = 10000000.0
                },
                new UnitChoice
                {
                    UnitName = "millitesla",
                    UnitLabel = "mT",
                    ID = new Guid("9b6d864e-6775-4668-a59d-e1ab432f8960"),
                    ConversionFactorFromSI = 1000.0
                },
                new UnitChoice
                {
                    UnitName = "microtesla",
                    UnitLabel = "µT",
                    ID = new Guid("c6b30197-be6b-41b7-803d-a8de61338612"),
                    ConversionFactorFromSI = 1000000.0
                },
                new UnitChoice
                {
                    UnitName = "nanotesla",
                    UnitLabel = "nT",
                    ID = new Guid("9bef9def-8cd3-4f7b-b991-290d3441b3d4"),
                    ConversionFactorFromSI = 1000000000.0
                },
                new UnitChoice
                {
                    UnitName = "maxwell per square centimetre",
                    UnitLabel = "Mx/cm²",
                    ID = new Guid("d1b202cb-87c6-417a-947c-5247e5cdfe82"),
                    ConversionFactorFromSI = 10000.0
                },
                new UnitChoice
                {
                    UnitName = "weber per square metre",
                    UnitLabel = "Wb/m²",
                    ID = new Guid("fefe997a-f3a6-4663-a1de-32889ee0cf15"),
                    ConversionFactorFromSI = 1.0
                }
            };
        }
    }
}