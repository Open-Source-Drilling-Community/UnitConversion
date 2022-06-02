using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingMassRateQuantity : MassRateQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 0.0001;

        private static DrillingMassRateQuantity instance_ = null;

        public static new DrillingMassRateQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingMassRateQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingMassRateQuantity() : base()
        {
            Name = "DrillingMassRate";
            ID = new Guid("0e218b8e-bc7c-4902-b88d-1cdab4a5dc94");
            Reset();
            this.UnitChoices.Add(MassRateQuantity.Instance.GetUnitChoice(MassRateQuantity.UnitChoicesEnum.KilogramPerSecond));
            this.UnitChoices.Add(MassRateQuantity.Instance.GetUnitChoice(MassRateQuantity.UnitChoicesEnum.KilogramPerMinute));
        }
    }
}
