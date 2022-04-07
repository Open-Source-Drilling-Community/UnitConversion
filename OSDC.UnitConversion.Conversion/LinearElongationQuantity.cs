using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class LinearElongationQuantity : DerivedPhysicalQuanity
    {
        public override string SIUnitName { get; } = "meter per meter";
        public override string SIUnitSymbol { get; } = "m/m";
        public override double? MeaningFullPrecisionInSI { get; } = 0.00001;

        private static LinearElongationQuantity instance_ = null;

        public static LinearElongationQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new LinearElongationQuantity();
                }
                return instance_;
            }
        }

        protected LinearElongationQuantity() : base()
        {
            Name = "Linear Elongation";
            ID = new Guid("3c6176f8-8f74-4fbf-bb65-207ed8b0a120");
            Reset();
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = SIUnitName,
                UnitSymbol = SIUnitSymbol,
                ID = new Guid("cc12967b-4c7d-4c70-95cf-d2f23bd6f76b"),
                ConversionFactorFromSI = 1.0,
                IsSI = true
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "millimeter per meter",
                UnitSymbol = "mm/m",
                ID = new Guid("4e241b59-388a-428f-82e7-b9971f9e1df5"),
                ConversionFactorFromSI = 1000.0,
                IsMetric = true
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "inch per foot",
                UnitSymbol = "in/ft",
                ID = new Guid("3df1af23-afd0-41ed-9442-a3af6ae944d2"),
                ConversionFactorFromSI = 39.37008 / 3.28084,
                IsImperial = true,
                IsUS = true
            });
            PostProcess();
        }
    }
}
