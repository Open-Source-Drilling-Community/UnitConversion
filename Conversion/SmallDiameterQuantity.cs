using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class SmallDiameterQuantity : LengthQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.0001;

        private static SmallDiameterQuantity instance_ = null;

        public static new SmallDiameterQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new SmallDiameterQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public SmallDiameterQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Small Diameter" };
            ID = new Guid("d07d00aa-35aa-41c6-a52d-ad51c3f4e97f");
            Reset();
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Centimetre));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Decimetre));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Foot));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Inch));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Metre));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Micrometre));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Millimetre));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Nanometre));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Picometre));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Ångstrøm));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.InchPer32));
        }

    }
}
