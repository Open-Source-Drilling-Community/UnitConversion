using Conversion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class FrequencyRateOfChangeQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "hertz per second";
        public override string SIUnitLabel { get; } = "Hz/s";
        public override double TimeDimension { get; } = -2;
        private static FrequencyRateOfChangeQuantity instance_ = null;

        public static FrequencyRateOfChangeQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new FrequencyRateOfChangeQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public FrequencyRateOfChangeQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Frequency Rate Of Change" };
            ID = new Guid("e9d5bfe9-428b-4df0-9fe5-d9ad17e6a0cb");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("4d7e4b49-df76-4259-a96c-8c1250d5ecdd"),
          ConversionFactorFromSI = 1.0/Factors.Unit,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "kilo hertz per second",
          UnitLabel = "kHz/s",
          ID = new Guid("e197e7ca-93f7-4348-9508-74e61ce97f94"),
          ConversionFactorFromSI = 1.0/Factors.Kilo
        },
        new UnitChoice
        {
          UnitName = "mega hertz per second",
          UnitLabel = "MHz/s",
          ID = new Guid("8c9671f4-54b6-40a0-94c1-5cfb25378f88"),
          ConversionFactorFromSI = 1.0/Factors.Mega
        },
        new UnitChoice
        {
          UnitName = "giga hertz per second",
          UnitLabel = "GHz/s",
          ID = new Guid("46ad2062-982c-461f-95d8-ddd888e5d4f8"),
          ConversionFactorFromSI = 1.0/Factors.Giga
        },
        new UnitChoice
        {
          UnitName = "hertz per minute",
          UnitLabel = "Hz/min",
          ID = new Guid("af3fcbbf-4fc8-4b5d-b555-33340d3c2f0f"),
          ConversionFactorFromSI = Factors.Minute/Factors.Unit
        },
        new UnitChoice
        {
          UnitName = "kilo hertz per minute",
          UnitLabel = "kHz/min",
          ID = new Guid("0fabfb82-03fb-4855-aaea-578e36c9c7cf"),
          ConversionFactorFromSI = Factors.Minute/Factors.Kilo
        },
        new UnitChoice
        {
          UnitName = "mega hertz per minute",
          UnitLabel = "MHz/min",
          ID = new Guid("97c4e6e3-a8b3-4aa6-a742-1900a239e282"),
          ConversionFactorFromSI = Factors.Minute/Factors.Mega
        },
        new UnitChoice
        {
          UnitName = "giga hertz per minute",
          UnitLabel = "GHz/min",
          ID = new Guid("8d8d140d-00cd-4e80-aaa5-8d2d5ddcbc73"),
          ConversionFactorFromSI = Factors.Minute/Factors.Giga
        },
        new UnitChoice
        {
          UnitName = "hertz per hour",
          UnitLabel = "Hz/h",
          ID = new Guid("424100d5-ab81-4061-9429-74a9e3638453"),
          ConversionFactorFromSI = Factors.Hour/Factors.Unit
        },
        new UnitChoice
        {
          UnitName = "kilo hertz per hour",
          UnitLabel = "kHz/h",
          ID = new Guid("0963dc43-168a-483c-be3f-3c9054b0c692"),
          ConversionFactorFromSI = Factors.Hour/Factors.Kilo
        },
        new UnitChoice
        {
          UnitName = "mega hertz per hour",
          UnitLabel = "MHz/h",
          ID = new Guid("a1b30880-ba44-4675-b808-6d93ba8aa8d2"),
          ConversionFactorFromSI = Factors.Hour/Factors.Mega
        },
        new UnitChoice
        {
          UnitName = "giga hertz per hour",
          UnitLabel = "GHz/h",
          ID = new Guid("cd42ca67-9d8b-411c-bcce-e9e5ce6d1259"),
          ConversionFactorFromSI = Factors.Hour/Factors.Giga
        },
        new UnitChoice
        {
          UnitName = "hertz per day",
          UnitLabel = "Hz/d",
          ID = new Guid("fe28723d-23e5-45f3-b286-50705746d643"),
          ConversionFactorFromSI = Factors.Day/Factors.Unit
        },
        new UnitChoice
        {
          UnitName = "kilo hertz per day",
          UnitLabel = "kHz/d",
          ID = new Guid("0dc10fed-83a5-4570-a997-f2422d71d7fd"),
          ConversionFactorFromSI = Factors.Day/Factors.Kilo
        },
        new UnitChoice
        {
          UnitName = "mega hertz per day",
          UnitLabel = "MHz/d",
          ID = new Guid("c5743df5-a0be-41d2-99a1-b1f760940007"),
          ConversionFactorFromSI = Factors.Day/Factors.Mega
        },
        new UnitChoice
        {
          UnitName = "giga hertz per day",
          UnitLabel = "GHz/d",
          ID = new Guid("56e88229-8197-4ca2-aa69-e4100234d344"),
          ConversionFactorFromSI = Factors.Day/Factors.Giga
        },
        new UnitChoice
        {
          UnitName = "hertz per year",
          UnitLabel = "Hz/y",
          ID = new Guid("1195a495-ea6e-4b5a-92b6-6ef0d2ca23d5"),
          ConversionFactorFromSI = Factors.YearJulian/Factors.Unit
        },
        new UnitChoice
        {
          UnitName = "kilo hertz per year",
          UnitLabel = "kHz/y",
          ID = new Guid("2e2a0d0f-5658-4ba2-8799-53bb06f197e7"),
          ConversionFactorFromSI = Factors.YearJulian/Factors.Kilo
        },
        new UnitChoice
        {
          UnitName = "mega hertz per year",
          UnitLabel = "MHz/y",
          ID = new Guid("665c1c2a-57f6-4696-8b7b-524f8ad6084f"),
          ConversionFactorFromSI = Factors.YearJulian/Factors.Mega
        },
        new UnitChoice
        {
          UnitName = "giga hertz per year",
          UnitLabel = "GHz/y",
          ID = new Guid("2c756b88-bbed-4650-8307-86bc7513caee"),
          ConversionFactorFromSI = Factors.YearJulian/Factors.Giga
        }
      };
        }
    }
}
