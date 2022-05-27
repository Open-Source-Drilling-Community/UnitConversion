using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class ElongationGradientQuantity : DerivedPhysicalQuantity
    {
        public override string SIUnitName { get; } = "MeterPerMeter";
        public override string SIUnitLabel { get; } = "m/m";

        private static ElongationGradientQuantity instance_ = null;

        public static ElongationGradientQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new ElongationGradientQuantity();
                }
                return instance_;
            }
        }

        protected ElongationGradientQuantity() : base()
        {
            Name = "ElongationGradient";
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
                UnitName = "millimeter per meter",
                UnitLabel = "mm/m",
                ID = new Guid("4e241b59-388a-428f-82e7-b9971f9e1df5"),
                ConversionFactorFromSI = 1000.0
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "inch per foot",
                UnitLabel = "in/ft",
                ID = new Guid("3df1af23-afd0-41ed-9442-a3af6ae944d2"),
                ConversionFactorFromSI = 39.37008 / 3.28084
            });
            PostProcess();
        }
    }
}
