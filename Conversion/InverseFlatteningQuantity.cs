using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class InverseFlatteningQuantity : DimensionlessQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 1e-9;
        public override string TypicalSymbol { get; } = "1/f";
        private static InverseFlatteningQuantity instance_ = null;

        public static new InverseFlatteningQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new InverseFlatteningQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public InverseFlatteningQuantity() : base()
        {
            Name = GetType().Name.Split("Quantity").First();
            ID = new Guid("2f4ba904-6f7d-4be7-abc8-602d37370b59");
            UsualNames = new HashSet<string>() { "inverse flattening", "reciprocal flattening", "ellipsoid inverse flattening" };
            DescriptionMD += Environment.NewLine + "**Inverse flattening** is the dimensionless reciprocal of ellipsoidal flattening. For an oblate ellipsoid with semi-major axis a and semi-minor axis b, f = (a - b)/a and 1/f = a/(a - b). It is a shape parameter, not a length or an angle." + Environment.NewLine;
            DescriptionMD += "The meaningful presentation precision is 1e-9 (nine decimal places), preserving the published WGS84 inverse flattening 298.257223563. See [NGA WGS84 defining parameters](https://earth-info.nga.mil/?action=wgs84&dir=wgs84). This is a display convention, not an accuracy claim or a rounding of stored values or numeric conversions." + Environment.NewLine;
            DescriptionMD += "SI, Metric, US and Imperial all use the same dimensionless unit with an identity conversion inherited from DimensionlessQuantity. Flattening and inverse flattening are different quantities, not alternative units: taking a reciprocal is not a unit conversion." + Environment.NewLine;
            DescriptionMD += "For a sphere, f = 0 and its reciprocal is not finite. Some data contracts use zero as a sphere sentinel; interpreting that sentinel belongs to the provider. This quantity neither replaces zero with infinity nor validates an ellipsoid." + Environment.NewLine;
            Reset();
            UnitChoices.Add(DimensionlessQuantity.Instance.GetUnitChoice(DimensionlessQuantity.UnitChoicesEnum.Dimensionless));
            SemanticExample = GetSemanticExample();
        }
    }
}
