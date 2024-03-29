﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class SmallTorqueQuantity :TorqueQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.00001;

        private static SmallTorqueQuantity instance_ = null;

        public static new SmallTorqueQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new SmallTorqueQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public SmallTorqueQuantity() : base()
        {
            Name = "Small Torque";
            ID = new Guid("adf7b170-8d24-4c9f-93e1-40179f361d8c");
            Reset();
            this.UnitChoices.Add(TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.MeterNewton));
            this.UnitChoices.Add(TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.FootPound));
            this.UnitChoices.Add(TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.DecimeterNewton));
            this.UnitChoices.Add(TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.CentimeterNewton));
            this.UnitChoices.Add(TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.MillimeterNewton));
            this.UnitChoices.Add(TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.InchPound));
        }

    }
}
