using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class ElongationGradientDrillingQuantity : ElongationGradientQuantity
    {
        
        public override double? MeaningfulPrecisionInSI { get; } = 0.01;
        private static ElongationGradientDrillingQuantity instance_ = null;

        public static new ElongationGradientDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new ElongationGradientDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public ElongationGradientDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Elongation Gradient (drilling)" };
            ID = new Guid("4410a514-a65a-48ca-82d1-ab788b3d2df9");
            Reset();
            this.UnitChoices.Add(ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.MetrePerMetre));
            this.UnitChoices.Add(ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.MillimetrePerMetre));
            this.UnitChoices.Add(ElongationGradientQuantity.Instance.GetUnitChoice(ElongationGradientQuantity.UnitChoicesEnum.InchPerFoot));
        }
        
    }
}
