using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingVolumetricFlowRateOfChangeQuantity : VolumetricFlowRateOfChangeQuantity, IEngineeringQuantity
    {
        public virtual double? MeaningFullPrecisionInSI { get; } = 1E-06;

        private static DrillingVolumetricFlowRateOfChangeQuantity instance_ = null;

        public static new DrillingVolumetricFlowRateOfChangeQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingVolumetricFlowRateOfChangeQuantity();
                }
                return instance_;
            }
        }

        protected DrillingVolumetricFlowRateOfChangeQuantity() : base()
        {
            Name = "DrillingVolumetricFlowRateOfChange";
            ID = new Guid("244ade8c-591d-44d4-bca6-3798046d90a1");
            Reset();
            this.UnitChoices.Add(VolumetricFlowRateOfChangeQuantity.Instance.GetUnitChoice(VolumetricFlowRateOfChangeQuantity.UnitChoicesEnum.CubicMeterPerSecondSquare));
            this.UnitChoices.Add(VolumetricFlowRateOfChangeQuantity.Instance.GetUnitChoice(VolumetricFlowRateOfChangeQuantity.UnitChoicesEnum.LiterPerMinutePerSecond));
            this.UnitChoices.Add(VolumetricFlowRateOfChangeQuantity.Instance.GetUnitChoice(VolumetricFlowRateOfChangeQuantity.UnitChoicesEnum.UKGallonPerMinutePerSecond));
            this.UnitChoices.Add(VolumetricFlowRateOfChangeQuantity.Instance.GetUnitChoice(VolumetricFlowRateOfChangeQuantity.UnitChoicesEnum.USGallonPerMinutePerSecond));
            PostProcess();
        }

    }
}
