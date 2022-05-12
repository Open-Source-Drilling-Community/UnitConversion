using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class PermeabilityQuantity : AreaQuantity, IEngineeringQuantity
    {
        public virtual double? MeaningFullPrecisionInSI { get; } = 0.0000000001;
        private static PermeabilityQuantity instance_ = null;

        public static new PermeabilityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new PermeabilityQuantity();
                }
                return instance_;
            }
        }
        protected PermeabilityQuantity() : base()
        {
            Name = "Permeability";
            ID = new Guid("413da2c1-ebad-454a-ae14-1a8620f8f59c");
            Reset();
            this.UnitChoices.Add(AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareMeter));
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "Darcy",
                UnitSymbol = "D",
                ID = new Guid("9a89bcc3-dc77-4e3a-a492-fcdabc24ec41"),
                ConversionFactorFromSI = 1000000.0
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "MilliDarcy",
                UnitSymbol = "mD",
                ID = new Guid("8d7a6767-6c6b-4daf-8617-d35e4055d457"),
                ConversionFactorFromSI = 1000000000.0
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "MicroDarcy",
                UnitSymbol = "µD",
                ID = new Guid("b552f28d-c68a-4c59-853c-fe6e03dd5f4c"),
                ConversionFactorFromSI = 1000000000.0
            });
            PostProcess();
        }
    }
}
