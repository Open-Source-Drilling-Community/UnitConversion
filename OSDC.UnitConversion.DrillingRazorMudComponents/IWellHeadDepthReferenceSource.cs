﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSDC.UnitConversion.DrillingRazorMudComponents
{
    public interface IWellHeadDepthReferenceSource
    {
        public double? WellHeadDepthReference { get; set; }
    }
}
