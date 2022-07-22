using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingDensityRateOfChangeQuantity : DensityRateOfChangeQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.001;

        private static DrillingDensityRateOfChangeQuantity instance_ = null;

        public static new DrillingDensityRateOfChangeQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingDensityRateOfChangeQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingDensityRateOfChangeQuantity() : base()
        {
            Name = "DrillingDensitySpeed";
            ID = new Guid("af63f164-0fb7-42c0-ac55-06e40b6c12e5");
            Reset();
            this.UnitChoices.Add(DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.GramPerCubicCentimeterPerHour));
            this.UnitChoices.Add(DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.KilogramPerCubicMeterPerSecond));
            this.UnitChoices.Add(DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.PoundPerGallonUKPerHour));
            this.UnitChoices.Add(DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.PoundPerGallonUKPerMinute));
            this.UnitChoices.Add(DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.PoundPerGallonUKPerSecond));
            this.UnitChoices.Add(DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.PoundPerGallonUSPerHour));
            this.UnitChoices.Add(DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.PoundPerGallonUSPerMinute));
            this.UnitChoices.Add(DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.PoundPerGallonUSPerSecond));
            this.UnitChoices.Add(DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.SpecificGravityPerHour));
            this.UnitChoices.Add(DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.SpecificGravityPerMinute));
            this.UnitChoices.Add(DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.SpecificGravityPerSecond));
        }


    }
}
