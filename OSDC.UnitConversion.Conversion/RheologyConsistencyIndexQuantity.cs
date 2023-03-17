using System;
using System.Collections.Generic;
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
            Name = "RheologyConsistencyIndex";
            ID = new Guid("05571702-00e6-47d7-8590-fd3983645406");
            Reset();
            this.UnitChoices.Add(DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.PascalSecond));
            this.UnitChoices.Add(DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.MicroPascalSecond));
            this.UnitChoices.Add(DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.CentiPoise));
            this.UnitChoices.Add(DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.MicroPoise));
            this.UnitChoices.Add(DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.PoundPer100SquareFootSecond));
            this.UnitChoices.Add(DynamicViscosityQuantity.Instance.GetUnitChoice(DynamicViscosityQuantity.UnitChoicesEnum.DynesPerSquareCentimeterSecond));
        }
    }
}
