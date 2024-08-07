﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class AxialVelocityDrillingQuantity : VelocityQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.01;
        private static AxialVelocityDrillingQuantity instance_ = null;

        public static new AxialVelocityDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new AxialVelocityDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public AxialVelocityDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Axial Velocity (drilling)" };
            ID = new Guid("e278ace8-d577-4fb4-8d1d-dd8a3d072027");
            Reset();
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MetrePerSecond));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MetrePerMinute));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.MetrePerHour));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerHour));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerMinute));
            this.UnitChoices.Add(VelocityQuantity.Instance.GetUnitChoice(VelocityQuantity.UnitChoicesEnum.FootPerSecond));
        }
    }
}
