using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class PoreDiameterQuantity : SmallLengthQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 0.0000001;

        private static PoreDiameterQuantity instance_ = null;

        public static PoreDiameterQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new PoreDiameterQuantity();
                }
                return instance_;
            }
        }

        protected PoreDiameterQuantity() : base()
        {
            Name = "Pore Diameter";
            ID = new Guid("781affbc-fae3-40a0-a110-fd3bdfd7d41f");
        }

    }
}
