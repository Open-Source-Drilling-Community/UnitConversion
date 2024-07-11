using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class MaterialStrengthQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "Pascal";
        public override string SIUnitLabel { get; } = "Pa";
        public override double MassDimension { get; } = 1;
        public override double LengthDimension { get; } = -1;
        public override double TimeDimension { get; } = -1;
        private static MaterialStrengthQuantity instance_ = null;

        public static MaterialStrengthQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new MaterialStrengthQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public MaterialStrengthQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Material Strength" };
            ID = new Guid("d9ca8230-a07a-45c0-ba67-051b70607c40");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("159e99d3-c79d-4dc6-974f-05cc38af001e"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "MegaPascal",
          UnitLabel = "MPa",
          ID = new Guid("38b95b61-a825-4393-a0e8-ecd686575735"),
          ConversionFactorFromSI = 1E-06
        },
        new UnitChoice
        {
          UnitName = "GigaPascal",
          UnitLabel = "GPa",
          ID = new Guid("c9aa0a18-02ac-42a0-9afe-8a08b4f03331"),
          ConversionFactorFromSI = 1E-09
        },
        new UnitChoice
        {
          UnitName = "PSI",
          UnitLabel = "psi",
          ID = new Guid("4adf2a33-05c3-49bb-ba61-59dd76f4621e"),
          ConversionFactorFromSI = 0.00014503762645158165
        },
        new UnitChoice
        {
          UnitName = "PoundPer100SquareFoot",
          UnitLabel = "lb/100ft²",
          ID = new Guid("eb1e2a52-3de3-4338-ad4d-40e8ce90e40b"),
          ConversionFactorFromSI = 2.0887
        },
        new UnitChoice
        {
          UnitName = "MegapoundPerSquareInch",
          UnitLabel = "Mpsi",
          ID = new Guid("197a8b98-190d-4d45-91d7-85af12deab02"),
          ConversionFactorFromSI = 1.4503762645158166E-10
        }
      };
        }
    }
}
