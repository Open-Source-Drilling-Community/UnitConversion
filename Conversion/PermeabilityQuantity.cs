using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    /// <summary>
    /// Reference for conversions from darcy to area units: https://www.spe.org/authors/docs/metric_standard.pdf
    /// </summary>
    public partial class PermeabilityQuantity : AreaQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.0000000001;
        private static PermeabilityQuantity instance_ = null;

        public static new PermeabilityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new PermeabilityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public PermeabilityQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Permeability" };
            ID = new Guid("413da2c1-ebad-454a-ae14-1a8620f8f59c");
            Reset();
            this.UnitChoices.Add(AreaQuantity.Instance.GetUnitChoice(AreaQuantity.UnitChoicesEnum.SquareMetre));
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "darcy",
                UnitLabel = "D",
                ID = new Guid("9a89bcc3-dc77-4e3a-a492-fcdabc24ec41"),
                ConversionFactorFromSI = 1013249965828.14
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "millidarcy",
                UnitLabel = "mD",
                ID = new Guid("8d7a6767-6c6b-4daf-8617-d35e4055d457"),
                ConversionFactorFromSI = 1013249965828140.0
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "microdarcy",
                UnitLabel = "µD",
                ID = new Guid("b552f28d-c68a-4c59-853c-fe6e03dd5f4c"),
                ConversionFactorFromSI = 1013249965828140000.0
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "nanodarcy",
                UnitLabel = "nD",
                ID = new Guid("f35b05c7-8b2f-4194-9336-d42cec5f3ba5"),
                ConversionFactorFromSI = 1013249965828140000000.0
            });
        }
    }
}
