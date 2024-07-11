﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingDrillStringMagneticFluxQuantity : MagneticFluxQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1e-7;

        private static DrillingDrillStringMagneticFluxQuantity instance_ = null;

        public static new DrillingDrillStringMagneticFluxQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingDrillStringMagneticFluxQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingDrillStringMagneticFluxQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Drill String Magnetic Flux (drilling)" };
            ID = new Guid("3a58147b-88db-4474-8390-dd0e0f7d206b");
            Reset();
            this.UnitChoices.Add(MagneticFluxQuantity.Instance.GetUnitChoice(MagneticFluxQuantity.UnitChoicesEnum.Weber));
            this.UnitChoices.Add(MagneticFluxQuantity.Instance.GetUnitChoice(MagneticFluxQuantity.UnitChoicesEnum.Milliweber));
            this.UnitChoices.Add(MagneticFluxQuantity.Instance.GetUnitChoice(MagneticFluxQuantity.UnitChoicesEnum.MicroWeber));
            this.UnitChoices.Add(MagneticFluxQuantity.Instance.GetUnitChoice(MagneticFluxQuantity.UnitChoicesEnum.TeslaSquareMetre));
            this.UnitChoices.Add(MagneticFluxQuantity.Instance.GetUnitChoice(MagneticFluxQuantity.UnitChoicesEnum.TeslaSquareCentimetre));
            this.UnitChoices.Add(MagneticFluxQuantity.Instance.GetUnitChoice(MagneticFluxQuantity.UnitChoicesEnum.GaussSquareCentimetre));
        }
    }
}