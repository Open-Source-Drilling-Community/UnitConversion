﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class VolumetricFlowRateOfChangeDrillingQuantity : VolumetricFlowRateOfChangeQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1E-06;

        private static VolumetricFlowRateOfChangeDrillingQuantity instance_ = null;

        public static new VolumetricFlowRateOfChangeDrillingQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new VolumetricFlowRateOfChangeDrillingQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public VolumetricFlowRateOfChangeDrillingQuantity() : base()
        {
            Name = this.GetType().Name.Split("Quantity").ElementAt(0);
            UsualNames = new HashSet<string>() { "Volumetric Flow Rate Of Change (drilling)" };
            ID = new Guid("244ade8c-591d-44d4-bca6-3798046d90a1");
            Reset();
            this.UnitChoices.Add(VolumetricFlowRateOfChangeQuantity.Instance.GetUnitChoice(VolumetricFlowRateOfChangeQuantity.UnitChoicesEnum.CubicMetrePerSecondSquare));
            this.UnitChoices.Add(VolumetricFlowRateOfChangeQuantity.Instance.GetUnitChoice(VolumetricFlowRateOfChangeQuantity.UnitChoicesEnum.LiterPerMinutePerSecond));
            this.UnitChoices.Add(VolumetricFlowRateOfChangeQuantity.Instance.GetUnitChoice(VolumetricFlowRateOfChangeQuantity.UnitChoicesEnum.UKGallonPerMinutePerSecond));
            this.UnitChoices.Add(VolumetricFlowRateOfChangeQuantity.Instance.GetUnitChoice(VolumetricFlowRateOfChangeQuantity.UnitChoicesEnum.USGallonPerMinutePerSecond));
        }

    }
}
