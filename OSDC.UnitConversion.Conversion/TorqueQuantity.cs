using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class TorqueQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "MeterNewton";
        public override string SIUnitSymbol { get; } = "m.N";
        public override double LengthDimension { get; } = 2;
        public override double MassDimension { get; } = 1;
        public override double TimeDimension { get; } = -2;
        private static TorqueQuantity instance_ = null;

        public static TorqueQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new TorqueQuantity();
                }
                return instance_;
            }
        }
        protected TorqueQuantity() : base()
        {
            Name = "Torque";
            ID = new Guid("3eb9e01e-48fa-430e-82c6-3aee4d359ac4");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitSymbol = SIUnitSymbol,
          ID = new Guid("50b017fa-8d81-4076-a485-61de1d8301b5"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "MeterDecaNewton",
          UnitSymbol = "m.daN",
          ID = new Guid("501ce02c-8a5d-46e6-9ab6-ce443df70402"),
          ConversionFactorFromSI = 0.1
        },
        new UnitChoice
        {
          UnitName = "MeterKilogramForce",
          UnitSymbol = "m.kgf",
          ID = new Guid("282f97a0-df2a-4016-9ab0-796db49ff384"),
          ConversionFactorFromSI = 0.10197162129779283
        },
        new UnitChoice
        {
          UnitName = "MeterKiloNewton",
          UnitSymbol = "m.kN",
          ID = new Guid("2e417a6e-1acc-4901-8704-7dfeb3f67546"),
          ConversionFactorFromSI = 0.001
        },
        new UnitChoice
        {
          UnitName = "FootPound",
          UnitSymbol = "ft.lbf",
          ID = new Guid("700d9fc7-17e1-4ad6-84f1-39cacbe5fe51"),
          ConversionFactorFromSI = 0.7375621211696556
        },
        new UnitChoice
        {
          UnitName = "KiloFootPound",
          UnitSymbol = "kft.lbf",
          ID = new Guid("ee9be6ed-df75-4915-be6a-e3941dacd6bd"),
          ConversionFactorFromSI = 0.0007375621211696556
        }
      };
            PostProcess();
        }
    }
}
