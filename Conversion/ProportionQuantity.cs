using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class ProportionQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "Proportion";
        public override string SIUnitLabel { get; } = "";
        private static ProportionQuantity instance_ = null;

        public static ProportionQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new ProportionQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public ProportionQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Proportion" };
            ID = new Guid("10d2d588-19b8-4822-9240-e1d278d99e32");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("03eb339b-61aa-4b42-aa35-4a20c547fdb9"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "Percent",
          UnitLabel = "%",
          ID = new Guid("1a825e84-bc53-4da8-a089-118fdf40b8f7"),
          ConversionFactorFromSI = 100
        },
        new UnitChoice
        {
          UnitName = "PerThousand",
          UnitLabel = "‰",
          ID = new Guid("141465a2-9c3c-4dda-82ec-eb35e72250c2"),
          ConversionFactorFromSI = 1000
        },
        new UnitChoice
        {
          UnitName = "PartPerMillion",
          UnitLabel = "ppm",
          ID = new Guid("af33bf27-c3b8-4746-8b08-826ed1d21792"),
          ConversionFactorFromSI = 1000000
        }
      };
        }
    }
}
