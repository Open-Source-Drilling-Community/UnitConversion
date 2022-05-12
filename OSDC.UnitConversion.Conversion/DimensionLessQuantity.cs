using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
  public partial class DimensionLessQuantity : DerivedPhysicalQuantity
    {
    public override string TypicalSymbol {get; } = null;
    public override string SIUnitName {get; } = "DimensionLess";
    public override string SIUnitSymbol {get; } = "";
    private static DimensionLessQuantity instance_ = null;

    public static DimensionLessQuantity Instance
    {
      get
      {
        if (instance_ == null)
        {
          instance_ = new DimensionLessQuantity();
        }
        return instance_;
      }
    }
    protected DimensionLessQuantity() : base()
    {
      Name = "DimensionLess";
      ID = new Guid("790ae2cd-170c-4908-b2b9-163ba95f5b43");
      UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitSymbol = SIUnitSymbol,
          ID = new Guid("8744b0f7-2866-42d8-bf6c-b619ac87b945"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        }
      };
      PostProcess();
    }
  }
}
