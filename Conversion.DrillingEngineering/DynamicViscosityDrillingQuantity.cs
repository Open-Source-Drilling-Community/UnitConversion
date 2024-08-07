using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DynamicViscosityDrillingQuantity : DynamicViscosityQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.0001;

        private static DynamicViscosityDrillingQuantity instance_ = null;

        public static new DynamicViscosityDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DynamicViscosityDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DynamicViscosityDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Dynamic Viscosity (drilling)" };
            ID = new Guid("e9b32538-f7f4-4f99-a206-0601a4e4a5f8");
            Reset();
            this.UnitChoices.Add(DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.PascalSecond));
            this.UnitChoices.Add(DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.Centipoise));
            this.UnitChoices.Add(DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.Micropoise));
            this.UnitChoices.Add(DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.MicropascalSecond));
        }


    }
}
