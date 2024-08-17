using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class YoungModulusQuantity : PressureQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 10000;
        private static YoungModulusQuantity instance_ = null;

        public static new YoungModulusQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new YoungModulusQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public YoungModulusQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Young Modulus" };
            ID = new Guid("7ffbcc35-b46f-4656-baf5-c92be501f0ec");
            Reset();
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.Pascal));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.Megapascal));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.Gigapascal));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.PoundPerSquareInch));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.MegapoundPerSquareInch));
        }
    }
}
