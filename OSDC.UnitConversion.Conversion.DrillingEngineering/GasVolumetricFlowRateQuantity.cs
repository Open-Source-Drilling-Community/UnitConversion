using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class GasVolumetricFlowRateQuantity : VolumetricFlowRateQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 0.01;
        private static GasVolumetricFlowRateQuantity instance_ = null;

        public static new GasVolumetricFlowRateQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new GasVolumetricFlowRateQuantity();
                }
                return instance_;
            }
        }
        protected GasVolumetricFlowRateQuantity() : base()
        {
            Name = "GasVolmetricFlowRate";
            ID = new Guid("453bbddf-4979-4557-ba76-3fd3420fd97e");
            Reset();
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.CubicMeterPerSecond));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.CubicFootPerSecond));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.LiterPerSecond));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.UKGallonPerSecond));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.USGallonPerSecond));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.BarrelPerSecond));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.CubicMeterPerMinute));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.CubicFootPerMinute));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.LiterPerMinute));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.UKGallonPerMinute));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.USGallonPerMinute));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.BarrelPerMinute));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.CubicMeterPerHour));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.CubicFootPerHour));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.LiterPerHour));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.UKGallonPerHour));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.USGallonPerHour));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.BarrelPerHour));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.CubicMeterPerDay));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.CubicFootPerDay));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.LiterPerDay));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.UKGallonPerDay));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.USGallonPerDay));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.BarrelPerDay));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.ThousandStandardCubicFootPerDay));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.MillionCubicMeterPerDay));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.MillionLiterPerDay));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.MillionStandardCubicFootPerDay));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.MillionUKGallonPerDay));
            this.UnitChoices.Add(VolumetricFlowRateQuantity.Instance.GetUnitChoice(VolumetricFlowRateQuantity.UnitChoicesEnum.MillionUSGallonPerDay));
            PostProcess();
        }
    }
}
