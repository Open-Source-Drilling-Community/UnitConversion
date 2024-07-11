﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class TensionDrillingQuantity : TensionQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 100;
        private static TensionDrillingQuantity instance_ = null;

        public static new TensionDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new TensionDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public TensionDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Tension (drilling)" };
            ID = new Guid("fe8fd6fd-814c-44c9-9462-f034dd46dc85");
            Reset();
            this.UnitChoices.Add(TensionQuantity.Instance.GetUnitChoice(TensionQuantity.UnitChoicesEnum.Newton));
            this.UnitChoices.Add(TensionQuantity.Instance.GetUnitChoice(TensionQuantity.UnitChoicesEnum.DecaNewton));
            this.UnitChoices.Add(TensionQuantity.Instance.GetUnitChoice(TensionQuantity.UnitChoicesEnum.KiloDecaNewton));
            this.UnitChoices.Add(TensionQuantity.Instance.GetUnitChoice(TensionQuantity.UnitChoicesEnum.KilogramForce));
            this.UnitChoices.Add(TensionQuantity.Instance.GetUnitChoice(TensionQuantity.UnitChoicesEnum.KiloNewton));
            this.UnitChoices.Add(TensionQuantity.Instance.GetUnitChoice(TensionQuantity.UnitChoicesEnum.KiloPoundForce));
            this.UnitChoices.Add(TensionQuantity.Instance.GetUnitChoice(TensionQuantity.UnitChoicesEnum.PoundForce));
        }

    }
}
