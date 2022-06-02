using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingInterfacialTensionQuantity : InterfacialTensionQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 0.0001;

        private static DrillingInterfacialTensionQuantity instance_ = null;

        public static new DrillingInterfacialTensionQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new DrillingInterfacialTensionQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public DrillingInterfacialTensionQuantity() : base()
        {
            Name = "DrillingInterfacialTension";
            ID = new Guid("1bf5cf90-84c4-4dcc-ac74-92223d3c3c46");
            Reset();
            this.UnitChoices.Add(InterfacialTensionQuantity.Instance.GetUnitChoice(InterfacialTensionQuantity.UnitChoicesEnum.NewtonPerMeter));
            this.UnitChoices.Add(InterfacialTensionQuantity.Instance.GetUnitChoice(InterfacialTensionQuantity.UnitChoicesEnum.MilliNewtonPerMeter));
            this.UnitChoices.Add(InterfacialTensionQuantity.Instance.GetUnitChoice(InterfacialTensionQuantity.UnitChoicesEnum.DynesPerCentimeter));
            this.UnitChoices.Add(InterfacialTensionQuantity.Instance.GetUnitChoice(InterfacialTensionQuantity.UnitChoicesEnum.PoundPerSecondSquared));
        }

    }
}
