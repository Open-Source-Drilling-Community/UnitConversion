using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class ForceQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "Newton";
        public override string SIUnitLabel { get; } = "N";
        public override double LengthDimension { get; } = 1;
        public override double MassDimension { get; } = 1;
        public override double TimeDimension { get; } = -2;
        private static ForceQuantity instance_ = null;

        public static ForceQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new ForceQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public ForceQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Force" };
            ID = new Guid("af9fd237-14d8-4b75-8d0b-34ea8961c20b");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("2e6b218c-0f85-4e8d-b9c5-73b78d207ef8"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "DecaNewton",
          UnitLabel = "daN",
          ID = new Guid("fc48e3a8-deb9-4cf6-aaad-5b18f7e37972"),
          ConversionFactorFromSI = 0.1
        },
        new UnitChoice
        {
          UnitName = "KiloNewton",
          UnitLabel = "kN",
          ID = new Guid("e30d6f94-7887-4746-8d4f-eb720239b702"),
          ConversionFactorFromSI = 0.001
        },
        new UnitChoice
        {
          UnitName = "KiloDecaNewton",
          UnitLabel = "kdaN",
          ID = new Guid("8ad7ae81-602b-4694-bc6d-c18f520f1266"),
          ConversionFactorFromSI = 0.0001
        },
        new UnitChoice
        {
          UnitName = "KilogramForce",
          UnitLabel = "kgf",
          ID = new Guid("ea771c51-4078-4aa6-b2df-db6f77a140ad"),
          ConversionFactorFromSI = 0.10197162129779283
        },
        new UnitChoice
        {
          UnitName = "PoundForce",
          UnitLabel = "lbf",
          ID = new Guid("c738ced5-1c99-42ec-9c47-59e7d6455ffa"),
          ConversionFactorFromSI = 0.2248089438709618
        },
        new UnitChoice
        {
          UnitName = "KiloPoundForce",
          UnitLabel = "klbf",
          ID = new Guid("fa385f22-3ed9-4f34-ab0c-193e3ac79375"),
          ConversionFactorFromSI = 0.00022480894387096184
        }
      };
        }
    }
}
