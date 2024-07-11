using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class TemperatureGradientQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "KelvinPerMetre";
        public override string SIUnitLabel { get; } = "K/m";
        public override double LengthDimension { get; } = -1;
        public override double TemperatureDimension { get; } = 1;
        private static TemperatureGradientQuantity instance_ = null;

        public static TemperatureGradientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new TemperatureGradientQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public TemperatureGradientQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Temperature Gradient" };
            ID = new Guid("4c1819d5-008b-4613-b62a-3f5d91b08ee7");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("f1fe19d2-12e3-43d1-ba97-3ef9e8ec9e73"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "CelsiusPerMetre",
          UnitLabel = "°C/m",
          ID = new Guid("40dbbdfe-b680-403a-8326-2c217ba85d52"),
          ConversionFactorFromSI = 1
        },
        new UnitChoice
        {
          UnitName = "CelsiusPer10Metre",
          UnitLabel = "°C/10m",
          ID = new Guid("5e4ff2bf-4788-4258-bd4a-7b18a13364ff"),
          ConversionFactorFromSI = 10
        },
        new UnitChoice
        {
          UnitName = "CelsiusPer30Metre",
          UnitLabel = "°C/30m",
          ID = new Guid("d17464c4-a7ef-4dcd-b783-bafe6e9b92de"),
          ConversionFactorFromSI = 30
        },
        new UnitChoice
        {
          UnitName = "CelsiusPer100Metre",
          UnitLabel = "°C/100m",
          ID = new Guid("b47f299a-913a-46b7-ad20-c683fa0f02d0"),
          ConversionFactorFromSI = 100
        },
        new UnitChoice
        {
          UnitName = "CelsiusPerFoot",
          UnitLabel = "°C/ft",
          ID = new Guid("e7b05420-41f6-4812-bc54-9c14f05a9cbd"),
          ConversionFactorFromSI = 0.3048
        },
        new UnitChoice
        {
          UnitName = "CelsiusPer30Foot",
          UnitLabel = "°C/30ft",
          ID = new Guid("bea3df4f-78e9-4e1a-bbee-22086da043b4"),
          ConversionFactorFromSI = 9.144
        },
        new UnitChoice
        {
          UnitName = "CelsiusPer100Foot",
          UnitLabel = "°C/100ft",
          ID = new Guid("f9bae95a-b282-44a7-8ae0-54728ef3c7a3"),
          ConversionFactorFromSI = 30.48
        },
        new UnitChoice
        {
          UnitName = "FahrenheitPerFoot",
          UnitLabel = "°F/ft",
          ID = new Guid("d08596f1-77c4-4a8e-9245-6bf563fa7345"),
          ConversionFactorFromSI = 0.54864
        },
        new UnitChoice
        {
          UnitName = "FahrenheitPer30Foot",
          UnitLabel = "°F/30ft",
          ID = new Guid("a1664cb0-db5c-4933-9b57-d075c4975f46"),
          ConversionFactorFromSI = 16.4592
        },
        new UnitChoice
        {
          UnitName = "FahrenheitPer100Foot",
          UnitLabel = "°F/100ft",
          ID = new Guid("232e2d6d-cb65-4b56-9277-457e4ff678fa"),
          ConversionFactorFromSI = 54.864000000000004
        }
      };
        }
    }
}
