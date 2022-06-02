using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class PoreDiameterQuantity : SmallLengthQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 0.0000001;

        private static PoreDiameterQuantity instance_ = null;

        public static new PoreDiameterQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new PoreDiameterQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public PoreDiameterQuantity() : base()
        {
            Name = "Pore Diameter";
            ID = new Guid("781affbc-fae3-40a0-a110-fd3bdfd7d41f");
        }

    }
}
