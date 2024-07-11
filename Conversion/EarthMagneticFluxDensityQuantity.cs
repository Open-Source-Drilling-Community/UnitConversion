using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class EarthMagneticFluxDensityQuantity : MagneticFluxDensityQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1e-9;

        private static EarthMagneticFluxDensityQuantity instance_ = null;

        public static new EarthMagneticFluxDensityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new EarthMagneticFluxDensityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public EarthMagneticFluxDensityQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Earth Magnetic Flux Density" };
            ID = new Guid("ed95aca5-aaf9-4822-b045-342ffcd06ca7");
            Reset();
            this.UnitChoices.Add(MagneticFluxDensityQuantity.Instance.GetUnitChoice(MagneticFluxDensityQuantity.UnitChoicesEnum.Tesla));
            this.UnitChoices.Add(MagneticFluxDensityQuantity.Instance.GetUnitChoice(MagneticFluxDensityQuantity.UnitChoicesEnum.Gauss));
            this.UnitChoices.Add(MagneticFluxDensityQuantity.Instance.GetUnitChoice(MagneticFluxDensityQuantity.UnitChoicesEnum.MilliGauss));
            this.UnitChoices.Add(MagneticFluxDensityQuantity.Instance.GetUnitChoice(MagneticFluxDensityQuantity.UnitChoicesEnum.MicroTesla));
            this.UnitChoices.Add(MagneticFluxDensityQuantity.Instance.GetUnitChoice(MagneticFluxDensityQuantity.UnitChoicesEnum.NanoTesla));
        }
    }
}
