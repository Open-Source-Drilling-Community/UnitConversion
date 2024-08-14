using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class AngleVariationGradientQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "radian per metre";
        public override string SIUnitLabel { get; } = "rad/m";
        public override double LengthDimension { get; } = -1;
        public override double PlaneAngleDimension { get; } = 1;
        private static AngleVariationGradientQuantity instance_ = null;

        public static AngleVariationGradientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new AngleVariationGradientQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public static List<UnitChoice> UnitChoiceDescriptions = new List<UnitChoice>()
        {
            new UnitChoice
        {
          UnitName = "radian per metre",
          UnitLabel = "rad/m",
          ID = new Guid("5d9782b6-c4c7-47ca-a86b-dce3f63c3747"),
          ConversionFactorFromSIFormula = "1.0/Factors.Unit",
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "degree per metre",
          UnitLabel = "°/m",
          ID = new Guid("2fcd4219-8879-4494-9563-5173ec2292fa"),
          ConversionFactorFromSIFormula = "Factors.Degree"
        },
         new UnitChoice
        {
          UnitName = "degree per centimetre",
          UnitLabel = "°/cm",
          ID = new Guid("7f4f63d6-5ea8-4c6b-8be4-81f52b7060c7"),
          ConversionFactorFromSIFormula = "Factors.Degree*Factors.Centi"
        },
        new UnitChoice
        {
          UnitName = "degree per foot",
          UnitLabel = "°/ft",
          ID = new Guid("23bf7716-5779-4607-aef7-1e0eeb7f201b"),
          ConversionFactorFromSIFormula = "Factors.Degree*Factors.Foot"
        },
        new UnitChoice
        {
          UnitName = "degree per inch",
          UnitLabel = "°/in",
          ID = new Guid("271db65d-2a9f-4fec-a52a-21e13e106dd4"),
          ConversionFactorFromSIFormula = "Factors.Degree*Factors.Inch"
        },
        new UnitChoice
        {
          UnitName = "degree per decimetre",
          UnitLabel = "°/dm",
          ID = new Guid("452edd17-d501-487b-8cc1-90c08f7b1417"),
          ConversionFactorFromSIFormula = "Factors.Degree*Factors.Deci"
        },
        new UnitChoice
        {
          UnitName = "degree per millimetre",
          UnitLabel = "°/mm",
          ID = new Guid("5cc72a73-70c0-4ccf-83ae-38e8a45391b4"),
          ConversionFactorFromSIFormula = "Factors.Degree*Factors.Milli"
        },
        new UnitChoice
        {
          UnitName = "radian per millimetre",
          UnitLabel = "rad/mm",
          ID = new Guid("dbd20525-128b-43c5-9de4-a8e604cbf6bf"),
          ConversionFactorFromSIFormula = "Factors.Milli"
        },
         new UnitChoice
        {
          UnitName = "radian per centimetre",
          UnitLabel = "rad/cm",
          ID = new Guid("5552abca-e21b-48ca-aedc-4518a32b8de3"),
          ConversionFactorFromSIFormula = "Factors.Centi"
        },
          new UnitChoice
        {
          UnitName = "radian per decimetre",
          UnitLabel = "rad/dm",
          ID = new Guid("47e72ab7-444d-4d4b-8cd2-01d2fb8efa2d"),
          ConversionFactorFromSIFormula = "Factors.Deci"
        },
        new UnitChoice
        {
          UnitName = "radian per foot",
          UnitLabel = "rad/ft",
          ID = new Guid("e1ab7dd2-48c7-4ac8-ac5e-bc50fdcae5df"),
          ConversionFactorFromSIFormula = "Factors.Foot"
        },
        new UnitChoice
        {
          UnitName = "radian per inch",
          UnitLabel = "rad/in",
          ID = new Guid("c36cf9c1-d4f2-4654-99eb-5d84eac21c66"),
          ConversionFactorFromSIFormula = "Factors.Inch"
        }
        };
        public AngleVariationGradientQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Angle Variation Gradient" };
            ID = new Guid("aed9c464-1073-448b-be62-a6a0c2a53dbc");
            InitializeUnitChoices();
        }
    }
}
