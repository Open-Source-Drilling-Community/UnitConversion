using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class DynamicViscosityQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "PascalSecond";
        public override string SIUnitLabel { get; } = "Pa•s";
        public override double LengthDimension { get; } = -1;
        public override double MassDimension { get; } = 1;
        public override double TimeDimension { get; } = -1;
        private static DynamicViscosityQuantity instance_ = null;

        public static DynamicViscosityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DynamicViscosityQuantity();
                }
                return instance_;
            }
        }
        protected DynamicViscosityQuantity() : base()
        {
            Name = "DynamicViscosity";
            ID = new Guid("c830517f-5915-4a8f-ba83-bd102c0a935f");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("5707caa4-e293-430d-9575-425305060fcc"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "CentiPoise",
          UnitLabel = "cP",
          ID = new Guid("a71ef873-6ea2-4922-a100-231177de0e85"),
          ConversionFactorFromSI = 1000
        },
        new UnitChoice
        {
          UnitName = "MicroPascalSecond",
          UnitLabel = "µPa•s",
          ID = new Guid("ba54cce5-29ad-464a-9263-ae4cfa96328d"),
          ConversionFactorFromSI = 1000000
        },
        new UnitChoice
        {
          UnitName = "MicroPoise",
          UnitLabel = "µP",
          ID = new Guid("5cae22bd-1294-4aa7-9666-a9a2080d53e8"),
          ConversionFactorFromSI = 10000000
        }
      };
            PostProcess();
        }
    }
}
