using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class WeightOnBitQuantity : GravitationalLoadQuantity, IEngineeringQuantity
    {

        public virtual double? MeaningFullPrecisionInSI { get; } = 10;
        private static WeightOnBitQuantity instance_ = null;

        public static new WeightOnBitQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new WeightOnBitQuantity();
                }
                return instance_;
            }
        }
        protected WeightOnBitQuantity() : base()
        {
            Name = "WeightOnBit";
            ID = new Guid("5e75da44-a675-4f0e-a0fb-52b2cb6797ce");
            Reset();
            this.UnitChoices.Add(GravitationalLoadQuantity.Instance.GetUnitChoice(GravitationalLoadQuantity.UnitChoicesEnum.Kilogram));
            this.UnitChoices.Add(GravitationalLoadQuantity.Instance.GetUnitChoice(GravitationalLoadQuantity.UnitChoicesEnum.TonneMetric));
            this.UnitChoices.Add(GravitationalLoadQuantity.Instance.GetUnitChoice(GravitationalLoadQuantity.UnitChoicesEnum.Pound));
            this.UnitChoices.Add(GravitationalLoadQuantity.Instance.GetUnitChoice(GravitationalLoadQuantity.UnitChoicesEnum.KiloPound));
            this.UnitChoices.Add(GravitationalLoadQuantity.Instance.GetUnitChoice(GravitationalLoadQuantity.UnitChoicesEnum.TonUK));
            PostProcess();
        }
    }
}
