using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DensityRateOfChangeDrillingQuantity : DensityRateOfChangeQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.001;

        private static DensityRateOfChangeDrillingQuantity instance_ = null;

        public static new DensityRateOfChangeDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DensityRateOfChangeDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DensityRateOfChangeDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Density Rate of Change (drilling)" };
            ID = new Guid("af63f164-0fb7-42c0-ac55-06e40b6c12e5");
            Reset();
            this.UnitChoices.Add(DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.GramPerCubicCentimetrePerHour));
            this.UnitChoices.Add(DensityRateOfChangeQuantity.Instance.GetUnitChoice(DensityRateOfChangeQuantity.UnitChoicesEnum.KilogramPerCubicMetrePerSecond));
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
