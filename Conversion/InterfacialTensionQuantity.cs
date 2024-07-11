using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class InterfacialTensionQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "NewtonPerMetre";
        public override string SIUnitLabel { get; } = "N/m";
        public override double MassDimension { get; } = 1;
        public override double TimeDimension { get; } = -2;
        private static InterfacialTensionQuantity instance_ = null;

        public static InterfacialTensionQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new InterfacialTensionQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public InterfacialTensionQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Interfacial Tension" };
            ID = new Guid("6c2da24b-fa92-415d-9161-150de87dad4c");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("7ee9eca6-2704-442a-bd50-c8a0826da932"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "MilliNewtonPerMetre",
          UnitLabel = "mN/m",
          ID = new Guid("7b1b363c-cbb0-4499-9d7c-762adc43e690"),
          ConversionFactorFromSI = 1000
        },
        new UnitChoice
        {
          UnitName = "DynesPerCentimetre",
          UnitLabel = "dyn/cm",
          ID = new Guid("a3c12fb9-6936-44bf-ad66-f4139163d11b"),
          ConversionFactorFromSI = 1000
        },
        new UnitChoice
        {
          UnitName = "PoundPerSecondSquared",
          UnitLabel = "lbm/s²",
          ID = new Guid("03db472b-b8e8-4ad0-b2b1-b8970686210c"),
          ConversionFactorFromSI = 2.2046244201837775
        }
      };
        }
    }
}
