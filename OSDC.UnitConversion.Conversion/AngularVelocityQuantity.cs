using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.Conversion
{
    public partial class AngularVelocityQuantity : DerivedPhysicalQuantity
    {
        public override string TypicalSymbol { get; } = "ω";
        public override string SIUnitName { get; } = "RadianPerSecond";
        public override string SIUnitSymbol { get; } = "rd/s";
        private static AngularVelocityQuantity instance_ = null;

        public static AngularVelocityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new AngularVelocityQuantity();
                }
                return instance_;
            }
        }
        protected AngularVelocityQuantity() : base()
        {
            Name = "AngularVelocity";
            ID = new Guid("688ccd2b-6a30-4ccc-8580-a80c3a5803fa");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitSymbol = SIUnitSymbol,
          ID = new Guid("8889fafb-cc58-4c4e-a52d-696219dfcf4a"),
          ConversionFactorFromSI = 1.0,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "DegreePerSecond",
          UnitSymbol = "°/s",
          ID = new Guid("c6c0676e-c8a6-407d-be44-1691fd6b5d9e"),
          ConversionFactorFromSI = 57.29577951308232
        },
        new UnitChoice
        {
          UnitName = "RadianPerDay",
          UnitSymbol = "rd/d",
          ID = new Guid("53f2a55b-beb6-4e4d-b696-e817c5b0eaed"),
          ConversionFactorFromSI = 86400
        },
        new UnitChoice
        {
          UnitName = "RadianPerHour",
          UnitSymbol = "rd/h",
          ID = new Guid("c2f0e82b-236b-4eb5-9c77-b2c500ab60ab"),
          ConversionFactorFromSI = 3600
        },
        new UnitChoice
        {
          UnitName = "RadianPerMinute",
          UnitSymbol = "rd/min",
          ID = new Guid("5267eb8c-36bc-4ab9-bd62-26f05f852c35"),
          ConversionFactorFromSI = 60
        },
        new UnitChoice
        {
          UnitName = "DegreePerDay",
          UnitSymbol = "°/d",
          ID = new Guid("ec049b3d-134b-44a3-9746-0419a368beef"),
          ConversionFactorFromSI = 4950355.3499303
        },
        new UnitChoice
        {
          UnitName = "DegreePerHour",
          UnitSymbol = "°/h",
          ID = new Guid("44cc8b17-2f87-49c9-8ab7-7f4ed36d9eb6"),
          ConversionFactorFromSI = 206264.8062471
        },
        new UnitChoice
        {
          UnitName = "DegreePerMinute",
          UnitSymbol = "°/min",
          ID = new Guid("0a3ad50c-bbfa-456c-9613-84f37b4a80f1"),
          ConversionFactorFromSI = 3437.746770785
        }
      };
            PostProcess();
        }
    }
}
