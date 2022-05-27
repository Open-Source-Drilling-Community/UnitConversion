using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class AngleVariationGradientQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "RadianPerMeter";
        public override string SIUnitLabel { get; } = "rd/m";
        public override double LengthDimension { get; } = -1;
        private static AngleVariationGradientQuantity instance_ = null;

        public static AngleVariationGradientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new AngleVariationGradientQuantity();
                }
                return instance_;
            }
        }
        protected AngleVariationGradientQuantity() : base()
        {
            Name = "AngleVariationGradient";
            ID = new Guid("aed9c464-1073-448b-be62-a6a0c2a53dbc");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("5d9782b6-c4c7-47ca-a86b-dce3f63c3747"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "DegreePerMeter",
          UnitLabel = "°/m",
          ID = new Guid("2fcd4219-8879-4494-9563-5173ec2292fa"),
          ConversionFactorFromSI = 57.29577951308232
        },
         new UnitChoice
        {
          UnitName = "DegreePerCentimeter",
          UnitLabel = "°/cm",
          ID = new Guid("7f4f63d6-5ea8-4c6b-8be4-81f52b7060c7"),
          ConversionFactorFromSI = 57.29577951308232/100.0
        },
        new UnitChoice
        {
          UnitName = "DegreePerFoot",
          UnitLabel = "°/ft",
          ID = new Guid("23bf7716-5779-4607-aef7-1e0eeb7f201b"),
          ConversionFactorFromSI = 57.29577951308232*0.3048
        },
        new UnitChoice
        {
          UnitName = "DegreePerInch",
          UnitLabel = "°/in",
          ID = new Guid("271db65d-2a9f-4fec-a52a-21e13e106dd4"),
          ConversionFactorFromSI = 57.29577951308232*0.0254
        }
      };
            PostProcess();
        }
    }
}
