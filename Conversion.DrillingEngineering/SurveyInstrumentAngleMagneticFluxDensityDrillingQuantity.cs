using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{

    public partial class SurveyInstrumentAngleMagneticFluxDensityDrillingQuantity : AngleMagneticFluxDensityQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1e-9;

        private static SurveyInstrumentAngleMagneticFluxDensityDrillingQuantity instance_ = null;

        public static new SurveyInstrumentAngleMagneticFluxDensityDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new SurveyInstrumentAngleMagneticFluxDensityDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public SurveyInstrumentAngleMagneticFluxDensityDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Survey Instrument Angle Magnetic Flux Density (drilling)" };
            ID = new Guid("a3ad9fd6-a516-42c8-98a5-14e178dc62f2");
            Reset();
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.RadianTesla));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.DegreeGauss));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.DegreeMaxwellPerSquareCentimetre));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.DegreeMicrotesla));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.DegreeMilligauss));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.DegreeMillitesla));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.DegreeNanotesla));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.DegreeTesla));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.DegreeWeberPerSquareMetre));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.RadianGauss));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.RadianMaxwellPerSquareCentimetre));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.RadianMicrotesla));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.RadianMilligauss));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.RadianMillitesla));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.RadianNanotesla));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.RadianWeberPerSquareMetre));
        }
    }
}
