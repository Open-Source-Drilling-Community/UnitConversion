using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class PipeDiameterQuantity : SmallLengthQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 0.0001;

        private static PipeDiameterQuantity instance_ = null;

        public static PipeDiameterQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new PipeDiameterQuantity();
                }
                return instance_;
            }
        }

        protected PipeDiameterQuantity() : base()
        {
            Name = "Pipe Diameter";
            ID = new Guid("28a2fe65-db50-46ec-8b1d-2a26286a5813");
        }

    }
}
