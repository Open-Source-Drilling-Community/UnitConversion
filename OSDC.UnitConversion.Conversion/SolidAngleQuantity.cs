using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class SolidAngleQuantity : BasePhysicalQuantity
    {
        public override string DimensionSymbol { get; } = "";
        public override string SIUnitName { get; } = "steradian";

        public override string SIUnitSymbol { get; } = "sr";

        public virtual double SolidAngleDimension { get; } = 1;

        private static SolidAngleQuantity instance_ = null;

        public static SolidAngleQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new SolidAngleQuantity();
                }
                return instance_;
            }
        }

        protected SolidAngleQuantity() : base()
        {
            Name = "Solid Angle";
            ID = new Guid("26a7767a-ea4d-417e-a1ef-b7fe674dcd3f");
            UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                    UnitName = SIUnitName,
                    UnitSymbol = SIUnitSymbol,
                    ID = new Guid("aee057f5-3235-4976-b6e6-a57179f0173e"),
                    ConversionFactorFromSI = 1.0,
                    IsSI = true
                },
                new UnitChoice
                {
                    UnitName = "spat",
                    UnitSymbol = "spat",
                    ID = new Guid("44abc0c0-d564-442a-ac80-b08c9d499867"),
                    ConversionFactorFromSI = 1/(4.0*Math.PI)
                },
                new UnitChoice
                {
                    UnitName = "square degree",
                    UnitSymbol = "(°)²",
                    ID = new Guid("ad4b94e8-1a86-42ab-bfc6-9cc7ff7a835f"),
                    ConversionFactorFromSI = (180.0*180.0)/(Math.PI*Math.PI),
                    IsMetric = true,
                    IsImperial = true,
                    IsUS = true
                }
            };
            PostProcess();
        }
    }
}
