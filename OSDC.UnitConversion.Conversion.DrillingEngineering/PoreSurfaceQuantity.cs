using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class PoreSurfaceQuantity : AreaQuantity
    {
        
        public override string TypicalSymbol { get; } = null;
        public override double? MeaningFullPrecisionInSI { get; } = 1E-13;
        private static PoreSurfaceQuantity instance_ = null;

        public static new PoreSurfaceQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new PoreSurfaceQuantity();
                }
                return instance_;
            }
        }
        protected PoreSurfaceQuantity() : base()
        {
            Name = "PoreSurface";
            ID = new Guid("c88cc254-b870-44a6-b896-5863472bdcd0");
            Reset();
            this.UnitChoices.Add(AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareMeter));
            this.UnitChoices.Add(AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareMillimeter));
            this.UnitChoices.Add(AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareMicrometer));
            this.UnitChoices.Add(AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareFoot));
            PostProcess();
        }
        
    }
}
