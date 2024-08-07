using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class InterfacialTensionDrillingQuantity : InterfacialTensionQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.0001;

        private static InterfacialTensionDrillingQuantity instance_ = null;

        public static new InterfacialTensionDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new InterfacialTensionDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public InterfacialTensionDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Interfacial Tension (drilling)" };
            ID = new Guid("1bf5cf90-84c4-4dcc-ac74-92223d3c3c46");
            Reset();
            this.UnitChoices.Add(InterfacialTensionQuantity.Instance.GetUnitChoice(InterfacialTensionQuantity.UnitChoicesEnum.NewtonPerMetre));
            this.UnitChoices.Add(InterfacialTensionQuantity.Instance.GetUnitChoice(InterfacialTensionQuantity.UnitChoicesEnum.MillinewtonPerMetre));
            this.UnitChoices.Add(InterfacialTensionQuantity.Instance.GetUnitChoice(InterfacialTensionQuantity.UnitChoicesEnum.DynePerCentimetre));
            this.UnitChoices.Add(InterfacialTensionQuantity.Instance.GetUnitChoice(InterfacialTensionQuantity.UnitChoicesEnum.PoundPerSecondSquared));
        }

    }
}
