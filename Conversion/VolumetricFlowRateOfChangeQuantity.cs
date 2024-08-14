using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class VolumetricFlowRateOfChangeQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "cubic metre per second squared";
        public override string SIUnitLabel { get; } = "m³/s²";
        public override double LengthDimension { get; } = 3;
        public override double TimeDimension { get; } = -2;
        private static VolumetricFlowRateOfChangeQuantity instance_ = null;

        public static VolumetricFlowRateOfChangeQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new VolumetricFlowRateOfChangeQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public VolumetricFlowRateOfChangeQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Volumetric Flow Rate Rate Of Change" };
            ID = new Guid("7f4f645c-e23e-41bc-bbcc-1dbcef53318e");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("aef20431-be0b-44ea-8770-a59db19b7f94"),
          ConversionFactorFromSI = 1.0/Factors.Unit,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "litre per minute squared",
          UnitLabel = "L/min²",
          ID = new Guid("b27d2f54-a1f3-4abb-ba6d-a2a8b530049a"),
          ConversionFactorFromSI = Factors.Minute*Factors.Minute/Factors.Milli
        },
        new UnitChoice
        {
          UnitName = "litre per minute per second",
          UnitLabel = "L/min/s",
          ID = new Guid("e5a265b6-a9ba-4a09-ba08-b8c417b28ffb"),
          ConversionFactorFromSI = Factors.Minute/Factors.Milli
        },
        new UnitChoice
        {
          UnitName = "litre per second squared",
          UnitLabel = "L/s²",
          ID = new Guid("a899c06f-18dd-4d2a-9743-489f0af5be91"),
          ConversionFactorFromSI = 1.0/Factors.Milli
        },
        new UnitChoice
        {
          UnitName = "UK gallon per minute squared",
          UnitLabel = "UKGal/min²",
          ID = new Guid("c7c61175-e527-4403-8425-32f681367985"),
          ConversionFactorFromSI = Factors.Minute*Factors.Minute/Factors.GallonUK
        },
        new UnitChoice
        {
          UnitName = "UK gallon per minute per second",
          UnitLabel = "UKGal/min/s",
          ID = new Guid("298e7a16-07a5-4b5b-a0de-3e49b31254b4"),
          ConversionFactorFromSI = Factors.Minute*Factors.Unit/Factors.GallonUK
        },
        new UnitChoice
        {
          UnitName = "US gallon per minute squared",
          UnitLabel = "USGal/min²",
          ID = new Guid("61885289-823d-4b26-bdf2-bc4744567bef"),
          ConversionFactorFromSI = Factors.Minute*Factors.Minute/Factors.GallonUS
        },
        new UnitChoice
        {
          UnitName = "US gallon per minute per second",
          UnitLabel = "USGal/min/s",
          ID = new Guid("3c530e9a-9376-49d1-a6b5-0a6f93f4184b"),
          ConversionFactorFromSI = Factors.Minute*Factors.Unit/Factors.GallonUS
        }
      };
        }
    }
}
