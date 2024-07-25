using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class StandardLengthQuantity : LengthQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.001;

        private static StandardLengthQuantity instance_ = null;

        public static new StandardLengthQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new StandardLengthQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public StandardLengthQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Standard Length" };
            ID = new Guid("3716ad37-2b0c-4c0b-8936-6c9cdb47ad1d");
            Reset();
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Centimetre));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Decimetre));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Foot));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Inch));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Metre));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Micrometre));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Millimetre));
        }
    }
}
