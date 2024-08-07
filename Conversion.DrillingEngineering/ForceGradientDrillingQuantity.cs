﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class ForceGradientDrillingQuantity : ForceGradientQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1;
        private static ForceGradientDrillingQuantity instance_ = null;

        public static new ForceGradientDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new ForceGradientDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public ForceGradientDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Force Gradient (drilling)" };
            ID = new Guid("78942f39-d764-42f1-b270-47a3b35e5112");
            Reset();
            this.UnitChoices.Add(ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.NewtonPerMetre));
            this.UnitChoices.Add(ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.NewtonPer30Metre));
            this.UnitChoices.Add(ForceGradientQuantity.Instance.GetUnitChoice(ForceGradientQuantity.UnitChoicesEnum.DecanewtonPerMetre));
        }
    }
}
