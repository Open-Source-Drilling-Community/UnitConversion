using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSDC.UnitConversion.DrillingRazorComponents
{
    public interface IGroundMudLineDepthReferenceSource
    {
        public double? GroundMudLineDepthReference { get; set; }
    }
}
