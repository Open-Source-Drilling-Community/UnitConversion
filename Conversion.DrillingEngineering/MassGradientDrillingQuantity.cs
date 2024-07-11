using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class MassGradientDrillingQuantity : MassGradientQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.05;
        private static MassGradientDrillingQuantity instance_ = null;

        public static new MassGradientDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new MassGradientDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public MassGradientDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Mass Gradient (drilling)" };
            ID = new Guid("dc474098-a2b5-44fb-b56a-0ae20ff62ad6");
            Reset();
            this.UnitChoices.Add(MassGradientQuantity.Instance.GetUnitChoice(MassGradientQuantity.UnitChoicesEnum.KilogramPerMetre));
            this.UnitChoices.Add(MassGradientQuantity.Instance.GetUnitChoice(MassGradientQuantity.UnitChoicesEnum.PoundPerFoot));
        }

    }
}
