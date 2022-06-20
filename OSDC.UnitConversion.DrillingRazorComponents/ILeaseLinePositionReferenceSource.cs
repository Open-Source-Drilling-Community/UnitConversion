using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSDC.UnitConversion.DrillingRazorComponents
{
    public interface ILeaseLinePositionReferenceSource
    {
        public double? LeaseLineNorthPositionReference { get; set; }
        public double? LeaseLineEastPositionReference { get; set; }
    }
}
