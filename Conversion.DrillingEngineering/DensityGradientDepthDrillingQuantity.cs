using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DensityGradientDepthDrillingQuantity : DensityGradientDepthQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.001;

        private static DensityGradientDepthDrillingQuantity instance_ = null;

        public static new DensityGradientDepthDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DensityGradientDepthDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DensityGradientDepthDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Density Gradient Depth (drilling)" };
            ID = new Guid("787c3f65-b6d5-4866-885b-12571b1d9734");
            Reset();
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.KilogramPerCubicMetrePerMetre));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.GramPerCubicCentimetrePer100Metre));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUKPer100Foot));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUKPer30Foot));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUKPerFoot));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUSPer100Foot));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUSPer30Foot));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.PoundPerGallonUSPerFoot));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.SpecificGravityPer100Metre));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.SpecificGravityPer10Metre));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.SpecificGravityPer30Metre));
            this.UnitChoices.Add(DensityGradientDepthQuantity.Instance.GetUnitChoice(DensityGradientDepthQuantity.UnitChoicesEnum.SpecificGravityPerMetre));
        }


    }
}
