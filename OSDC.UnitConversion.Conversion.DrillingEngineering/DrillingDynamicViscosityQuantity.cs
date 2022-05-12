using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingDynamicViscosityQuantity : DynamicViscosityQuantity, IEngineeringQuantity
    {
        public virtual double? MeaningFullPrecisionInSI { get; } = 0.0001;

        private static DrillingDynamicViscosityQuantity instance_ = null;

        public static new DrillingDynamicViscosityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingDynamicViscosityQuantity();
                }
                return instance_;
            }
        }

        protected DrillingDynamicViscosityQuantity() : base()
        {
            Name = "DrillingDynamicViscosity";
            ID = new Guid("e9b32538-f7f4-4f99-a206-0601a4e4a5f8");
            Reset();
            this.UnitChoices.Add(DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.PascalSecond));
            this.UnitChoices.Add(DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.CentiPoise));
            this.UnitChoices.Add(DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.MicroPoise));
            this.UnitChoices.Add(DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.MicroPascalSecond));
            PostProcess();
        }


    }
}
