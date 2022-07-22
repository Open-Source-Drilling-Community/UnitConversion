using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingAreaQuantity : AreaQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1e-6;

        private static DrillingAreaQuantity instance_ = null;

        public static new DrillingAreaQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingAreaQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingAreaQuantity() : base()
        {
            Name = "DrillingArea";
            ID = new Guid("21fc0373-6eda-460b-bacb-070abf2f3add");
            Reset();
            this.UnitChoices.Add(AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareMeter));
            this.UnitChoices.Add(AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareFoot));
            this.UnitChoices.Add(AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareDecimeter));
            this.UnitChoices.Add(AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareYard));
            this.UnitChoices.Add(AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareCentimeter));
            this.UnitChoices.Add(AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareInch));
        }

    }
}
