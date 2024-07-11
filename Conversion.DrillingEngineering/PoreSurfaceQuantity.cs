using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class PoreSurfaceQuantity : AreaQuantity
    {
        
        public override string TypicalSymbol { get; } = null;
        public override double? MeaningfulPrecisionInSI { get; } = 1E-13;
        private static PoreSurfaceQuantity instance_ = null;

        public static new PoreSurfaceQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new PoreSurfaceQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public PoreSurfaceQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Pore Surface (drilling)" };
            ID = new Guid("c88cc254-b870-44a6-b896-5863472bdcd0");
            Reset();
            this.UnitChoices.Add(AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareMetre));
            this.UnitChoices.Add(AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareMillimetre));
            this.UnitChoices.Add(AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareMicrometre));
            this.UnitChoices.Add(AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareFoot));
        }
        
    }
}
