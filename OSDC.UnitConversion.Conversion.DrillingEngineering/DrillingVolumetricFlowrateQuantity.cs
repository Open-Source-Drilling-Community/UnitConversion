using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingVolumetricFlowrateQuantity : VolumetricFlowRateQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 0.0001;

        private static DrillingVolumetricFlowrateQuantity instance_ = null;

        public static new DrillingVolumetricFlowrateQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingVolumetricFlowrateQuantity();
                }
                return instance_;
            }
        }

        protected DrillingVolumetricFlowrateQuantity() : base()
        {
            Name = "DrillingVolumetricFlowrate";
            ID = new Guid("7b12c115-3c20-4d45-b4cf-86af29255b14");
            Reset();
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.CubicMeterPerSecond));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.LiterPerMinute));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.UKGallonPerMinute));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.USGallonPerMinute));
            PostProcess();
        }
    }
}
