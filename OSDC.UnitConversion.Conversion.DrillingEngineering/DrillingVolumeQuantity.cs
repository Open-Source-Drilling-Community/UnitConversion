using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingVolumeQuantity : VolumeQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.0001;

        private static DrillingVolumeQuantity instance_ = null;

        public static new DrillingVolumeQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingVolumeQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingVolumeQuantity() : base()
        {
            Name = "DrillingVolume";
            ID = new Guid("b8c9f810-d576-4523-a26f-921305c7f7b4");
            Reset();
            this.UnitChoices.Add(VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.CubicMeter));
            this.UnitChoices.Add(VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.Liter));
            this.UnitChoices.Add(VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.USGallon));
            this.UnitChoices.Add(VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.UKGallon));
        }

    }
}
