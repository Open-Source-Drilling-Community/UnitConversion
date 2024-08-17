using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class SolidAngleQuantity : SymbolizedBasePhysicalQuantity
    {
        public override string DimensionSymbol { get; } = "";
        public override string SIUnitName { get; } = "steradian";

        public override string SIUnitLabel { get; } = "sr";

        public override double SolidAngleDimension { get; } = 1;

        private static SolidAngleQuantity instance_ = null;

        public static SolidAngleQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new SolidAngleQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public static List<UnitChoice> UnitChoiceDescriptions = new List<UnitChoice>()
        {
                new UnitChoice
                {
                    UnitName = "steradian",
                    UnitLabel = "sr",
                    ID = new Guid("aee057f5-3235-4976-b6e6-a57179f0173e"),
                    ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                    IsSI = true
                },
                new UnitChoice
                {
                    UnitName = "spat",
                    UnitLabel = "spat",
                    ID = new Guid("44abc0c0-d564-442a-ac80-b08c9d499867"),
                    ConversionFactorFromSIFormula = "1/(4.0*System.Math.PI)"
                },
                new UnitChoice
                {
                    UnitName = "degree squared",
                    UnitLabel = "(°)²",
                    ID = new Guid("ad4b94e8-1a86-42ab-bfc6-9cc7ff7a835f"),
                    ConversionFactorFromSIFormula = "(180.0*180.0)/(System.Math.PI*System.Math.PI)"
                }
        };
        public SolidAngleQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Solid Angle" };
            ID = new Guid("26a7767a-ea4d-417e-a1ef-b7fe674dcd3f");
            InitializeUnitChoices();
        }
    }
}
