using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public interface IEngineeringQuantity
    {
        /// <summary>
        /// the smallest absolute value of the quantity that makes any sense with regards to its usage
        /// ex: drilling depth 0.001m, pipe diameter 0.0001m
        /// </summary>
        double? MeaningFullPrecisionInSI { get; }

    }
}
