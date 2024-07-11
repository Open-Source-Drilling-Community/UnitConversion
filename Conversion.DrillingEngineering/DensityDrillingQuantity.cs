using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DensityDrillingQuantity : DensityQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1;

        private static DensityDrillingQuantity instance_ = null;

        public static new DensityDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DensityDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DensityDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Density (drilling)" };
            ID = new Guid("60f2af98-56e4-4f9c-8438-59646a35fc0d");
            Reset();
            this.UnitChoices.Add(DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.GramPerCubicCentimetre));
            this.UnitChoices.Add(DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.GramPerCubicMetre));
            this.UnitChoices.Add(DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.KilogramPerCubicMetre));
            this.UnitChoices.Add(DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.PoundPerCubicFoot));
            this.UnitChoices.Add(DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.PoundPerGallonUK));
            this.UnitChoices.Add(DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.PoundPerGallonUS));
            this.UnitChoices.Add(DensityQuantity.Instance.GetUnitChoice(DensityQuantity.UnitChoicesEnum.SpecificGravity));
        }


    }
}
