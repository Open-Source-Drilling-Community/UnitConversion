using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class PositionQuantity : LengthQuantity, IEngineeringQuantity
    {
        public virtual double? MeaningFullPrecisionInSI { get; } = 0.01;

        private static PositionQuantity instance_ = null;

        public static new PositionQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new PositionQuantity();
                }
                return instance_;
            }
        }

        protected PositionQuantity() : base()
        {
            Name = "Position";
            ID = new Guid("20f58500-7e00-41e7-acc4-99e9de9bfd07");
            Reset();
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Metre));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Kilometer));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Feet));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.USSurveyFeet));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Yard));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Surveyor_sChain));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Mile));
            PostProcess();
        }
    }
}
