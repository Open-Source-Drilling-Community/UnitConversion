using Conversion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class EnergyDensityQuantity : DerivedBasePhysicalQuantity
    {
        public override string SIUnitName { get; } = "joule per cubic metre";
        public override string SIUnitLabel { get; } = "J/m³";
        public override double LengthDimension { get; } = -1;
        public override double MassDimension { get; } = 1;
        public override double TimeDimension { get; } = -2;
        private static EnergyDensityQuantity instance_ = null;

        public static EnergyDensityQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new EnergyDensityQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }
        public EnergyDensityQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Energy Density" };
            ID = new Guid("9e82436a-392e-428a-8ee9-0998027c3c46");
            UnitChoices = new List<UnitChoice>()
      {
        new UnitChoice
        {
          UnitName = SIUnitName,
          UnitLabel = SIUnitLabel,
          ID = new Guid("bac0aae1-8b3b-403d-b1ea-874a74da849a"),
          ConversionFactorFromSI = 1.0/Factors.Unit,
          IsSI = true
        },
        new UnitChoice
        {
          UnitName = "kilojoule per cubic metre",
          UnitLabel = "kJ/m³",
          ID = new Guid("ebc0ab24-af1b-4315-a41e-c66ef83e02f0"),
          ConversionFactorFromSI = 1.0/Factors.Kilo
        },
        new UnitChoice
        {
          UnitName = "megajoule per cubic metre",
          UnitLabel = "MJ/m³",
          ID = new Guid("a5d1096b-9900-46ff-8a81-17313266dfdd"),
          ConversionFactorFromSI = 1.0/Factors.Mega
        },
        new UnitChoice
        {
          UnitName = "gigajoule per cubic metre",
          UnitLabel = "GJ/m³",
          ID = new Guid("7728780b-66c7-4832-b905-25cb4e0b3edf"),
          ConversionFactorFromSI = 1.0/Factors.Giga
        },
        new UnitChoice
        {
          UnitName = "calorie per cubic metre",
          UnitLabel = "cal/m³",
          ID = new Guid("ea4ac69b-351f-43d6-b6f0-847e6a73a069"),
          ConversionFactorFromSI = 1.0/Factors.Calorie
        },
        new UnitChoice
        {
          UnitName = "kilocalorie per cubic metre",
          UnitLabel = "Cal/m³",
          ID = new Guid("b8d2b560-8541-4ad0-bb63-e2f755e92cb3"),
          ConversionFactorFromSI = 1.0 / (Factors.Kilo * Factors.Calorie)
        },
        new UnitChoice
        {
          UnitName = "joule per cubic foot",
          UnitLabel = "J/ft³",
          ID = new Guid("5c91efe6-c268-4d31-bff8-768344290db6"),
          ConversionFactorFromSI = Factors.Foot * Factors.Foot * Factors.Foot / Factors.Unit
        },
        new UnitChoice
        {
          UnitName = "kilojoule per cubic foot",
          UnitLabel = "kJ/ft³",
          ID = new Guid("2b21249b-3eb3-4f86-9d05-407e42d8d1c5"),
          ConversionFactorFromSI = Factors.Foot * Factors.Foot * Factors.Foot / Factors.Kilo
        },
        new UnitChoice
        {
          UnitName = "megajoule per cubic foot",
          UnitLabel = "MJ/ft³",
          ID = new Guid("6bf78807-e679-4930-9e73-e52968821d9b"),
          ConversionFactorFromSI = Factors.Foot * Factors.Foot * Factors.Foot / Factors.Mega
        },
        new UnitChoice
        {
          UnitName = "gigajoule per cubic foot",
          UnitLabel = "GJ/ft³",
          ID = new Guid("97e4a46b-11f6-4cb5-a24f-f2b004ad06cd"),
          ConversionFactorFromSI = Factors.Foot * Factors.Foot * Factors.Foot / Factors.Giga
        },
        new UnitChoice
        {
          UnitName = "calorie per cubic foot",
          UnitLabel = "cal/ft³",
          ID = new Guid("3efcbcd4-9f17-476d-9a47-43600ab93236"),
          ConversionFactorFromSI = Factors.Foot * Factors.Foot * Factors.Foot / Factors.Calorie
        },
        new UnitChoice
        {
          UnitName = "kilocalorie per cubic foot",
          UnitLabel = "Cal/ft³",
          ID = new Guid("ff0ebc90-50fa-4c50-8583-0879a5b2380c"),
          ConversionFactorFromSI = Factors.Foot * Factors.Foot * Factors.Foot / (Factors.Kilo * Factors.Calorie)
        },
        new UnitChoice
        {
          UnitName = "joule per cubic inch",
          UnitLabel = "J/in³",
          ID = new Guid("daba8c83-b6f5-40bb-8c9d-e476e5d1bce2"),
          ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch/Factors.Unit
        },
        new UnitChoice
        {
          UnitName = "kilojoule per cubic inch",
          UnitLabel = "kJ/in³",
          ID = new Guid("5beeb10a-314a-4c15-858d-0e900d4803e1"),
          ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch/Factors.Kilo
        },
        new UnitChoice
        {
          UnitName = "megajoule per cubic inch",
          UnitLabel = "MJ/in³",
          ID = new Guid("309da835-8bcb-4bdf-bbd7-aad194ade23a"),
          ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch/Factors.Mega
        },
        new UnitChoice
        {
          UnitName = "gigajoule per cubic inch",
          UnitLabel = "GJ/in³",
          ID = new Guid("698b690d-b747-48da-8433-5ac0b25598d3"),
          ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch/Factors.Giga
        },
        new UnitChoice
        {
          UnitName = "calorie per cubic inch",
          UnitLabel = "cal/in³",
          ID = new Guid("6ae5cf98-0fcc-4426-9c72-481d1b1992ce"),
          ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch/Factors.Calorie
        },
        new UnitChoice
        {
          UnitName = "kilocalorie per cubic inch",
          UnitLabel = "Cal/in³",
          ID = new Guid("66375de4-842e-4813-b79e-3e62cf7a97cc"),
          ConversionFactorFromSI = Factors.Inch*Factors.Inch*Factors.Inch/(Factors.Kilo * Factors.Calorie)
        },
        new UnitChoice
        {
          UnitName = "joule per gallon (UK)",
          UnitLabel = "J/gal(UK)",
          ID = new Guid("1c3b4a46-1cfa-44e4-b10e-4ed0f74e2994"),
          ConversionFactorFromSI = Factors.GallonUK / Factors.Unit
        },
        new UnitChoice
        {
          UnitName = "kilojoule per gallon (UK)",
          UnitLabel = "kJ/gal(UK)",
          ID = new Guid("a5086581-3c86-43f5-acd2-845bc35ebc33"),
          ConversionFactorFromSI = Factors.GallonUK / Factors.Kilo
        },
        new UnitChoice
        {
          UnitName = "megajoule per gallon (UK)",
          UnitLabel = "MJ/gal(UK)",
          ID = new Guid("45c985ee-25be-4bd6-88de-38c98f042dbe"),
          ConversionFactorFromSI = Factors.GallonUK / Factors.Mega
        },
        new UnitChoice
        {
          UnitName = "gigajoule per gallon (UK)",
          UnitLabel = "GJ/gal(UK)",
          ID = new Guid("e09aff93-785e-4bae-b9c5-17961bfd6642"),
          ConversionFactorFromSI = Factors.GallonUK / Factors.Giga
        },
        new UnitChoice
        {
          UnitName = "calorie per gallon (UK)",
          UnitLabel = "cal/gal(UK)",
          ID = new Guid("c36ef596-5a06-4ace-a119-baae9f761e29"),
          ConversionFactorFromSI = Factors.GallonUK / Factors.Calorie
        },
        new UnitChoice
        {
          UnitName = "kilocalorie per gallon (UK)",
          UnitLabel = "Cal/gal(UK)",
          ID = new Guid("92c90ba8-7b15-4f6c-980f-f1ca44fb556a"),
          ConversionFactorFromSI = Factors.GallonUK / (Factors.Kilo * Factors.Calorie)
        },
        new UnitChoice
        {
          UnitName = "joule per gallon (US)",
          UnitLabel = "J/gal(US)",
          ID = new Guid("357a5df6-6df1-43fa-8be8-652e8d97db7c"),
          ConversionFactorFromSI = Factors.GallonUS / Factors.Unit
        },
        new UnitChoice
        {
          UnitName = "kilojoule per gallon (US)",
          UnitLabel = "kJ/gal(US)",
          ID = new Guid("5d74db73-4d3f-49b8-9a6b-c8eef3b9e287"),
          ConversionFactorFromSI = Factors.GallonUS / Factors.Kilo
        },
        new UnitChoice
        {
          UnitName = "megajoule per gallon (US)",
          UnitLabel = "MJ/gal(US)",
          ID = new Guid("38d388bf-bbb8-4c84-9ec8-e78c6d81ae07"),
          ConversionFactorFromSI = Factors.GallonUS / Factors.Mega
        },
        new UnitChoice
        {
          UnitName = "gigajoule per gallon (US)",
          UnitLabel = "GJ/gal(US)",
          ID = new Guid("b3360ab2-cd97-4e2f-b29d-1470c0b34c1f"),
          ConversionFactorFromSI = Factors.GallonUS / Factors.Giga
        },
        new UnitChoice
        {
          UnitName = "calorie per gallon (US)",
          UnitLabel = "cal/gal(US)",
          ID = new Guid("30d202d9-0a80-4d71-b4c8-e434d714ee9a"),
          ConversionFactorFromSI = Factors.GallonUS / Factors.Calorie
        },
        new UnitChoice
        {
          UnitName = "kilocalorie per gallon (US)",
          UnitLabel = "Cal/gal(US)",
          ID = new Guid("05fa77bf-3dcb-4df0-bf4d-7394e9f8854d"),
          ConversionFactorFromSI = Factors.GallonUS / (Factors.Kilo * Factors.Calorie)
        }
      };
        }
    }
}
