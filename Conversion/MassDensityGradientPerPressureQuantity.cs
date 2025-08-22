using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class MassDensityGradientPerPressureQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "kilogram per cubic metre per pascal";
        public override string SIUnitLabelLatex { get; } = "\\frac{\\frac{kg}{m^{3}}}{Pa}";
        public override double TimeDimension { get; } = 2;
        public override double LengthDimension { get; } = -2;
        private static MassDensityGradientPerPressureQuantity instance_ = null;

        public static MassDensityGradientPerPressureQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new MassDensityGradientPerPressureQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public static List<UnitChoice> UnitChoiceDescriptions = new List<UnitChoice>()
        {
            new UnitChoice
                {
                    UnitName = "kilogram per cubic metre per pascal",
                    UnitLabel = "kg/m³/Pa",
                    ID = new Guid("48acbe7c-5fd3-4eaf-9667-adfbfda6c930"),
                    ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                    IsSI = true
                },
                new UnitChoice
                {
                    UnitName = "specific gravity per pascal",
                    UnitLabel = "sg/Pa",
                    ID = new Guid("619534ee-a9f5-4420-85ab-dfa218972250"),
                    ConversionFactorFromSIFormula = "Factors.SpecificGavity4degC"
                },
                new UnitChoice
                {
                    UnitName = "gram per cubic centimetre per pascal",
                    UnitLabel = "g/cm³/Pa",
                    ID = new Guid("367f7fe4-b546-4963-accd-38043698916b"),
                    ConversionFactorFromSIFormula = "Factors.Centi*Factors.Centi*Factors.Centi/Factors.Milli"
                },
                new UnitChoice
                {
                    UnitName = "pound per gallon (UK) per pascal",
                    UnitLabel = "ppgUK/Pa",
                    ID = new Guid("1dafde6f-b7f4-450c-bf9f-4d9063c53df5"),
                    ConversionFactorFromSIFormula = "Factors.GallonUK/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per gallon (US) per pascal",
                    UnitLabel = "ppgUS/Pa",
                    ID = new Guid("0cb13b7b-d967-41ac-8d55-9dbd9c8a9004"),
                    ConversionFactorFromSIFormula = "Factors.GallonUS/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic foot per pascal",
                    UnitLabel = "lb/ft³/Pa",
                    ID = new Guid("828a496b-d5be-42e2-8551-e49cd53b91e7"),
                    ConversionFactorFromSIFormula = "Factors.Foot*Factors.Foot*Factors.Foot/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic inch per pascal",
                    UnitLabel = "lb/in³/Pa",
                    ID = new Guid("c8733719-56e5-4db2-a601-09e68bafdc18"),
                    ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch*Factors.Inch/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic yard per pascal",
                    UnitLabel = "lb/yd³/Pa",
                    ID = new Guid("4fc7d357-c230-4302-922f-05dc98c20953"),
                    ConversionFactorFromSIFormula = "Factors.Yard*Factors.Yard*Factors.Yard/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "kilogram per cubic metre per bar",
                    UnitLabel = "kg/m³/bar",
                    ID = new Guid("af23c11a-14cc-42f0-9693-dd8590db64a3"),
                    ConversionFactorFromSIFormula = "Factors.Bar/Factors.Unit"
                },
                new UnitChoice
                {
                    UnitName = "specific gravity per bar",
                    UnitLabel = "sg/bar",
                    ID = new Guid("c30e40c2-7fa4-47bd-8d62-4e8a33ef660c"),
                    ConversionFactorFromSIFormula = "Factors.SpecificGavity4degC*Factors.Bar"
                },
                new UnitChoice
                {
                    UnitName = "gram per cubic centimetre per bar",
                    UnitLabel = "g/cm³/bar",
                    ID = new Guid("b49fd006-16ed-404f-afac-a78bd69c210d"),
                    ConversionFactorFromSIFormula = "Factors.Centi*Factors.Centi*Factors.Centi*Factors.Bar/Factors.Milli"
                },
                new UnitChoice
                {
                    UnitName = "pound per gallon (UK) per bar",
                    UnitLabel = "ppgUK/bar",
                    ID = new Guid("0c7f7c23-6eee-4201-be51-3598b09f0ade"),
                    ConversionFactorFromSIFormula = "Factors.GallonUK*Factors.Bar/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per gallon (US) per bar",
                    UnitLabel = "ppgUS/bar",
                    ID = new Guid("4810318e-813c-4671-92da-edfe64adc62a"),
                    ConversionFactorFromSIFormula = "Factors.GallonUS*Factors.Bar/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic foot per bar",
                    UnitLabel = "lb/ft³/bar",
                    ID = new Guid("0e0ba903-3d8c-4bdd-82bc-0b4d9a79169d"),
                    ConversionFactorFromSIFormula = "Factors.Foot*Factors.Foot*Factors.Foot*Factors.Bar/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic inch per bar",
                    UnitLabel = "lb/in³/bar",
                    ID = new Guid("4691ad34-b973-4f74-aae4-89c0af618805"),
                    ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch*Factors.Inch*Factors.Bar/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic yard per bar",
                    UnitLabel = "lb/yd³/bar",
                    ID = new Guid("bfef9341-2dfe-4567-9826-8388839e8bc2"),
                    ConversionFactorFromSIFormula = "Factors.Yard*Factors.Yard*Factors.Yard*Factors.Bar/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "kilogram per cubic metre per pound per square inch",
                    UnitLabel = "kg/m³/psi",
                    ID = new Guid("243a8789-24ba-407c-956a-7665b9ea5012"),
                    ConversionFactorFromSIFormula = "Factors.PSI/Factors.Unit"
                },
                new UnitChoice
                {
                    UnitName = "specific gravity per pound per square inch",
                    UnitLabel = "sg/psi",
                    ID = new Guid("1e56b53b-92a2-4dbc-87cf-143650a30895"),
                    ConversionFactorFromSIFormula = "Factors.SpecificGavity4degC*Factors.PSI"
                },
                new UnitChoice
                {
                    UnitName = "gram per cubic centimetre per pound per square inch",
                    UnitLabel = "g/cm³/psi",
                    ID = new Guid("11a4f910-3071-4e9a-ac07-e7d106c52fd9"),
                    ConversionFactorFromSIFormula = "Factors.Centi*Factors.Centi*Factors.Centi*Factors.PSI/Factors.Milli"
                },
                new UnitChoice
                {
                    UnitName = "pound per gallon (UK) per pound per square inch",
                    UnitLabel = "ppgUK/psi",
                    ID = new Guid("67712637-814b-4a0e-a858-c6b8bd864fc1"),
                    ConversionFactorFromSIFormula = "Factors.GallonUK*Factors.PSI/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per gallon (US) per pound per square inch",
                    UnitLabel = "ppgUS/psi",
                    ID = new Guid("6234aef5-1534-47fa-b96b-4d0905832217"),
                    ConversionFactorFromSIFormula = "Factors.GallonUS*Factors.PSI/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic foot per pound per square inch",
                    UnitLabel = "lb/ft³/psi",
                    ID = new Guid("c1d08a1b-9832-4d68-b47b-b113b8d06bf0"),
                    ConversionFactorFromSIFormula = "Factors.Foot*Factors.Foot*Factors.Foot*Factors.PSI/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic inch per pound per square inch",
                    UnitLabel = "lb/in³/psi",
                    ID = new Guid("28fc5b3b-c94d-4afc-995f-6680dc3125f7"),
                    ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch*Factors.Inch*Factors.PSI/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic yard per pound per square inch",
                    UnitLabel = "lb/yd³/psi",
                    ID = new Guid("3e04b954-9156-405e-a058-16541687ee43"),
                    ConversionFactorFromSIFormula = "Factors.Yard*Factors.Yard*Factors.Yard*Factors.PSI/Factors.Pound"
                },
        };
        public MassDensityGradientPerPressureQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "mass density gradient per pressure" };
            ID = new Guid("54da476c-5a35-4274-93bf-1a2d8eede435");
            DescriptionMD = string.Empty;
            DescriptionMD += @"A mass density gradient per pressure is the first derivative of a mass density compared to pressure: $\frac{d\rho}{dp}$, where $\rho$ is a mass density and $p$ is pressure." + Environment.NewLine;
            DescriptionMD += @"The dimension of mass density gradient per pressure is:" + Environment.NewLine;
            DescriptionMD += "$" + GetDimensionsEnclosed() + "$." + Environment.NewLine;
            if (!string.IsNullOrEmpty(SIUnitLabelLatex) && !string.IsNullOrEmpty(SIUnitName) && UsualNames != null && UsualNames.Count > 0)
            {
                DescriptionMD += Environment.NewLine;
                DescriptionMD += @"The SI unit for **" + UsualNames.First() + "** is: " + SIUnitName + " with the associated unit label $" + SIUnitLabelLatex + "$" + Environment.NewLine;
            }
            InitializeUnitChoices();
            SemanticExample = GetSemanticExample();
        }
    }
}