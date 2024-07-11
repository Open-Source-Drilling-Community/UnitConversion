using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class WaveNumberQuantity : DerivedBasePhysicalQuantity
    {
        public override string SIUnitName { get; } = "ReciprocalMetre";

        public override string SIUnitLabel { get; } = "1/m";
        private static WaveNumberQuantity instance_ = null;

        public override double LengthDimension { get; } = -1;

        public static WaveNumberQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new WaveNumberQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public WaveNumberQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Wave Number" };
            ID = new Guid("3709c98d-d471-41dd-bfde-81c4458757e5");
            UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                    UnitName = SIUnitName,
                    UnitLabel = SIUnitLabel,
                    ID = new Guid("3cd38922-b99f-45bb-af6e-a38ebf1240f0"),
                    ConversionFactorFromSI = 1.0,
                    IsSI = true
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalDecimetre",
                    UnitLabel = "1/dm",
                    ID = new Guid("cf8a931b-eaa9-4b0c-8894-53d54e93cba1"),
                    ConversionFactorFromSI = 1.0/10.0
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalCentimetre",
                    UnitLabel = "1/cm",
                    ID = new Guid("4f2c38c2-86ff-4842-afdd-3a9fcf8a623e"),
                    ConversionFactorFromSI = 1.0/100.0
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalMillimetre",
                    UnitLabel = "1/mm",
                    ID = new Guid("2d484d0f-7d29-48e9-8d5b-ff82fca6f1c5"),
                    ConversionFactorFromSI = 1.0/1000.0
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalMicrometre",
                    UnitLabel = "1/µm",
                    ID = new Guid("ddbbb734-ddd2-4d26-84ba-9995fff479e6"),
                    ConversionFactorFromSI = 1.0/1000000.0
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalNanometre",
                    UnitLabel = "1/nm",
                    ID = new Guid("25412abd-9c3e-4b67-b809-d92926eb2b58"),
                    ConversionFactorFromSI = 1.0/1000000000.0
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalÅngstrøm",
                    UnitLabel = "1/Å",
                    ID = new Guid("7c28c943-c084-48f6-804c-87e6c6902b35"),
                    ConversionFactorFromSI = 1.0/10000000000.0
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalPicometre",
                    UnitLabel = "1/pm",
                    ID = new Guid("bca4fde9-e17a-4a27-9a3f-34beab644ee2"),
                    ConversionFactorFromSI = 1.0/1000000000000.0
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalDecametre",
                    UnitLabel = "1/dam",
                    ID = new Guid("a691338d-1916-4355-b6e1-3b1bff086c14"),
                    ConversionFactorFromSI = 1.0/0.1
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalHectometre",
                    UnitLabel = "1/hm",
                    ID = new Guid("4da19df4-0ff6-424b-a2ab-9d5811ba48ca"),
                    ConversionFactorFromSI = 1.0/0.01
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalKilometre",
                    UnitLabel = "1/km",
                    ID = new Guid("a4b4ed8e-a1c6-4e3f-9421-8770cec6ff42"),
                    ConversionFactorFromSI = 1.0/0.001
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalAstronomicalUnit",
                    UnitLabel = "1/au",
                    ID = new Guid("4d58ee46-e637-4f5a-a1ff-33f002154fec"),
                    ConversionFactorFromSI = 1.495978707e11
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalLightYear",
                    UnitLabel = "1/ly",
                    ID = new Guid("81c8c5d9-a892-4702-921b-9946abbef6b0"),
                    ConversionFactorFromSI = 9460730472580800.0
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalParsec",
                    UnitLabel = "1/pc",
                    ID = new Guid("b8f6a954-7fe6-4f31-94cc-e53bb5603cd5"),
                    ConversionFactorFromSI = 30856775814913673.0
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalFeet",
                    UnitLabel = "1/ft",
                    ID = new Guid("1d6a5284-d32f-4f5a-ad27-bfc0f71069aa"),
                    ConversionFactorFromSI = 0.3048
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalUSSurveyFeet",
                    UnitLabel = "1/ft",
                    ID = new Guid("16c3f209-e890-4b35-807e-7115545406e0"),
                    ConversionFactorFromSI = 0.304801
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalInch",
                    UnitLabel = "1/in",
                    ID = new Guid("95cd773d-b6da-4148-bd9c-bed66b4a72d8"),
                    ConversionFactorFromSI = 0.0254
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalYard",
                    UnitLabel = "1/yd",
                    ID = new Guid("be5f64c0-592a-4f3b-b2b5-6df8b9d2a31b"),
                    ConversionFactorFromSI = 0.9144
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalFathom",
                    UnitLabel = "1/fathom",
                    ID = new Guid("ae9e314e-de19-405e-a897-6a68cd4845f6"),
                    ConversionFactorFromSI = 1.8288
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalSurveyorsChain",
                    UnitLabel = "1/chain",
                    ID = new Guid("90da0d97-195c-4c30-85d8-51d70b75f071"),
                    ConversionFactorFromSI = (22.0*0.9144)
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalMile",
                    UnitLabel = "1/mi",
                    ID = new Guid("acbb10a5-602f-423b-bc15-bdfd80cb7008"),
                    ConversionFactorFromSI = 1609.344
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalInternationalNauticalMile",
                    UnitLabel = "1/nmi",
                    ID = new Guid("78474000-3cd8-4102-b7b4-360b4c2130fc"),
                    ConversionFactorFromSI = 1852.0
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalUKNauticalMile",
                    UnitLabel = "1/(UK nmi)",
                    ID = new Guid("8a55784f-b5f4-4aa7-b5f9-d19742857349"),
                    ConversionFactorFromSI = 1853.184
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalScandinavianMile",
                    UnitLabel = "1/mil",
                    ID = new Guid("f766575d-9bfa-45fb-8bfd-50f12a0e6a6a"),
                    ConversionFactorFromSI = 10000.0
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalInch/32",
                    UnitLabel = "1/in/32",
                    ID = new Guid("ac9c8b52-22f0-476d-a038-023695c24f25"),
                    ConversionFactorFromSI = 0.0254/32.0 
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalMil",
                    UnitLabel = "1/mil",
                    ID = new Guid("09d27104-6452-4976-98e0-6fd087e22eb1"),
                    ConversionFactorFromSI = 0.0000254
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalThou",
                    UnitLabel = "1/thou",
                    ID = new Guid("e732fd46-ddf3-433e-8baf-cc531ca69160"),
                    ConversionFactorFromSI = 0.0000254
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalHand",
                    UnitLabel = "1/hand",
                    ID = new Guid("844ed023-9f47-4147-8b50-cf03c99071b5"),
                    ConversionFactorFromSI = 0.1016
                },
                new UnitChoice
                {
                    UnitName = "ReciprocalFurlong",
                    UnitLabel = "1/furlong",
                    ID = new Guid("79a3f3db-0ac8-4bcb-b93c-fca2a673147b"),
                    ConversionFactorFromSI = 201.168
                },
            };
        }
    }
}
