using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class DynamicViscosityQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "pascal second";
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
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public DynamicViscosityQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Dynamic Viscosity" };
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
                    UnitName = "centipoise",
                    UnitLabel = "cP",
                    ID = new Guid("a71ef873-6ea2-4922-a100-231177de0e85"),
                    ConversionFactorFromSI = 1000
                },
                new UnitChoice
                {
                    UnitName = "micropascal second",
                    UnitLabel = "µPa•s",
                    ID = new Guid("ba54cce5-29ad-464a-9263-ae4cfa96328d"),
                    ConversionFactorFromSI = 1000000
                },
                new UnitChoice
                {
                    UnitName = "micropoise",
                    UnitLabel = "µP",
                    ID = new Guid("5cae22bd-1294-4aa7-9666-a9a2080d53e8"),
                    ConversionFactorFromSI = 10000000
                },
                new UnitChoice
                {
                    UnitName = "pound second per 100 square foot",
                    UnitLabel = "lb•s/100ft²",
                    ID = new Guid("b48720b9-8eb5-4b5c-8da1-ca2312fdff01"),
                    ConversionFactorFromSI = 2.0887
                },
                new UnitChoice
                {
                    UnitName = "dyne second per square centimetre",
                    UnitLabel = "dyne•s/cm²",
                    ID = new Guid("90ce61e5-46db-47f9-9c22-1c0f19068132"),
                    ConversionFactorFromSI = 10.0
                }
            };
        }
    }
}
