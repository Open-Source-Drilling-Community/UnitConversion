using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
  public partial class GammaRayQuantity : DerivedPhysicalQuantity
    {
    public override string TypicalSymbol {get; } = null;
    public override string SIUnitName {get; } = "GammaAPI";
    public override string SIUnitLabel {get; } = "API";
    public override double? MeaningFullPrecisionInSI {get; } = 0.001;
    private static GammaRayQuantity instance_ = null;

    public static GammaRayQuantity Instance
    {
      get
      {
        if (instance_ == null)
        {
          instance_ = new GammaRayQuantity();
        }
        return instance_;
      }
    }
    protected GammaRayQuantity() : base()
    {
      Name = "GammaRay";
      ID = new Guid("15280017-0ac6-4dad-a6e1-1efdb05e64c5");
      UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("526a7d9b-514c-4b2d-9ff3-e69d64c299a9"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        }
      };
      PostProcess();
    }
  }
}
