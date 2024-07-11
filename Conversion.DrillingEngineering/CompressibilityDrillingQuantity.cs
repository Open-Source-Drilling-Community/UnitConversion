﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class CompressibilityDrillingQuantity : CompressibilityQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1E-13;

        private static CompressibilityDrillingQuantity instance_ = null;

        public static new CompressibilityDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new CompressibilityDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public CompressibilityDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Compressibility (drilling)" };
            ID = new Guid("bfec67e2-839f-47d7-968c-69287567835d");
            Reset();
            this.UnitChoices.Add(CompressibilityQuantity.Instance.GetUnitChoice(CompressibilityQuantity.UnitChoicesEnum.InverseBar));
            this.UnitChoices.Add(CompressibilityQuantity.Instance.GetUnitChoice(CompressibilityQuantity.UnitChoicesEnum.InversePascal));
            this.UnitChoices.Add(CompressibilityQuantity.Instance.GetUnitChoice(CompressibilityQuantity.UnitChoicesEnum.InversePoundPerSquareInch));
        }

    }
}
