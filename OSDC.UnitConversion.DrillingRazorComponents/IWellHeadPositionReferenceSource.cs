using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSDC.UnitConversion.DrillingRazorComponents
{
    public interface IWellHeadPositionReferenceSource
    {
        public double? WellHeadNorthPositionReference { get; set; }
        public double? WellHeadEastPositionReference { get; set; }
    }
}
