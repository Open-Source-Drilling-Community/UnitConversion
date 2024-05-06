using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSDC.UnitConversion.Conversion
{
    public partial class PowerQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "Watt";
        public override string SIUnitLabel { get; } = "W";
        public override double LengthDimension { get; } = 2;
        public override double MassDimension { get; } = 1;
        public override double TimeDimension { get; } = -3;
        private static PowerQuantity instance_ = null;

        public static PowerQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new PowerQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public PowerQuantity() : base()
        {
            Name = "Power";
            ID = new Guid("6fd69f30-a219-4d56-a1dd-000d8175e2ed");
            UnitChoices = new List<UnitChoice>()
            {
                   new UnitChoice
                   {
                       UnitName = SIUnitName,
                       UnitLabel = SIUnitLabel,
                       ID = new Guid("9d986a0c-700f-4448-a48c-a028bbd22049"),
                       ConversionFactorFromSI = 1.0,
                       IsSI = true
                   },
                   new UnitChoice
                   {
                       UnitName = "DecaWatt",
                       UnitLabel = "daW",
                       ID = new Guid("fa888306-f2ef-420a-9ce2-8c56fe64ea3c"),
                       ConversionFactorFromSI = 0.1
                   },
                   new UnitChoice
                   {
                       UnitName = "HectoWatt",
                       UnitLabel = "hW",
                       ID = new Guid("1f159f0d-635a-4bc8-9020-6c09d72b3f63"),
                       ConversionFactorFromSI = 0.01
                   },
                   new UnitChoice
                   {
                       UnitName = "KiloWatt",
                       UnitLabel = "kW",
                       ID = new Guid("016b23c7-0231-45bb-8723-5d3d4cc5c054"),
                       ConversionFactorFromSI = 0.001
                   },
                   new UnitChoice
                   {
                       UnitName = "MegaWatt",
                       UnitLabel = "MW",
                       ID = new Guid("5719b5f3-5c24-46d2-8ccd-0a06cc6b49ae"),
                       ConversionFactorFromSI = 0.000001
                   },
                   new UnitChoice
                   {
                       UnitName = "GigaWatt",
                       UnitLabel = "GW",
                       ID = new Guid("ba67ba92-cdf5-46a8-a5f5-56c1ad102417"),
                       ConversionFactorFromSI = 0.000000001
                   },
                   new UnitChoice
                   {
                       UnitName = "TeraWatt",
                       UnitLabel = "TW",
                       ID = new Guid("b3e60a20-9e0f-479b-903b-16b22d86a515"),
                       ConversionFactorFromSI = 0.000000000001
                   },
                   new UnitChoice
                   {
                       UnitName = "PetaWatt",
                       UnitLabel = "PW",
                       ID = new Guid("bafba6b7-8a58-46b0-b4c7-c9a008c5e8f4"),
                       ConversionFactorFromSI = 0.000000000000001
                   },
                   new UnitChoice
                   {
                       UnitName = "ExaWatt",
                       UnitLabel = "EW",
                       ID = new Guid("457950e4-0d4c-4f18-87ae-c35a7d2f512a"),
                       ConversionFactorFromSI = 0.000000000000000001
                   },
                   new UnitChoice
                   {
                       UnitName = "DeciWatt",
                       UnitLabel = "dW",
                       ID = new Guid("6a3cd886-1c2c-41c8-8214-b21aff588b1e"),
                       ConversionFactorFromSI = 10
                   },
                   new UnitChoice
                   {
                       UnitName = "CentiWatt",
                       UnitLabel = "cW",
                       ID = new Guid("ac6c67e1-0912-44f2-9496-ed82aca2b925"),
                       ConversionFactorFromSI = 100
                   },
                   new UnitChoice
                   {
                       UnitName = "MilliWatt",
                       UnitLabel = "mW",
                       ID = new Guid("4b9e8b24-6c84-423e-8f79-b2bec161f219"),
                       ConversionFactorFromSI = 1000
                   },
                   new UnitChoice
                   {
                       UnitName = "MicroWatt",
                       UnitLabel = "µW",
                       ID = new Guid("f0345b17-3e67-4c27-a787-69cd6feb7b1b"),
                       ConversionFactorFromSI = 1000000
                   },
                   new UnitChoice
                   {
                       UnitName = "NanoWatt",
                       UnitLabel = "nW",
                       ID = new Guid("622ee208-1b04-42c4-ba6e-552e6e328e02"),
                       ConversionFactorFromSI = 1000000000
                   },
                   new UnitChoice
                   {
                       UnitName = "PicoWatt",
                       UnitLabel = "pW",
                       ID = new Guid("5b46567b-0571-4ca7-90d5-6304a0b7f938"),
                       ConversionFactorFromSI = 1000000000000
                   },
                   new UnitChoice
                   {
                       UnitName = "FemtoWatt",
                       UnitLabel = "fW",
                       ID = new Guid("325622ea-c161-4f4f-9ee4-86d9e802f21c"),
                       ConversionFactorFromSI = 1000000000000000
                   },
                   new UnitChoice
                   {
                       UnitName = "AttoWatt",
                       UnitLabel = "aW",
                       ID = new Guid("7bc1807f-90ac-41b0-a15f-9d1c81101f6d"),
                       ConversionFactorFromSI = 1000000000000000000
                   }
            };
        }
    }
}
