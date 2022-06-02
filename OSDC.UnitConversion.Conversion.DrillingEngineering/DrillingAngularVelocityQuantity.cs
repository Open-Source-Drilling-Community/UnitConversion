using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingAngularVelocityQuantity : AngularVelocityQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 0.01;

        private static DrillingAngularVelocityQuantity instance_ = null;

        public static new DrillingAngularVelocityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingAngularVelocityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingAngularVelocityQuantity() : base()
        {
            Name = "DrillingAngularVelocity";
            ID = new Guid("046cb449-8cab-4d0c-bb28-3e2060f292e5");
            Reset();
            this.UnitChoices.Add(AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.RadianPerSecond));
            this.UnitChoices.Add(AngularVelocityQuantity.Instance.GetUnitChoice(AngularVelocityQuantity.UnitChoicesEnum.DegreePerSecond));
        }

    }
}
