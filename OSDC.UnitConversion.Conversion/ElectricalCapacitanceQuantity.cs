using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class ElectricalCapacitanceQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = "C";
        public override string SIUnitName { get; } = "Farad";
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
                }
                return instance_;
            }
        }
        protected ElectricalCapacitanceQuantity() : base()
        {
            Name = "Capacitance";
            ID = new Guid("9b284ff7-57bb-4ee0-bdbc-5fb7b80f3ae3");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("11dd208b-bcf2-4415-b7a9-4161791166c7"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
         new UnitChoice
        {
          UnitName = "CoulombPerVolt",
          UnitLabel = "C/V",
          ID = new Guid("81ae5717-d834-4f25-800e-c42c3bcb48af"),
          ConversionFactorFromSI = 1
        },
        new UnitChoice
        {
          UnitName = "MilliFarad",
          UnitLabel = "mF",
          ID = new Guid("12c8b1ad-d38a-4dbe-b418-7f3b31c23ff6"),
          ConversionFactorFromSI = 1000
        },
        new UnitChoice
        {
          UnitName = "MicroFarad",
          UnitLabel = "μF",
          ID = new Guid("a5974c82-68ac-4166-81b0-123f3ae84701"),
          ConversionFactorFromSI = 1000000
        },
        new UnitChoice
        {
          UnitName = "PicoFarad",
          UnitLabel = "pF",
          ID = new Guid("1a9b9112-8a9f-4c80-a2ad-ebe5d9af5eef"),
          ConversionFactorFromSI = 1000000000
        }
      };
            PostProcess();
        }
    }
}
