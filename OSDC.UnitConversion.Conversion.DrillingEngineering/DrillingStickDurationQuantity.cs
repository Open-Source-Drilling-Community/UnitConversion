using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingStickDurationQuantity : TimeQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.001;

        private static DrillingStickDurationQuantity instance_ = null;

        public static new DrillingStickDurationQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingStickDurationQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingStickDurationQuantity() : base()
        {
            Name = "DrillingStickDuration";
            ID = new Guid("1e9bafaa-bbf1-4a29-9811-39b5e2280499");
            Reset();
            this.UnitChoices.Add(TimeQuantity.Instance.GetUnitChoice(TimeQuantity.UnitChoicesEnum.Second));
            this.UnitChoices.Add(TimeQuantity.Instance.GetUnitChoice(TimeQuantity.UnitChoicesEnum.Millisecond));
        }
    }
}
