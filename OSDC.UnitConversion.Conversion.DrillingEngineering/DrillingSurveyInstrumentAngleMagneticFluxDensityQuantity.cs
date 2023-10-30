using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{

    public partial class DrillingSurveyInstrumentAngleMagneticFluxDensityQuantity : AngleMagneticFluxDensityQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1e-9;

        private static DrillingSurveyInstrumentAngleMagneticFluxDensityQuantity instance_ = null;

        public static new DrillingSurveyInstrumentAngleMagneticFluxDensityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingSurveyInstrumentAngleMagneticFluxDensityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingSurveyInstrumentAngleMagneticFluxDensityQuantity() : base()
        {
            Name = "DrillingSurveyInstrumentMagneticFluxDensity";
            ID = new Guid("a3ad9fd6-a516-42c8-98a5-14e178dc62f2");
            Reset();
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.RadianTesla));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.DegreeGauss));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.DegreeMaxwellPerSquareCentimeter));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.DegreeMicroTesla));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.DegreeMilliGauss));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.DegreeMilliTesla));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.DegreeNanoTesla));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.DegreeTesla));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.DegreeWeberPerSquareMeter));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.RadianGauss));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.RadianMaxwellPerSquareCentimeter));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.RadianMicroTesla));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.RadianMilliGauss));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.RadianMilliTesla));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.RadianNanoTesla));
            this.UnitChoices.Add(AngleMagneticFluxDensityQuantity.Instance.GetUnitChoice(AngleMagneticFluxDensityQuantity.UnitChoicesEnum.RadianWeberPerSquareMeter));
        }
    }
}
