using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class RandomWalkDrillingQuantity : RandomWalkQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.00001;

        private static RandomWalkDrillingQuantity instance_ = null;

        public static new RandomWalkDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new RandomWalkDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public RandomWalkDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Random Walk (drilling)" };
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
