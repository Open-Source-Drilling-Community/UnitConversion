using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class CurvatureQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = "κ";
        public override string SIUnitName { get; } = "RadianPerMeter";
        public override string SIUnitLabel { get; } = "rd/m";
        public override double LengthDimension { get; } = -1;
        public override double PlaneAngleDimension { get; } = 1;
        private static CurvatureQuantity instance_ = null;

        public static CurvatureQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new CurvatureQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public CurvatureQuantity() : base()
        {
            Name = "Curvature";
            ID = new Guid("bbfe7349-8cf5-4ca0-8a84-ffe66d7f33d0");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("cbba2f64-9914-4c00-a3fe-3c2aef560225"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "DegreePer10m",
          UnitLabel = "°/10m",
          ID = new Guid("c62408d6-c3c5-47bd-8cb0-4fa9faf51598"),
          ConversionFactorFromSI = 572.9577951308232
        },
        new UnitChoice
        {
          UnitName = "DegreePer30m",
          UnitLabel = "°/30m",
          ID = new Guid("98a4d593-c959-49fb-ba1a-b1aa61830cd7"),
          ConversionFactorFromSI = 1718.8733853924698
        },
        new UnitChoice
        {
          UnitName = "DegreePer30ft",
          UnitLabel = "°/30ft",
          ID = new Guid("284dca7d-b1fc-4e40-ab08-a3e0fa2ef9d0"),
          ConversionFactorFromSI = 523.9126078676247
        },
        new UnitChoice
        {
          UnitName = "DegreePer100ft",
          UnitLabel = "°/100ft",
          ID = new Guid("5aa20ab5-6800-48db-abb1-4c3538b0972d"),
          ConversionFactorFromSI = 1746.375359558749
        },
        new UnitChoice
        {
          UnitName = "DegreePerFoot",
          UnitLabel = "°/ft",
          ID = new Guid("363a6781-5829-4046-95d8-ce1e844343fc"),
          ConversionFactorFromSI = 17.46375359558749
        },
        new UnitChoice
        {
          UnitName = "RadianPerFoot",
          UnitLabel = "rd/ft",
          ID = new Guid("1428743e-927c-4f7a-9e15-62d37790ad51"),
          ConversionFactorFromSI = 0.3048
        },
        new UnitChoice
        {
          UnitName = "DegreePerMeter",
          UnitLabel = "°/m",
          ID = new Guid("7c47f046-0499-4108-937d-abb504883259"),
          ConversionFactorFromSI = 57.29577951308232
        }
      };
        }
    }
}
