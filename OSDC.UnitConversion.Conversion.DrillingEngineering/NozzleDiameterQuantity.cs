using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class NozzleDiameterQuantity : SmallLengthQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 0.0001;

        private static NozzleDiameterQuantity instance_ = null;

        public static new NozzleDiameterQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new NozzleDiameterQuantity();
                }
                return instance_;
            }
        }

        protected NozzleDiameterQuantity() : base()
        {
            Name = "Nozzle Diameter";
            ID = new Guid("1fbe2318-851d-4fd7-b711-9c23ffe544c7");
        }

    }
}
