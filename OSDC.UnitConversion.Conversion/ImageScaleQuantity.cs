﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class ImageScaleQuantity : DerivedPhysicalQuantity, IEngineeringQuantity
    {
        public override string SIUnitName { get; } = "dot per meter";
        public override string SIUnitSymbol { get; } = "dpm";
        public double? MeaningFullPrecisionInSI { get; } = 0.001;

        public override double LengthDimension { get; } = -1;

        private static ImageScaleQuantity instance_ = null;

        public static ImageScaleQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new ImageScaleQuantity();
                }
                return instance_;
            }
        }

        protected ImageScaleQuantity() : base()
        {
            Name = "Image Scale";
            ID = new Guid("a3f230b0-a70b-40dd-9305-39e63bb1821b");
            Reset();
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = SIUnitName,
                UnitSymbol = SIUnitSymbol,
                ID = new Guid("acc723b8-083c-49f3-a208-184d2da3347d"),
                ConversionFactorFromSI = 1.0,
                IsSI = true
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "dot per inch",
                UnitSymbol = "dpi",
                ID = new Guid("e042b571-b7d0-477d-abf6-8b8998e5ba6c"),
                ConversionFactorFromSI = 1.0 / 39.37007874
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "dot per millimeter",
                UnitSymbol = "dpmm",
                ID = new Guid("6d4d5f26-8812-4002-a2bf-27ec7871c1f4"),
                ConversionFactorFromSI = 1.0 / 1000.0
            });
            this.UnitChoices.Add(new UnitChoice
            {
                UnitName = "dot per micrometer",
                UnitSymbol = "dpµm",
                ID = new Guid("76e21d1d-54f5-4bbb-81c6-1b92b8b30bfe"),
                ConversionFactorFromSI = 1.0 / 1000000.0
            });

            PostProcess();
        }

    }
}
