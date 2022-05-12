using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
  public partial class YoungModulusQuantity : PressureQuantity, IEngineeringQuantity
    {
    public virtual double? MeaningFullPrecisionInSI {get; } = 10000;
    private static YoungModulusQuantity instance_ = null;

    public static new YoungModulusQuantity Instance
    {
      get
      {
        if (instance_ == null)
        {
          instance_ = new YoungModulusQuantity();
        }
        return instance_;
      }
    }
    protected YoungModulusQuantity() : base()
    {
      Name = "YoungModulus";
      ID = new Guid("7ffbcc35-b46f-4656-baf5-c92be501f0ec");
            Reset();
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.Pascal));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.MegaPascal));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.GigaPascal));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.PoundPerSquareInch));
            this.UnitChoices.Add(PressureQuantity.Instance.GetUnitChoice(PressureQuantity.UnitChoicesEnum.MegaPoundPerSquareInch));
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitSymbol = SIUnitSymbol,
          ID = new Guid("1c02aa67-6ec3-4cd1-a61e-b3f1fe4fe0c7"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "MegaPascal",
          UnitSymbol = "MPa",
          ID = new Guid("754537d8-8043-48eb-9c0c-2d5efa19562e"),
          ConversionFactorFromSI = 1E-06
        },
        new UnitChoice
        {
          UnitName = "GigaPascal",
          UnitSymbol = "GPa",
          ID = new Guid("c50313fd-59ce-429c-b525-f1d7664170c7"),
          ConversionFactorFromSI = 1E-09
        },
        new UnitChoice
        {
          UnitName = "PSI",
          UnitSymbol = "psi",
          ID = new Guid("0305c2fe-1843-446b-badd-a2c02c367249"),
          ConversionFactorFromSI = 0.00014503762645158165
        },
        new UnitChoice
        {
          UnitName = "MegapoundPerSquareInch",
          UnitSymbol = "Mpsi",
          ID = new Guid("39285bdf-1b8b-4038-bb33-ab585e702bf3"),
          ConversionFactorFromSI = 1.4503762645158166E-10
        }
      };
      PostProcess();
    }
  }
}
