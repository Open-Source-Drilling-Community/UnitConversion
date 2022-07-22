using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingDensityGradientDepthQuantity : DensityGradientDepthQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.001;

        private static DrillingDensityGradientDepthQuantity instance_ = null;

        public static new DrillingDensityGradientDepthQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingDensityGradientDepthQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingDensityGradientDepthQuantity() : base()
        {
            Name = "DrillingDensityGradientDepth";
            ID = new Guid("787c3f65-b6d5-4866-885b-12571b1d9734");
            Reset();
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.KilogramPerCubicMeterPerMeter));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.GramPerCubicCentimeterPer100Meter));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUKPer100Foot));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUKPer30Foot));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUKPerFoot));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUSPer100Foot));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUSPer30Foot));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUSPerFoot));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.SpecificGravityPer100Meter));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.SpecificGravityPer10Meter));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.SpecificGravityPer30Meter));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.SpecificGravityPerMeter));
        }


    }
}
