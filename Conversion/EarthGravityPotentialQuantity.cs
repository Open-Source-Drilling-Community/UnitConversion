using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class EarthGravityPotentialQuantity : GravityPotentialQuantity
    {
        public override double? MeaningfulPrecisionInSI { get; } = 0.01;
        private static EarthGravityPotentialQuantity instance_ = null;

        public static new EarthGravityPotentialQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new EarthGravityPotentialQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public EarthGravityPotentialQuantity() : base()
        {
            Name = GetType().Name.Split("Quantity").First();
            ID = new Guid("61a8a54e-684a-4e72-bb46-b73d342bdb70");
            UsualNames = new HashSet<string>() { "earth gravity potential", "terrestrial gravity potential", "earth geopotential" };
            DescriptionMD += Environment.NewLine + "**Earth gravity potential** specializes gravity potential for terrestrial gravity models and geodetic applications. For example, the EGM96 total potential returned by GeographicLib includes both gravitational attraction and the centrifugal contribution from Earth's rotation." + Environment.NewLine;
            DescriptionMD += "The meaningful presentation precision is " + MeaningfulPrecisionInSI.Value.ToString(CultureInfo.InvariantCulture) + " m²/s² (equivalently J/kg). Near Earth's surface this is approximately the potential difference associated with one millimetre of vertical displacement. This is a display convention, not a statement of EGM96 accuracy, a rounding of stored values, or a replacement for model uncertainty. It is converted to the selected display unit by the standard quantity-formatting machinery." + Environment.NewLine;
            Reset();
            UnitChoices.Add(GravityPotentialQuantity.Instance.GetUnitChoice(GravityPotentialQuantity.UnitChoicesEnum.SquareMetrePerSquareSecond));
            UnitChoices.Add(GravityPotentialQuantity.Instance.GetUnitChoice(GravityPotentialQuantity.UnitChoicesEnum.JoulePerKilogram));
            UnitChoices.Add(GravityPotentialQuantity.Instance.GetUnitChoice(GravityPotentialQuantity.UnitChoicesEnum.SquareFootPerSquareSecond));
            UnitChoices.Add(GravityPotentialQuantity.Instance.GetUnitChoice(GravityPotentialQuantity.UnitChoicesEnum.FootPoundforcePerPoundmass));
            SemanticExample = GetSemanticExample();
        }
    }
}
