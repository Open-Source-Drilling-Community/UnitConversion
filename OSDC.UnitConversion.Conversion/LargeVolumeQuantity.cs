using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class LargeVolumeQuantity : VolumeQuantity
    {

        public override double? MeaningfulPrecisionInSI { get; } = 0.1;
        private static LargeVolumeQuantity instance_ = null;

        public static new LargeVolumeQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new LargeVolumeQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public LargeVolumeQuantity() : base()
        {
            Name = "LargeVolume";
            ID = new Guid("f8ab1afa-7b99-403b-9410-93598bbb4089");
            Reset();
            this.UnitChoices.Add(VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.CubicMeter));
            this.UnitChoices.Add(VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.Liter));
            this.UnitChoices.Add(VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.USGallon));
            this.UnitChoices.Add(VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.UKGallon));
            this.UnitChoices.Add(VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.Barrel));
            this.UnitChoices.Add(VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.MillionCubicMeter));
            this.UnitChoices.Add(VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.MillionLiter));
            this.UnitChoices.Add(VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.MillionUKGallon));
            this.UnitChoices.Add(VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.MillionBarrel));
            this.UnitChoices.Add(VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.MillionStandardCubicFoot));
            this.UnitChoices.Add(VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.ThousandStandardCubicFoot));
        }
    }
}
