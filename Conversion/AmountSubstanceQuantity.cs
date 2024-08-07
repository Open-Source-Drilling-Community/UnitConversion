﻿using Conversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class AmountSubstanceQuantity : SymbolizedBasePhysicalQuantity
    {
        public override string DimensionSymbol { get; } = "N";
        public override string SIUnitName { get; } = "mole";

        public override string SIUnitLabel { get; } = "mol";
        public override double AmountSubstanceDimension { get; } = 1;

        private static AmountSubstanceQuantity instance_ = null;

        public static AmountSubstanceQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new AmountSubstanceQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public AmountSubstanceQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Amount Substance" };
            ID = new Guid("200be1eb-c278-447c-9b15-32d20fc778b9");
            UnitChoices = new List<UnitChoice>()
            {
                new UnitChoice
                {
                    UnitName = SIUnitName,
                    UnitLabel = SIUnitLabel,
                    ID = new Guid("d1072bb3-265e-400a-91b2-9c49616dc3de"),
                    ConversionFactorFromSI = Factors.Unit,
                    IsSI = true
                },
                new UnitChoice
                {
                    UnitName = "decimole",
                    UnitLabel ="dmol",
                    ID = new Guid("b458e56b-edc3-48c3-8858-75d507f1f1f2"),
                    ConversionFactorFromSI = 1.0/Factors.Deci
                },
                new UnitChoice
                {
                    UnitName = "centimole",
                    UnitLabel ="cmol",
                    ID = new Guid("4d83c0db-ddc4-4087-ae50-076148976cad"),
                    ConversionFactorFromSI = 1.0/Factors.Centi
                },
                new UnitChoice
                {
                    UnitName = "millimole",
                    UnitLabel ="mmol",
                    ID = new Guid("0a83a1b6-cef4-4899-bcd4-4aa1e10d232a"),
                    ConversionFactorFromSI = 1.0/Factors.Milli
                },
                new UnitChoice
                {
                    UnitName = "micromole",
                    UnitLabel ="µmol",
                    ID = new Guid("ec2669ad-9742-4667-8a14-76e00c47a41e"),
                    ConversionFactorFromSI = 1.0/Factors.Micro
                },
                new UnitChoice
                {
                    UnitName = "nanomole",
                    UnitLabel ="nmol",
                    ID = new Guid("dc8d0034-ecfa-4dbf-a24c-f1851c4aaf9c"),
                    ConversionFactorFromSI = 1.0/Factors.Nano
                },
                new UnitChoice
                {
                    UnitName = "picomole",
                    UnitLabel ="pmol",
                    ID = new Guid("642555ea-37f0-49b9-9f21-8dd616d477c4"),
                    ConversionFactorFromSI = 1.0/Factors.Pico
                },
                new UnitChoice
                {
                    UnitName = "kilomole",
                    UnitLabel ="kmol",
                    ID = new Guid("01157606-070e-41a2-8c78-84a7ae950bd6"),
                    ConversionFactorFromSI = 1.0/Factors.Kilo
                }
            };
        }
    }

}
