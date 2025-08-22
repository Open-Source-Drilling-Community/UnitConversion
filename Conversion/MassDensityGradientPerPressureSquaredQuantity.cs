using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class MassDensityGradientPerPressureSquaredQuantity : DerivedBasePhysicalQuantity
    {
        public override string TypicalSymbol { get; } = null;
        public override string SIUnitName { get; } = "kilogram per cubic metre per pascal squared";
        public override string SIUnitLabelLatex { get; } = "\\frac{\\frac{kg}{m^{3}}}{Pa^{2}}";
        public override double TimeDimension { get; } = 4;
        public override double MassDimension { get; } = -1;
        public override double LengthDimension { get; } = -1;
        private static MassDensityGradientPerPressureSquaredQuantity instance_ = null;

        public static MassDensityGradientPerPressureSquaredQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new MassDensityGradientPerPressureSquaredQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public static List<UnitChoice> UnitChoiceDescriptions = new List<UnitChoice>()
        {
            new UnitChoice
                {
                    UnitName = "kilogram per cubic metre per pascal squared",
                    UnitLabel = "kg/m³/Pa²",
                    ID = new Guid("f5e08eda-6f5f-480f-b4a1-c678e409c6e0"),
                    ConversionFactorFromSIFormula = "1.0/Factors.Unit",
                    IsSI = true
                },
                new UnitChoice
                {
                    UnitName = "specific gravity per pascal squared",
                    UnitLabel = "sg/Pa²",
                    ID = new Guid("bbf15986-4411-4187-8186-de8da731a6b4"),
                    ConversionFactorFromSIFormula = "Factors.SpecificGavity4degC"
                },
                new UnitChoice
                {
                    UnitName = "gram per cubic centimetre per pascal squared",
                    UnitLabel = "g/cm³/Pa²",
                    ID = new Guid("157c5898-353a-41f1-9924-0d8421cd8154"),
                    ConversionFactorFromSIFormula = "Factors.Centi*Factors.Centi*Factors.Centi/Factors.Milli"
                },
                new UnitChoice
                {
                    UnitName = "pound per gallon (UK) per pascal squared",
                    UnitLabel = "ppgUK/Pa²",
                    ID = new Guid("8930d03e-184e-4bfa-88fa-755f728a3be1"),
                    ConversionFactorFromSIFormula = "Factors.GallonUK/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per gallon (US) per pascal squared",
                    UnitLabel = "ppgUS/Pa²",
                    ID = new Guid("f93f8382-3a4c-454c-9575-c41ed6875656"),
                    ConversionFactorFromSIFormula = "Factors.GallonUS/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic foot per pascal squared",
                    UnitLabel = "lb/ft³/Pa²",
                    ID = new Guid("de70ab66-52d6-4e5a-a0e7-a31c442c213f"),
                    ConversionFactorFromSIFormula = "Factors.Foot*Factors.Foot*Factors.Foot/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic inch per pascal squared",
                    UnitLabel = "lb/in³/Pa²",
                    ID = new Guid("4f2d5894-6dc8-4c52-b442-976b8032e04e"),
                    ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch*Factors.Inch/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic yard per pascal squared",
                    UnitLabel = "lb/yd³/Pa²",
                    ID = new Guid("a22f8465-a519-47f9-80c5-5f633b5a3579"),
                    ConversionFactorFromSIFormula = "Factors.Yard*Factors.Yard*Factors.Yard/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "kilogram per cubic metre per bar squared",
                    UnitLabel = "kg/m³/bar²",
                    ID = new Guid("86d777df-9722-4fb6-861e-025c07589743"),
                    ConversionFactorFromSIFormula = "Factors.Bar*Factors.Bar/Factors.Unit"
                },
                new UnitChoice
                {
                    UnitName = "specific gravity per bar squared",
                    UnitLabel = "sg/bar²",
                    ID = new Guid("28cb683a-d3a8-4757-8123-cf093cb1d560"),
                    ConversionFactorFromSIFormula = "Factors.SpecificGavity4degC*Factors.Bar*Factors.Bar"
                },
                new UnitChoice
                {
                    UnitName = "gram per cubic centimetre per bar squared",
                    UnitLabel = "g/cm³/bar²",
                    ID = new Guid("e8b6cc51-e9f8-4705-b486-20999de7d84a"),
                    ConversionFactorFromSIFormula = "Factors.Centi*Factors.Centi*Factors.Centi*Factors.Bar*Factors.Bar/Factors.Milli"
                },
                new UnitChoice
                {
                    UnitName = "pound per gallon (UK) per bar squared",
                    UnitLabel = "ppgUK/bar²",
                    ID = new Guid("5245397a-58a4-40d1-8ba4-aa4ea9e3d7cd"),
                    ConversionFactorFromSIFormula = "Factors.GallonUK*Factors.Bar*Factors.Bar/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per gallon (US) per bar squared",
                    UnitLabel = "ppgUS/bar²",
                    ID = new Guid("22450e27-b3c7-4a71-9f6e-f979217ca724"),
                    ConversionFactorFromSIFormula = "Factors.GallonUS*Factors.Bar*Factors.Bar/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic foot per bar squared",
                    UnitLabel = "lb/ft³/bar²",
                    ID = new Guid("d2a23cb1-3ec6-416a-9a77-2c6e4f5ccd09"),
                    ConversionFactorFromSIFormula = "Factors.Foot*Factors.Foot*Factors.Foot*Factors.Bar*Factors.Bar/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic inch per bar squared",
                    UnitLabel = "lb/in³/bar²",
                    ID = new Guid("ee8aff8d-f65e-4b09-8e25-5b94d7ad739b"),
                    ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch*Factors.Inch*Factors.Bar*Factors.Bar/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic yard per bar squared",
                    UnitLabel = "lb/yd³/bar²",
                    ID = new Guid("e1b7ea9b-d4ba-442b-99f8-a1eeebd35c1d"),
                    ConversionFactorFromSIFormula = "Factors.Yard*Factors.Yard*Factors.Yard*Factors.Bar*Factors.Bar/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "kilogram per cubic metre per pound per square inch squared",
                    UnitLabel = "kg/m³/psi²",
                    ID = new Guid("ed837c52-b9d2-434e-8103-bb75c60b5dee"),
                    ConversionFactorFromSIFormula = "Factors.PSI*Factors.PSI/Factors.Unit"
                },
                new UnitChoice
                {
                    UnitName = "specific gravity per pound per square inch squared",
                    UnitLabel = "sg/psi²",
                    ID = new Guid("4a1459e4-ccfa-4563-ab43-af1ed407311e"),
                    ConversionFactorFromSIFormula = "Factors.SpecificGavity4degC*Factors.PSI*Factors.PSI"
                },
                new UnitChoice
                {
                    UnitName = "gram per cubic centimetre per pound per square inch squared",
                    UnitLabel = "g/cm³/psi²",
                    ID = new Guid("f29096ad-ad1d-4f6e-9354-b9159600b5e8"),
                    ConversionFactorFromSIFormula = "Factors.Centi*Factors.Centi*Factors.Centi*Factors.PSI*Factors.PSI/Factors.Milli"
                },
                new UnitChoice
                {
                    UnitName = "pound per gallon (UK) per pound per square inch squared",
                    UnitLabel = "ppgUK/psi²",
                    ID = new Guid("41979553-6c36-4f5a-9e62-a6e05bd3c9a2"),
                    ConversionFactorFromSIFormula = "Factors.GallonUK*Factors.PSI*Factors.PSI/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per gallon (US) per pound per square inch squared",
                    UnitLabel = "ppgUS/psi²",
                    ID = new Guid("6f5b0146-ec8e-4224-9cb3-9ab440b6a006"),
                    ConversionFactorFromSIFormula = "Factors.GallonUS*Factors.PSI*Factors.PSI/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic foot per pound per square inch squared",
                    UnitLabel = "lb/ft³/psi²",
                    ID = new Guid("af1a2b8a-b330-402d-9f9d-e30399b24926"),
                    ConversionFactorFromSIFormula = "Factors.Foot*Factors.Foot*Factors.Foot*Factors.PSI*Factors.PSI/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic inch per pound per square inch squared",
                    UnitLabel = "lb/in³/psi²",
                    ID = new Guid("17051250-e815-4170-aa12-c222e89742e1"),
                    ConversionFactorFromSIFormula = "Factors.Inch*Factors.Inch*Factors.Inch*Factors.PSI*Factors.PSI/Factors.Pound"
                },
                new UnitChoice
                {
                    UnitName = "pound per cubic yard per pound per square inch squared",
                    UnitLabel = "lb/yd³/psi²",
                    ID = new Guid("f30510ee-c4bb-434b-a185-3805a543404f"),
                    ConversionFactorFromSIFormula = "Factors.Yard*Factors.Yard*Factors.Yard*Factors.PSI*Factors.PSI/Factors.Pound"
                },
        };
        public MassDensityGradientPerPressureSquaredQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "mass density gradient per pressure squared" };
            ID = new Guid("885ebdc2-2800-462e-93fa-cbaaffd12b6e");
            DescriptionMD = string.Empty;
            DescriptionMD += @"A mass density gradient per pressure squared is the second derivative of a mass density compared to pressure: $\frac{d^{2}\rho}{dp^{2}}$, where $\rho$ is a mass density and $p$ is pressure." + Environment.NewLine;
            DescriptionMD += @"The dimension of mass density gradient per pressure squared is:" + Environment.NewLine;
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