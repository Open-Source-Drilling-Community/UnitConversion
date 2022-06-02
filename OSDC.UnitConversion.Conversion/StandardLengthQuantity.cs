using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class StandardLengthQuantity : LengthQuantity
    {
        public override double? MeaningFullPrecisionInSI { get; } = 0.001;

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
            Name = "Standard Length";
            ID = new Guid("3716ad37-2b0c-4c0b-8936-6c9cdb47ad1d");
            Reset();
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Centimeter));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Decimeter));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Feet));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Inch));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Metre));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Micrometer));
            this.UnitChoices.Add(LengthQuantity.Instance.GetUnitChoice(LengthQuantity.UnitChoicesEnum.Millimeter));
        }
    }
}
