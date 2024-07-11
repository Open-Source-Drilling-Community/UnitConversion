using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class PipeDiameterQuantity : SmallLengthQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.0001;

        private static PipeDiameterQuantity instance_ = null;

        public static new PipeDiameterQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new PipeDiameterQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public PipeDiameterQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Pipe Diameter (drilling)" };
            ID = new Guid("28a2fe65-db50-46ec-8b1d-2a26286a5813");
        }

    }
}
