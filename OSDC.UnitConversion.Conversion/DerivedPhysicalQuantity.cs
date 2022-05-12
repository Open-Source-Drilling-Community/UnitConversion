using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public abstract class DerivedPhysicalQuantity : PhysicalQuantity
    {
        /// <summary>
        /// the symbol used for this base unit in physical quantity descriptions: L, T, M, ...
        /// </summary>
        public virtual string TypicalSymbol { get; } = null;
    }
}
