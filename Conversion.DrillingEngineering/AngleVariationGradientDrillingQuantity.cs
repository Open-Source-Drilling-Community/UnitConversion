using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class AngleVariationGradientDrillingQuantity : AngleVariationGradientQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.00017453292519943296;

        private static AngleVariationGradientDrillingQuantity instance_ = null;

        public static new AngleVariationGradientDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new AngleVariationGradientDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public AngleVariationGradientDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Angle Variation Gradient (drilling)" };
            ID = new Guid("e6f22876-ca88-4d0e-a4a5-c76b0db3556f");
            Reset();
            this.UnitChoices.Add(AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.RadianPerMetre));
            this.UnitChoices.Add(AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.DegreePerMetre));
            this.UnitChoices.Add(AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.DegreePerFoot));
            this.UnitChoices.Add(AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.DegreePerCentimetre));
            this.UnitChoices.Add(AngleVariationGradientQuantity.Instance.GetUnitChoice(AngleVariationGradientQuantity.UnitChoicesEnum.DegreePerInch));
        }

    }
}
