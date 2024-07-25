using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DepthQuantity : LengthQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.001;

        private static DepthQuantity instance_ = null;

        public static new DepthQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DepthQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DepthQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Depth (drilling)" };
            ID = new Guid("c0d965b2-a153-420a-9d03-7a2a272d619e");
            Reset();
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Metre));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Foot));
        }
    }
}
