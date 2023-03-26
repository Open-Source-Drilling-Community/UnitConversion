using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class TorqueQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "MeterNewton";
        public override string SIUnitLabel { get; } = "m.N";
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
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public TorqueQuantity() : base()
        {
            Name = "Torque";
            ID = new Guid("3eb9e01e-48fa-430e-82c6-3aee4d359ac4");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("50b017fa-8d81-4076-a485-61de1d8301b5"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "MeterDecaNewton",
          UnitLabel = "m.daN",
          ID = new Guid("501ce02c-8a5d-46e6-9ab6-ce443df70402"),
          ConversionFactorFromSI = 0.1
        },
        new UnitChoice
        {
          UnitName = "MeterKilogramForce",
          UnitLabel = "m.kgf",
          ID = new Guid("282f97a0-df2a-4016-9ab0-796db49ff384"),
          ConversionFactorFromSI = 0.10197162129779283
        },
        new UnitChoice
        {
          UnitName = "MeterKiloNewton",
          UnitLabel = "m.kN",
          ID = new Guid("2e417a6e-1acc-4901-8704-7dfeb3f67546"),
          ConversionFactorFromSI = 0.001
        },
        new UnitChoice
        {
          UnitName = "FootPound",
          UnitLabel = "ft.lbf",
          ID = new Guid("700d9fc7-17e1-4ad6-84f1-39cacbe5fe51"),
          ConversionFactorFromSI = 0.7375621211696556
        },
        new UnitChoice
        {
          UnitName = "KiloFootPound",
          UnitLabel = "kft.lbf",
          ID = new Guid("ee9be6ed-df75-4915-be6a-e3941dacd6bd"),
          ConversionFactorFromSI = 0.0007375621211696556
        },
        new UnitChoice
        {
          UnitName = "DecimeterNewton",
          UnitLabel = "dm.N",
          ID = new Guid("e70db590-c5fb-4ab9-a2c4-3ad611cb7f63"),
          ConversionFactorFromSI = 10.0
        },
        new UnitChoice
        {
          UnitName = "CentimeterNewton",
          UnitLabel = "cm.N",
          ID = new Guid("4acf4542-8df0-4f57-a852-7c0184dbeec9"),
          ConversionFactorFromSI = 100.0
        },
        new UnitChoice
        {
          UnitName = "MillimeterNewton",
          UnitLabel = "mm.N",
          ID = new Guid("a933225d-7c8e-4ce4-b0ea-4c1c6e9f7e34"),
          ConversionFactorFromSI = 1000.0
        },
        new UnitChoice
        {
          UnitName = "InchPound",
          UnitLabel = "in.lbf",
          ID = new Guid("0d40553e-d8c4-4b75-ad05-61199b15a0a1"),
          ConversionFactorFromSI = 8.850745793490558
        }

      };
        }
    }
}
