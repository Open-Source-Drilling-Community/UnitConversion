using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class ProjectionScaleFactorQuantity : DimensionlessQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1e-9;
        public override string TypicalSymbol { get; } = "k_0";
        private static ProjectionScaleFactorQuantity instance_ = null;

        public static new ProjectionScaleFactorQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new ProjectionScaleFactorQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public ProjectionScaleFactorQuantity() : base()
        {
            Name = GetType().Name.Split("Quantity").First();
            ID = new Guid("6df5410d-d32a-4d47-89f9-e7c96cf61c74");
            UsualNames = new HashSet<string>() { "projection scale factor", "map projection scale factor", "scale factor at natural origin", "scale factor at projection centre" };
            DescriptionMD += Environment.NewLine + "**Projection scale factor** is the full dimensionless multiplicative scale factor prescribed by a cartographic projection method at its defining origin, line or parallel. Unity means no local scale change. For example, the UTM central-meridian scale factor is 0.9996. The method and parameter identity specify where the factor applies; it is not necessarily the pointwise scale elsewhere in the projected CRS." + Environment.NewLine;
            DescriptionMD += "The meaningful presentation precision is 1e-9, retaining nine decimal places. A scale step of 1e-9 corresponds to 1 mm over a 1,000 km linear extent. This is a display convention, not a claim of projection accuracy or a rounding of calculated or stored values. Numeric unit conversion preserves the supplied value." + Environment.NewLine;
            DescriptionMD += "This is a complete factor k, not the Helmert scale difference s in (1 + s), an inverse flattening, an image resolution, or a source-unit-to-metre conversion coefficient. Do not interpret a ppm scale increment as the complete factor: a relative increment of 2 ppm corresponds to k = 1.000002, not 0.000002." + Environment.NewLine;
            DescriptionMD += "SI, Metric, US and Imperial use the same dimensionless unit with the symbolic identity conversion inherited from DimensionlessQuantity (1.0/Factors.Unit). No percent or ppm unit choice is exposed. Parameter validity, including positivity where required, is enforced by the consuming projection method rather than by unit conversion. See [PROJ Transverse Mercator](https://proj.org/en/stable/operations/projections/tmerc.html) for the k_0 convention." + Environment.NewLine;
            Reset();
            UnitChoices.Add(DimensionlessQuantity.Instance.GetUnitChoice(DimensionlessQuantity.UnitChoicesEnum.Dimensionless));
            SemanticExample = GetSemanticExample();
        }
    }
}
