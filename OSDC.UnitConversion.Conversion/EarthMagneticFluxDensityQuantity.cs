﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class EarthMagneticFluxDencityQuantity : MagneticFluxDensityQuantity, IEngineeringQuantity
    {
        public virtual double? MeaningFullPrecisionInSI { get; } = 0.00001;

        private static EarthMagneticFluxDencityQuantity instance_ = null;

        public static new EarthMagneticFluxDencityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new EarthMagneticFluxDencityQuantity();
                }
                return instance_;
            }
        }

        protected EarthMagneticFluxDencityQuantity() : base()
        {
            Name = "EarthMagneticFluxDensity";
            ID = new Guid("ed95aca5-aaf9-4822-b045-342ffcd06ca7");
            Reset();
            this.UnitChoices.Add(MagneticFluxDensityQuantity.Instance.GetUnitChoice(MagneticFluxDensityQuantity.UnitChoicesEnum.Tesla));
            this.UnitChoices.Add(MagneticFluxDensityQuantity.Instance.GetUnitChoice(MagneticFluxDensityQuantity.UnitChoicesEnum.Gauss));
            this.UnitChoices.Add(MagneticFluxDensityQuantity.Instance.GetUnitChoice(MagneticFluxDensityQuantity.UnitChoicesEnum.MilliGauss));
            this.UnitChoices.Add(MagneticFluxDensityQuantity.Instance.GetUnitChoice(MagneticFluxDensityQuantity.UnitChoicesEnum.MicroTesla));
            this.UnitChoices.Add(MagneticFluxDensityQuantity.Instance.GetUnitChoice(MagneticFluxDensityQuantity.UnitChoicesEnum.NanoTesla));
            PostProcess();
        }

    }
}
