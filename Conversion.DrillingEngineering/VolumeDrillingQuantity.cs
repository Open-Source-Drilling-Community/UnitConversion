using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class VolumeDrillingQuantity : VolumeQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.0001;

        private static VolumeDrillingQuantity instance_ = null;

        public static new VolumeDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new VolumeDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public VolumeDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Volume (drilling)" };
            ID = new Guid("b8c9f810-d576-4523-a26f-921305c7f7b4");
            Reset();
            this.UnitChoices.Add(VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.CubicMetre));
            this.UnitChoices.Add(VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.Litre));
            this.UnitChoices.Add(VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.USGallon));
            this.UnitChoices.Add(VolumeQuantity.Instance.GetUnitChoice(VolumeQuantity.UnitChoicesEnum.UKGallon));
        }

    }
}
