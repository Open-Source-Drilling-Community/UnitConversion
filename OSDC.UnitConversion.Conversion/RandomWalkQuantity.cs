﻿using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace OSDC.UnitConversion.Conversion
{
    public partial class RandomWalkQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "RadianPerSqrtSecond";
        public override string SIUnitLabel { get; } = "rd/√s";
        public override double MassDimension { get; } = 0;
        public override double LengthDimension { get; } = 1;
        public override double TimeDimension { get; } = -1/2;
        public override double ElectricCurrentDimension { get; } = 0;
        private static RandomWalkQuantity instance_ = null;

        public static RandomWalkQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new RandomWalkQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public RandomWalkQuantity() : base()
        {
            Name = "RandomWalk";
            ID = new Guid("e3d17133-1c98-4ef2-8b1b-f0d935a4c1e4");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("557ea59e-a1da-438b-b04d-ccfc5539f87f"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "RadianPerSqrtMinute",
          UnitLabel = "rd/√min",
          ID = new Guid("ccc41b4e-2efb-4760-969f-94614248374f"),
          ConversionFactorFromSI = Math.Sqrt(60.0)
        },
        new UnitChoice
        {
          UnitName = "RadianPerSqrtHour",
          UnitLabel = "rd/√h",
          ID = new Guid("e296c410-e278-4586-af95-bae6fe4f0673"),
          ConversionFactorFromSI = Math.Sqrt(3600.0)
        },
        new UnitChoice
        {
          UnitName = "RadianPerSqrtDay",
          UnitLabel = "rd/√d",
          ID = new Guid("fb4a74f9-a648-4310-a424-9c85036bbc41"),
          ConversionFactorFromSI = Math.Sqrt(3600.0*24.0)
        },
        new UnitChoice
        {
          UnitName = "DegreePerSqrtSecond",
          UnitLabel = "°/√s",
          ID = new Guid("87a0a4e3-a2f5-4f84-b845-c7e6276e1655"),
          ConversionFactorFromSI = 180.0/Math.PI
        },
        new UnitChoice
        {
          UnitName = "DegreePerSqrtMinute",
          UnitLabel = "°/√min",
          ID = new Guid("e8e3a988-4219-44a5-ae89-ce115a239d04"),
          ConversionFactorFromSI = 180.0*Math.Sqrt(60.0)/Math.PI
        },
        new UnitChoice
        {
          UnitName = "DegreePerSqrtHour",
          UnitLabel = "°/√h",
          ID = new Guid("ab6b85cf-54e5-4c3b-a330-f65d7e3bb926"),
          ConversionFactorFromSI = 180.0*Math.Sqrt(3600.0)/Math.PI
        },
        new UnitChoice
        {
          UnitName = "DegreePerSqrtDay",
          UnitLabel = "°/√d",
          ID = new Guid("8f806d0f-3741-4aa8-9f37-54b4f80e307c"),
          ConversionFactorFromSI = 180.0*Math.Sqrt(3600.0*24.0)/Math.PI
        }
           };
        }
    }
}
