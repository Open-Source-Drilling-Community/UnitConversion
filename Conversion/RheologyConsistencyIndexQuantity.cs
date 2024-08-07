using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class RheologyConsistencyIndexQuantity : DynamicViscosityQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override double? MeaningfulPrecisionInSI { get; } = 1E-04;
        private static RheologyConsistencyIndexQuantity instance_ = null;

        public static new RheologyConsistencyIndexQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new RheologyConsistencyIndexQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public RheologyConsistencyIndexQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Rheology Consistency Index" };
            ID = new Guid("05571702-00e6-47d7-8590-fd3983645406");
            Reset();
            this.UnitChoices.Add(DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.PascalSecond));
            this.UnitChoices.Add(DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.MicropascalSecond));
            this.UnitChoices.Add(DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.Centipoise));
            this.UnitChoices.Add(DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.Micropoise));
            this.UnitChoices.Add(DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.PoundSecondPer100SquareFoot));
            this.UnitChoices.Add(DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.DyneSecondPerSquareCentimetre));
        }
    }
}
