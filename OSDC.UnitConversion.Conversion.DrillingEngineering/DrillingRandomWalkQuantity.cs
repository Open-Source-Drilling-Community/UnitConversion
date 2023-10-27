using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingRandomWalkQuantity : RandomWalkQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.00001;

        private static DrillingRandomWalkQuantity instance_ = null;

        public static new DrillingRandomWalkQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingRandomWalkQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingRandomWalkQuantity() : base()
        {
            Name = "DrillingRandomWalk";
            ID = new Guid("8817dc80-eb46-42d5-b85f-703fa8845f32");
            Reset();
            this.UnitChoices.Add(RandomWalkQuantity.Instance.GetUnitChoice(RandomWalkQuantity.UnitChoicesEnum.RadianPerSqrtSecond));
            this.UnitChoices.Add(RandomWalkQuantity.Instance.GetUnitChoice(RandomWalkQuantity.UnitChoicesEnum.RadianPerSqrtMinute));
            this.UnitChoices.Add(RandomWalkQuantity.Instance.GetUnitChoice(RandomWalkQuantity.UnitChoicesEnum.RadianPerSqrtHour));
            this.UnitChoices.Add(RandomWalkQuantity.Instance.GetUnitChoice(RandomWalkQuantity.UnitChoicesEnum.RadianPerSqrtDay));
            this.UnitChoices.Add(RandomWalkQuantity.Instance.GetUnitChoice(RandomWalkQuantity.UnitChoicesEnum.DegreePerSqrtSecond));
            this.UnitChoices.Add(RandomWalkQuantity.Instance.GetUnitChoice(RandomWalkQuantity.UnitChoicesEnum.DegreePerSqrtMinute));
            this.UnitChoices.Add(RandomWalkQuantity.Instance.GetUnitChoice(RandomWalkQuantity.UnitChoicesEnum.DegreePerSqrtHour));
            this.UnitChoices.Add(RandomWalkQuantity.Instance.GetUnitChoice(RandomWalkQuantity.UnitChoicesEnum.DegreePerSqrtDay));
        }
    }
}
