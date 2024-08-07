using System;
using System.Collections.Generic;
using System.Linq;
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
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Small Torque" };
            ID = new Guid("adf7b170-8d24-4c9f-93e1-40179f361d8c");
            Reset();
            this.UnitChoices.Add(TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.NewtonMetre));
            this.UnitChoices.Add(TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.FootPound));
            this.UnitChoices.Add(TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.NewtonDecimetre));
            this.UnitChoices.Add(TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.NewtonCentimetre));
            this.UnitChoices.Add(TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.NewtonMillimetre));
            this.UnitChoices.Add(TorqueQuantity.Instance.GetUnitChoice(TorqueQuantity.UnitChoicesEnum.InchPound));
        }

    }
}
