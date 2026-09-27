using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class HelmertScaleDifferenceQuantity : DimensionlessQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1e-12;
        public override string TypicalSymbol { get; } = "s";
        private static HelmertScaleDifferenceQuantity instance_ = null;

        public static new HelmertScaleDifferenceQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new HelmertScaleDifferenceQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public HelmertScaleDifferenceQuantity() : base()
        {
            Name = GetType().Name.Split("Quantity").First();
            ID = new Guid("f81f6f40-0910-47e0-9769-56d8542d61e9");
            UsualNames = new HashSet<string>() { "Helmert scale difference", "Helmert scale increment", "geodetic scale difference" };
            DescriptionMD += Environment.NewLine + "**Helmert scale difference** is the signed dimensionless increment s in the multiplicative scale factor (1 + s) of a Helmert coordinate transformation. Zero means no scale change. It is neither the complete scale factor nor a translation, rotation or scale rate." + Environment.NewLine;
            DescriptionMD += "The meaningful presentation precision is 1e-12, equivalent to 0.000001 parts per million. At an Earth-sized coordinate magnitude of about 6.4 million metres, this scale increment corresponds to about 6.4 micrometres. This is a display convention, not a statement of transformation accuracy, and numeric conversions and stored values remain unrounded." + Environment.NewLine;
            DescriptionMD += "The unit is dimensionless in SI, Metric, US and Imperial, using the identity conversion inherited from DimensionlessQuantity. A source value in parts per million must first be multiplied by 1e-6: for example, 2 ppm is an SI scale difference of 0.000002 and a full scale factor of 1.000002. This quantity exposes the SI dimensionless representation; ppm is not a unit choice here." + Environment.NewLine;
            DescriptionMD += "The operation direction and method define how the parameter is applied. Reversing a transformation requires the method-defined inverse; do not simply negate all parameters. For a pure scale, the inverse scale difference is 1/(1+s)-1. See [PROJ Helmert transformation](https://proj.org/en/stable/operations/transformations/helmert.html) for parameter conventions; PROJ's command-line scale parameter is in ppm, unlike this SI quantity." + Environment.NewLine;
            Reset();
            UnitChoices.Add(DimensionlessQuantity.Instance.GetUnitChoice(DimensionlessQuantity.UnitChoicesEnum.Dimensionless));
            SemanticExample = GetSemanticExample();
        }
    }
}
