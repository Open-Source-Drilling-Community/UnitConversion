﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class MagneticFluxQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "weber";
        public override string SIUnitLabel { get; } = "Wb";
        public override double MassDimension { get; } = 1;
        public override double LengthDimension { get; } = 2;
        public override double TimeDimension { get; } = -2;
        public override double ElectricCurrentDimension { get; } = -1;
        private static MagneticFluxQuantity instance_ = null;

        public static MagneticFluxQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new MagneticFluxQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public MagneticFluxQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Magnetic Flux" };
            ID = new Guid("0d36345b-624d-47c1-9d20-e627a6c6c13a");
            UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                    UnitName = SIUnitName,
                    UnitLabel = SIUnitLabel,
                    ID = new Guid("d790689d-e7dd-43d8-a3c0-c17ccc8073e5"),
                    ConversionFactorFromSI = 1.0,
                    IsSI = true
                },
                new UnitChoice
                {
                    UnitName = "milliweber",
                    UnitLabel = "mWb",
                    ID = new Guid("94f03fc7-b0bb-4356-8787-c9e33f6559d2"),
                    ConversionFactorFromSI = 1000.0
                },
                new UnitChoice
                {
                    UnitName = "microweber",
                    UnitLabel = "µWb",
                    ID = new Guid("200b9de7-0635-40eb-8ebd-9cef7c01ac10"),
                    ConversionFactorFromSI = 1000000.0
                },
                new UnitChoice
                {
                    UnitName = "volt second",
                    UnitLabel = "V•s",
                    ID = new Guid("430305c3-d672-4d68-9b16-d0517243a870"),
                    ConversionFactorFromSI = 1.0
                },
                new UnitChoice
                {
                    UnitName = "unit pole",
                    UnitLabel = "unit pole",
                    ID = new Guid("3bac78d4-5601-4cb2-bea1-01d952597a4d"),
                    ConversionFactorFromSI = 7957747.1546
                },
                new UnitChoice
                {
                    UnitName = "megaline",
                    UnitLabel = "megaline",
                    ID = new Guid("cca39e15-ee2e-4b8f-8843-527b329f3e81"),
                    ConversionFactorFromSI = 100.0
                },
                new UnitChoice
                {
                    UnitName = "kiloline",
                    UnitLabel = "kiloline",
                    ID = new Guid("85862477-e913-4bcf-9d24-8248ec975d43"),
                    ConversionFactorFromSI = 100000.0
                },
                new UnitChoice
                {
                    UnitName = "line",
                    UnitLabel = "line",
                    ID = new Guid("40d608dd-b19f-4489-aac3-a3a6b7a55413"),
                    ConversionFactorFromSI = 100000000.0
                },
                new UnitChoice
                {
                    UnitName = "maxwell",
                    UnitLabel = "Mx",
                    ID = new Guid("8c1fcd01-4a3d-469a-a019-d3b35f7ef8b5"),
                    ConversionFactorFromSI = 100000000.0
                },
                new UnitChoice
                {
                    UnitName = "tesla square metre",
                    UnitLabel = "T•m²",
                    ID = new Guid("f6da9f32-0738-4014-aac6-fdc5935fd436"),
                    ConversionFactorFromSI = 1.0
                },
                new UnitChoice
                {
                    UnitName = "tesla square centimetre",
                    UnitLabel = "T•cm²",
                    ID = new Guid("312b97ea-6167-47b5-a046-c6c202fb7eb4"),
                    ConversionFactorFromSI = 10000.0
                },
                new UnitChoice
                {
                    UnitName = "gauss square centimetre",
                    UnitLabel = "G•cm²",
                    ID = new Guid("a0dc1e92-7e84-401f-bca2-a6eb618ef604"),
                    ConversionFactorFromSI = 100000000.0
                },
                new UnitChoice
                {
                    UnitName = "magnetic flux quantum",
                    UnitLabel = "mag flux quant",
                    ID = new Guid("f768bd79-1119-401c-b0df-39a5207273e0"),
                    ConversionFactorFromSI = 483597670318520.0
                }
            };
        }
    }
}
