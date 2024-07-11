using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class SmallRotationFrequencyQuantity :TorqueQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1.6666e-4;

        private static SmallRotationFrequencyQuantity instance_ = null;

        public static new SmallRotationFrequencyQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new SmallRotationFrequencyQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public SmallRotationFrequencyQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Small Rotation Frequency", "Small rotary speed", "Small RPM" };
            ID = new Guid("b7ab1664-3d56-4ae5-842a-e4d6d0475ef9");
            Reset();
            this.UnitChoices.Add(RotationFrequencyQuantity.Instance.GetUnitChoice(RotationFrequencyQuantity.UnitChoicesEnum.Hertz));
            this.UnitChoices.Add(RotationFrequencyQuantity.Instance.GetUnitChoice(RotationFrequencyQuantity.UnitChoicesEnum.RPM));
        }

    }
}
