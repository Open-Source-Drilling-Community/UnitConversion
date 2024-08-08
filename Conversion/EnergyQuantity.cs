using Conversion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class EnergyQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = "E";
        public override string SIUnitName { get; } = "joule";
        public override string SIUnitLabel { get; } = "J";
        public override double LengthDimension { get; } = 2;
        public override double MassDimension { get; } = 1;
        public override double TimeDimension { get; } = -2;
        private static EnergyQuantity instance_ = null;

        public static EnergyQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new EnergyQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public EnergyQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Energy" };
            ID = new Guid("3be49c73-d2d1-40a2-b15f-07a1606d8179");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("c653b7de-0386-467c-8d25-60bb0f6a7076"),
          ConversionFactorFromSI = 1.0/Factors.Unit,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "kilojoule",
          UnitLabel = "kJ",
          ID = new Guid("4b0cf63a-84af-4232-b7a1-7531ec1d47b0"),
          ConversionFactorFromSI = 1.0/Factors.Kilo
        },
        new UnitChoice
        {
          UnitName = "megajoule",
          UnitLabel = "MJ",
          ID = new Guid("c4fdba05-7269-4098-8b33-bd8e50c67126"),
          ConversionFactorFromSI = 1.0/Factors.Mega
        },
        new UnitChoice
        {
          UnitName = "gigajoule",
          UnitLabel = "GJ",
          ID = new Guid("c8781145-3c6c-4d87-9567-b0e6ec2821a2"),
          ConversionFactorFromSI = 1.0/Factors.Giga
        },
        new UnitChoice
        {
          UnitName = "calorie",
          UnitLabel = "cal",
          ID = new Guid("3f020e89-3146-4f3f-9b9b-eecda4400b12"),
          ConversionFactorFromSI = 1.0/Factors.Calorie
        },
        new UnitChoice
        {
          UnitName = "kilocalorie",
          UnitLabel = "Cal",
          ID = new Guid("e4e916fe-9e79-47c9-97e5-3e8458358578"),
          ConversionFactorFromSI = 1.0/(Factors.Kilo * Factors.Calorie)
        },
        new UnitChoice
        {
          UnitName = "british thermal unit",
          UnitLabel = "BTU",
          ID = new Guid("8548500e-e3a9-4e36-aecb-024836b8a012"),
          ConversionFactorFromSI = 1.0/Factors.BTU
        },
        new UnitChoice
        {
          UnitName = "kilo british thermal unit",
          UnitLabel = "kBTU",
          ID = new Guid("b8e1ba3f-d374-4220-85a6-7a066d91dd26"),
          ConversionFactorFromSI = 1.0/(Factors.Kilo * Factors.BTU)
        },
                new UnitChoice
        {
          UnitName = "mega british thermal unit",
          UnitLabel = "MMBTU",
          ID = new Guid("329c7fef-b5da-489f-a973-9ec2efb82a19"),
          ConversionFactorFromSI = 1.0/(Factors.Mega * Factors.BTU)
        }

      };
        }
    }
}
