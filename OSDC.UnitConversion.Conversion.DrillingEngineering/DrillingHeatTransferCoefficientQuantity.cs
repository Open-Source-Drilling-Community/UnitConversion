using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingHeatTransferCoefficientQuantity : HeatTransferCoefficientQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 0.0001;
        private static DrillingHeatTransferCoefficientQuantity instance_ = null;

        public static new DrillingHeatTransferCoefficientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingHeatTransferCoefficientQuantity();
                }
                return instance_;
            }
        }

        protected DrillingHeatTransferCoefficientQuantity() : base()
        {
            Name = "DrillingHeatTransferCoefficient";
            ID = new Guid("c99547c5-b545-4060-bd82-eadc13772493");
            Reset();
            this.UnitChoices.Add(HeatTransferCoefficientQuantity.Instance.GetUnitChoice(HeatTransferCoefficientQuantity.UnitChoicesEnum.WattPerMeterSquaredPerKelvin));
            this.UnitChoices.Add(HeatTransferCoefficientQuantity.Instance.GetUnitChoice(HeatTransferCoefficientQuantity.UnitChoicesEnum.BritishThermalUnitPerHourPerSquareFootPerDegreeFahrenheit));
            PostProcess();
        }

    }
}
