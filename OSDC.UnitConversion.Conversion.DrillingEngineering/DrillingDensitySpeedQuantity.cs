using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingDensitySpeedQuantity : DensitySpeedQuantity, IEngineeringQuantity
    {
        public double? MeaningFullPrecisionInSI { get; } = 0.001;

        private static DrillingDensitySpeedQuantity instance_ = null;

        public static new DrillingDensitySpeedQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingDensitySpeedQuantity();
                }
                return instance_;
            }
        }

        protected DrillingDensitySpeedQuantity() : base()
        {
            Name = "DrillingDensitySpeed";
            ID = new Guid("af63f164-0fb7-42c0-ac55-06e40b6c12e5");
            Reset();
            this.UnitChoices.Add(DensitySpeedQuantity.Instance.GetUnitChoice(DensitySpeedQuantity.UnitChoicesEnum.GramPerCubicCentimeterPerHour));
            this.UnitChoices.Add(DensitySpeedQuantity.Instance.GetUnitChoice(DensitySpeedQuantity.UnitChoicesEnum.KilogramPerCubicMeterPerSecond));
            this.UnitChoices.Add(DensitySpeedQuantity.Instance.GetUnitChoice(DensitySpeedQuantity.UnitChoicesEnum.PoundPerGallonUKPerHour));
            this.UnitChoices.Add(DensitySpeedQuantity.Instance.GetUnitChoice(DensitySpeedQuantity.UnitChoicesEnum.PoundPerGallonUKPerMinute));
            this.UnitChoices.Add(DensitySpeedQuantity.Instance.GetUnitChoice(DensitySpeedQuantity.UnitChoicesEnum.PoundPerGallonUKPerSecond));
            this.UnitChoices.Add(DensitySpeedQuantity.Instance.GetUnitChoice(DensitySpeedQuantity.UnitChoicesEnum.PoundPerGallonUSPerHour));
            this.UnitChoices.Add(DensitySpeedQuantity.Instance.GetUnitChoice(DensitySpeedQuantity.UnitChoicesEnum.PoundPerGallonUSPerMinute));
            this.UnitChoices.Add(DensitySpeedQuantity.Instance.GetUnitChoice(DensitySpeedQuantity.UnitChoicesEnum.PoundPerGallonUSPerSecond));
            this.UnitChoices.Add(DensitySpeedQuantity.Instance.GetUnitChoice(DensitySpeedQuantity.UnitChoicesEnum.SpecificGravityPerHour));
            this.UnitChoices.Add(DensitySpeedQuantity.Instance.GetUnitChoice(DensitySpeedQuantity.UnitChoicesEnum.SpecificGravityPerMinute));
            this.UnitChoices.Add(DensitySpeedQuantity.Instance.GetUnitChoice(DensitySpeedQuantity.UnitChoicesEnum.SpecificGravityPerSecond));
            PostProcess();
        }


    }
}
