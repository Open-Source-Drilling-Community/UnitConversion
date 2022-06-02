using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingCurvatureQuantity : CurvatureQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 5.817764173314432E-06;

        private static DrillingCurvatureQuantity instance_ = null;

        public static new DrillingCurvatureQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingCurvatureQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingCurvatureQuantity() : base()
        {
            Name = "DrillingCurvature";
            ID = new Guid("0e41ce3a-a0e4-44a3-bf6e-6c2a70f4a28b");
            Reset();
            this.UnitChoices.Add(CurvatureQuantity.Instance.GetUnitChoice(CurvatureQuantity.UnitChoicesEnum.RadianPerMeter));
            this.UnitChoices.Add(CurvatureQuantity.Instance.GetUnitChoice(CurvatureQuantity.UnitChoicesEnum.DegreePer10m));
            this.UnitChoices.Add(CurvatureQuantity.Instance.GetUnitChoice(CurvatureQuantity.UnitChoicesEnum.DegreePer30m));
            this.UnitChoices.Add(CurvatureQuantity.Instance.GetUnitChoice(CurvatureQuantity.UnitChoicesEnum.DegreePer30ft));
            this.UnitChoices.Add(CurvatureQuantity.Instance.GetUnitChoice(CurvatureQuantity.UnitChoicesEnum.DegreePer100ft));
        }

    }
}
