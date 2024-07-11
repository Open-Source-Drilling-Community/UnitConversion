using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class CableDiameterQuantity : SmallLengthQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.0005;

        private static CableDiameterQuantity instance_ = null;

        public static new CableDiameterQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new CableDiameterQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public CableDiameterQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Cable Diameter (drilling)" };
            ID = new Guid("6b3db5b2-7e30-47f7-91c5-5951dd3f9246");
        }
    }
}
