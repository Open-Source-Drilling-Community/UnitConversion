using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class TemperatureQuantity : SymbolizedBasePhysicalQuantity
    {
        public override string DimensionSymbol { get; } = "Θ";
        public override string SIUnitName { get; } = "kelvin";

        public override string SIUnitLabel { get; } = "K";
        private static TemperatureQuantity instance_ = null;

        public override double TemperatureDimension { get; } = 1;

        public static TemperatureQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new TemperatureQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public TemperatureQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Temperature" };
            ID = new Guid("16130f2d-72a8-44a5-beaa-adbb5a1a7b21");
            UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                    UnitName = SIUnitName,
                    UnitLabel = SIUnitLabel,
                    ID = new Guid("8fc5fa10-2d89-4064-8ace-b852d9a8d31f"),
                    ConversionFactorFromSI = 1.0,
                    IsSI = true
                },
                new UnitChoice
                {
                    UnitName = "celsius",
                    UnitLabel = "°C",
                    ID = new Guid("5d69048e-fe18-4923-9341-cb80c2ccf8cc"),
                    ConversionFactorFromSI = 1.0,
                    ConversionBiasFromSI = -273.15
                },
                new UnitChoice
                {
                    UnitName = "fahrenheit",
                    UnitLabel = "°F",
                    ID = new Guid("55c289ab-6975-439f-9b7a-fdca6d219a9f"),
                    ConversionFactorFromSI = 9.0/5.0,
                    ConversionBiasFromSI = -459.67
                },
                new UnitChoice
                {
                    UnitName = "réaumure",
                    UnitLabel = "°Ré",
                    ID = new Guid("968def6c-bc85-49b0-84a8-3ac7ad37efc6"),
                    ConversionFactorFromSI = 4.0/5.0,
                    ConversionBiasFromSI = -273.15 *4.0/5.0
                }
            };
        }
    }
}
