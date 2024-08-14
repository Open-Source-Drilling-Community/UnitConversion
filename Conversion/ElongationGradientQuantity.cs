using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class ElongationGradientQuantity : DerivedBasePhysicalQuantity
    {
        public override string SIUnitName { get; } = "metre per metre";
        public override string SIUnitLabel { get; } = "m/m";

        private static ElongationGradientQuantity instance_ = null;

        public static ElongationGradientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new ElongationGradientQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public ElongationGradientQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Elongation Gradient" };
            ID = new Guid("3c6176f8-8f74-4fbf-bb65-207ed8b0a120");
            Reset();
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = SIUnitName,
                UnitLabel = SIUnitLabel,
                ID = new Guid("cc12967b-4c7d-4c70-95cf-d2f23bd6f76b"),
                ConversionFactorFromSI = 1.0,
                IsSI = true
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "decimetre per metre",
                UnitLabel = "dm/m",
                ID = new Guid("337d67e2-b28c-4ab8-9817-3f9951fdb67b"),
                ConversionFactorFromSI = 1.0 / Factors.Deci
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "centimetre per metre",
                UnitLabel = "cm/m",
                ID = new Guid("4a7ce144-b35f-401f-bfbc-276b7c4ec4a9"),
                ConversionFactorFromSI = 1.0 / Factors.Centi
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "millimetre per metre",
                UnitLabel = "mm/m",
                ID = new Guid("4e241b59-388a-428f-82e7-b9971f9e1df5"),
                ConversionFactorFromSI = 1.0/Factors.Milli
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "micrometre per metre",
                UnitLabel = "µm/m",
                ID = new Guid("bbd912b2-06e2-46fe-82da-af87bab150dc"),
                ConversionFactorFromSI = 1.0 / Factors.Micro
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "metre per kilometre",
                UnitLabel = "m/km",
                ID = new Guid("5b583a4c-7838-48e7-8201-420f43eef9e1"),
                ConversionFactorFromSI = Factors.Kilo/Factors.Unit,
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "decimetre per kilometre",
                UnitLabel = "dm/km",
                ID = new Guid("7dc93254-9a25-4215-b2bc-9f2d8dc14d6e"),
                ConversionFactorFromSI = Factors.Kilo / Factors.Deci
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "centimetre per kilometre",
                UnitLabel = "cm/km",
                ID = new Guid("f539c676-e969-4235-9524-42e860e84966"),
                ConversionFactorFromSI = Factors.Kilo / Factors.Centi
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "millimetre per kilometre",
                UnitLabel = "mm/km",
                ID = new Guid("59f50e71-7796-4559-9e55-7fc420d9c20c"),
                ConversionFactorFromSI = Factors.Kilo / Factors.Milli
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "micrometre per kilometre",
                UnitLabel = "µm/km",
                ID = new Guid("73d8d799-d9f5-40f9-9216-4bc0bbf1c044"),
                ConversionFactorFromSI = Factors.Kilo / Factors.Micro
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "inch per foot",
                UnitLabel = "in/ft",
                ID = new Guid("3df1af23-afd0-41ed-9442-a3af6ae944d2"),
                ConversionFactorFromSI = Factors.Foot / Factors.Inch
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "inch per yard",
                UnitLabel = "in/yd",
                ID = new Guid("ec1fbeee-cbf4-41f0-94d8-573e241c22b2"),
                ConversionFactorFromSI = Factors.Yard / Factors.Inch
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "inch per mile",
                UnitLabel = "in/mi",
                ID = new Guid("998afd92-de3a-4f10-90b6-a252b8e59181"),
                ConversionFactorFromSI = Factors.Mile / Factors.Inch
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "foot per foot",
                UnitLabel = "ft/ft",
                ID = new Guid("a53ffdb6-a2db-4984-85aa-53763ba3aabb"),
                ConversionFactorFromSI = Factors.Foot / Factors.Foot
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "foot per yard",
                UnitLabel = "ft/yd",
                ID = new Guid("ba9062f9-68be-4b9c-ba61-57c8543ed6f9"),
                ConversionFactorFromSI = Factors.Yard / Factors.Foot
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "foot per mile",
                UnitLabel = "ft/mi",
                ID = new Guid("89b73d98-2818-43c5-8d31-8aa1bb78d3bc"),
                ConversionFactorFromSI = Factors.Mile / Factors.Foot
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "yard per foot",
                UnitLabel = "yd/ft",
                ID = new Guid("a6c2cf06-e21a-4387-90db-89d7d46b1b28"),
                ConversionFactorFromSI = Factors.Foot / Factors.Yard
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "yard per yard",
                UnitLabel = "yd/yd",
                ID = new Guid("56f75af0-7213-43d9-b23f-bc74da6382e9"),
                ConversionFactorFromSI = Factors.Yard / Factors.Yard
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "yard per mile",
                UnitLabel = "yd/mi",
                ID = new Guid("3283a57e-ec6d-4487-ab32-cdc0c5de2020"),
                ConversionFactorFromSI = Factors.Mile / Factors.Yard
            });
        }
    }
}
