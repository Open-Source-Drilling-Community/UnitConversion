using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class TimeQuantity : BasePhysicalQuantity
    {
        public override string DimensionSymbol { get; } = "T";
        public override string SIUnitName { get; } = "second";
        public override string SIUnitLabel { get; } = "s";
        private static TimeQuantity instance_ = null;
        public override double TimeDimension { get; } = 1;

        public static TimeQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new TimeQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public TimeQuantity() : base()
        {
            Name = "Time";
            ID = new Guid("7106f7cb-ddf2-4e2f-9e21-b19bc83eb248");
            UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                    UnitName = SIUnitName,
                    UnitLabel = SIUnitLabel,
                    ID = new Guid("eac42b09-cc85-4e29-9aaf-05fe73bca2aa"),
                    ConversionFactorFromSI = 1.0,
                    IsSI = true
                },
                new UnitChoice
                {
                    UnitName = "millisecond",
                    UnitLabel = "ms",
                    ID = new Guid("1c1b150f-80a0-47da-836c-a583c4fa4b74"),
                    ConversionFactorFromSI = 1000.0
                },
                new UnitChoice
                {
                    UnitName = "microsecond",
                    UnitLabel = "µs",
                    ID = new Guid("18cf5c8f-bdd4-4575-a74b-f8321c567edb"),
                    ConversionFactorFromSI = 1000000.0
                },
                new UnitChoice
                {
                    UnitName = "shake",
                    UnitLabel = "shake",
                    ID = new Guid("f2b06fdd-ddfe-430b-8107-11597bdfdf2f"),
                    ConversionFactorFromSI = 100000000.0
                },
                new UnitChoice
                {
                    UnitName = "nanosecond",
                    UnitLabel = "ns",
                    ID = new Guid("6bf1a718-637c-4e86-ae3e-426d2a1a9195"),
                    ConversionFactorFromSI = 1000000000.0
                },
                 new UnitChoice
                {
                    UnitName = "picosecond",
                    UnitLabel = "ps",
                    ID = new Guid("9e10f905-4dc5-4670-9adf-278afd7d4131"),
                    ConversionFactorFromSI = 1000000000000.0
                },
                new UnitChoice
                {
                    UnitName = "minute",
                    UnitLabel = "min",
                    ID = new Guid("4b9dc241-388b-4b7a-b862-48db43234c4a"),
                    ConversionFactorFromSI = 1.0/60.0
                },
                new UnitChoice
                {
                    UnitName = "hour",
                    UnitLabel = "h",
                    ID = new Guid("f0d815e4-9bef-4422-94e6-1de52216b611"),
                    ConversionFactorFromSI = 1.0/3600.0
                },
                new UnitChoice
                {
                    UnitName = "day",
                    UnitLabel = "d",
                    ID = new Guid("85442621-bb56-4e2a-8e77-2b72409ff84f"),
                    ConversionFactorFromSI = 1.0/(24.0*3600.0)
                },
                new UnitChoice
                {
                    UnitName = "week",
                    UnitLabel = "week",
                    ID = new Guid("4dd50f01-60b3-4d44-82ea-ff8ededd797d"),
                    ConversionFactorFromSI = 1.0/(7*24.0*3600.0)
                },
                new UnitChoice
                {
                    UnitName = "fortnight",
                    UnitLabel = "fortnight",
                    ID = new Guid("bc87f864-3dc1-4f1a-87bc-4123a47c53dc"),
                    ConversionFactorFromSI = 1.0/(14*24.0*3600.0)
                },
                new UnitChoice
                {
                    UnitName = "month common",
                    UnitLabel = "month common",
                    ID = new Guid("41cceaa2-1a1d-40f1-9195-5183be9770d4"),
                    ConversionFactorFromSI = 1.0/2628000.0
                },
                new UnitChoice
                {
                    UnitName = "month synodic",
                    UnitLabel = "month synodic",
                    ID = new Guid("31edcda9-df8f-4d15-83a9-7dafd8a7e404"),
                    ConversionFactorFromSI = 1.0/2551442.889600
                },
                new UnitChoice
                {
                    UnitName = "quater common",
                    UnitLabel = "quarter common",
                    ID = new Guid("71f0e01a-c1a2-49ba-a25b-c11854f8867c"),
                    ConversionFactorFromSI = 1.0/7884000.0
                },
                new UnitChoice
                {
                    UnitName = "year common",
                    UnitLabel = "y",
                    ID = new Guid("38481414-3b9d-472d-ac31-04b00dcc9d5c"),
                    ConversionFactorFromSI = 1.0/31536000.0
                },
                new UnitChoice
                {
                    UnitName = "year average gregorian",
                    UnitLabel = "year average gregorian",
                    ID = new Guid("fc33008b-9517-440f-a56b-189c5d80621b"),
                    ConversionFactorFromSI = 1.0/31556952.0
                },
                new UnitChoice
                {
                    UnitName = "year julian",
                    UnitLabel = "year julian",
                    ID = new Guid("281f6c7b-da23-4aab-89e1-994e52280658"),
                    ConversionFactorFromSI = 1.0/31557600.0
                },
                new UnitChoice
                {
                    UnitName = "year leap",
                    UnitLabel = "year leap",
                    ID = new Guid("c84c1293-82d4-481b-8f6e-8bb8b81e6273"),
                    ConversionFactorFromSI = 1.0/31622400.0
                },
                new UnitChoice
                {
                    UnitName = "year tropical",
                    UnitLabel = "year tropical",
                    ID = new Guid("e93c0b95-68b1-4ecc-9b27-f07a9a53ad49"),
                    ConversionFactorFromSI = 1.0/31556925.216
                },
                new UnitChoice
                {
                    UnitName = "decade",
                    UnitLabel = "decade",
                    ID = new Guid("b7d3b041-7119-45a6-a5ea-e05d7cb3c68b"),
                    ConversionFactorFromSI = 1.0/315360000.0
                },
                new UnitChoice
                {
                    UnitName = "century",
                    UnitLabel = "century",
                    ID = new Guid("5cf296b6-48bf-4cc1-bf79-0220100ef1db"),
                    ConversionFactorFromSI = 1.0/3153600000.0
                },
                new UnitChoice
                {
                    UnitName = "millenia",
                    UnitLabel = "millenia",
                    ID = new Guid("c235c8fc-f15b-45ff-a1b7-aab46ccea159"),
                    ConversionFactorFromSI = 1.0/31536000000.0
                },
                new UnitChoice
                {
                    UnitName = "million year",
                    UnitLabel = "My",
                    ID = new Guid("d0281a3c-86dd-4d05-b856-cb7fa67c0f4d"),
                    ConversionFactorFromSI = 1.0/31536000000000.0
                }
            };
        }
    }
}
