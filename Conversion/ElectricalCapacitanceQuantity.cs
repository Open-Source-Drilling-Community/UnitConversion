using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class ElectricalCapacitanceQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = "C";
        public override string SIUnitName { get; } = "farad";
        public override string SIUnitLabel { get; } = "F";
        public override double LengthDimension { get; } = -2;
        public override double MassDimension { get; } = -1;
        public override double TimeDimension { get; } = 4;
        public override double ElectricCurrentDimension { get; } = 2;

        private static ElectricalCapacitanceQuantity instance_ = null;

        public static ElectricalCapacitanceQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new ElectricalCapacitanceQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public static List<UnitChoice> UnitChoiceDescriptions = new List<UnitChoice>()
        {
            new UnitChoice
        {
          UnitName = "farad",
          UnitLabel = "F",
          ID = new Guid("11dd208b-bcf2-4415-b7a9-4161791166c7"),
          ConversionFactorFromSIFormula = "1.0/Factors.Unit",
          IsSI = true
        },
         new UnitChoice
        {
          UnitName = "coulomb per volt",
          UnitLabel = "C/V",
          ID = new Guid("81ae5717-d834-4f25-800e-c42c3bcb48af"),
          ConversionFactorFromSIFormula = "1.0/Factors.Unit"
        },
        new UnitChoice
        {
          UnitName = "millifarad",
          UnitLabel = "mF",
          ID = new Guid("12c8b1ad-d38a-4dbe-b418-7f3b31c23ff6"),
          ConversionFactorFromSIFormula = "1.0/Factors.Milli"
        },
        new UnitChoice
        {
          UnitName = "microfarad",
          UnitLabel = "μF",
          ID = new Guid("a5974c82-68ac-4166-81b0-123f3ae84701"),
          ConversionFactorFromSIFormula = "1.0/Factors.Micro"
        },
        new UnitChoice
        {
          UnitName = "nanofarad",
          UnitLabel = "nF",
          ID = new Guid("c1af9df8-69d5-41d3-9027-3c89aa151777"),
          ConversionFactorFromSIFormula = "1.0/Factors.Nano"
        },
        new UnitChoice
        {
          UnitName = "picofarad",
          UnitLabel = "pF",
          ID = new Guid("1a9b9112-8a9f-4c80-a2ad-ebe5d9af5eef"),
          ConversionFactorFromSIFormula = "1.0/Factors.Pico"
        }
        };
        public ElectricalCapacitanceQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Electrical Capacitance" };
            ID = new Guid("9b284ff7-57bb-4ee0-bdbc-5fb7b80f3ae3");
            InitializeUnitChoices();
        }
    }
}
