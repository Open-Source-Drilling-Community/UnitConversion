using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class ResistivityQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "OhmMeter";
        public override string SIUnitLabel { get; } = "Ohm•m";
        public override double LengthDimension { get; } = 3;
        public override double MassDimension { get; } = 1;
        public override double TimeDimension { get; } = -3;
        public override double ElectricCurrentDimension { get; } = -2;
        private static ResistivityQuantity instance_ = null;

        public static ResistivityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new ResistivityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public ResistivityQuantity() : base()
        {
            Name = "Resistivity";
            ID = new Guid("c6c87a27-c04d-4658-8a71-1e46eb3bfd80");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("fb07d86d-d69f-46ca-892c-17ec45adffcb"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        }
      };
        }
    }
}
