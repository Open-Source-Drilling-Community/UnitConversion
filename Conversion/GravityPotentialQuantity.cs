using System;
using System.Collections.Generic;
using System.Linq;

namespace OSDC.UnitConversion.Conversion
{
    public partial class GravityPotentialQuantity : DerivedBasePhysicalQuantity
    {
        public override string SIUnitName { get; } = "square metre per square second";
        public override string SIUnitLabelLatex { get; } = "\\frac{m^{2}}{s^{2}}";
        public override double LengthDimension { get; } = 2;
        public override double MassDimension { get; } = 0;
        public override double TimeDimension { get; } = -2;
        private static GravityPotentialQuantity instance_ = null;

        public static GravityPotentialQuantity Instance
        {
            get
            {
                if (instance_ == null)
                {
                    instance_ = new GravityPotentialQuantity();
                    instance_.PostProcess();
                }
                return instance_;
            }
        }

        public static List<UnitChoice> UnitChoiceDescriptions = new List<UnitChoice>()
        {
            new UnitChoice
            {
                UnitName = "square metre per square second", UnitLabel = "m²/s²",
                ID = new Guid("b3bd7f26-53be-42d6-9b0c-37f371944f5a"),
                ConversionFactorFromSIFormula = "1.0/Factors.Unit", IsSI = true
            },
            new UnitChoice
            {
                UnitName = "joule per kilogram", UnitLabel = "J/kg",
                ID = new Guid("67ded635-bf30-4986-a452-a4f219294e5f"),
                ConversionFactorFromSIFormula = "1.0/Factors.Unit"
            },
            new UnitChoice
            {
                UnitName = "square foot per square second", UnitLabel = "ft²/s²",
                ID = new Guid("61f47537-c38d-4359-86ad-648fc8903b19"),
                ConversionFactorFromSIFormula = "1.0/(Factors.Foot*Factors.Foot)"
            },
            new UnitChoice
            {
                UnitName = "foot pound-force per pound-mass", UnitLabel = "ft·lbf/lbm",
                ID = new Guid("568f00ee-c073-4cce-bc41-a20309281a26"),
                ConversionFactorFromSIFormula = "Factors.Pound/(Factors.Foot*Factors.PoundForce)"
            }
        };

        public GravityPotentialQuantity() : base()
        {
            Name = GetType().Name.Split("Quantity").First();
            ID = new Guid("3399d06a-5d68-4aab-a92c-8352cc44ac58");
            UsualNames = new HashSet<string>() { "gravity potential", "gravitational potential", "geopotential" };
            DescriptionMD = @"**Gravity potential** is a scalar field whose spatial derivative determines gravity acceleration under the declared sign convention.

Its dimensions are $L^2 T^{-2}$. Its SI unit is square metre per square second ($m^2/s^2$), equivalently joule per kilogram ($J/kg$): energy per unit mass, not energy per unit volume. Taking a spatial gradient divides by length and gives acceleration ($m/s^2$).

In the geodetic convention, total gravity potential is $W=V+\Phi$, where $V$ is the gravitational contribution and $\Phi$ is the centrifugal contribution; gravity is $\mathbf{g}=\nabla W$. The usual mechanical potential-energy-per-mass convention has the opposite sign. A unit conversion never changes this convention or adds/removes centrifugal effects; the producer must declare the physical meaning.

Potential differences, together with gravity information and a reference potential, can be related to height differences. Zero coordinate height or depth does not imply zero potential. Equal dimensions do not make every specific-energy quantity semantically interchangeable with gravity potential.

Supported representations are m²/s², J/kg, ft²/s², and ft·lbf/lbm. The foot is the international foot. Pound-force and pound-mass are explicitly distinguished: the latter representation uses standard gravity through the existing PoundForce factor, not the local calculated gravity. Conversion factors are derived symbolically from Factors.Foot, Factors.Pound and Factors.PoundForce. US and Imperial systems use ft²/s² by default.

This general quantity does not prescribe an application-specific meaningful precision. Use EarthGravityPotential for the Earth-gravity presentation convention.

Reference: GeographicLib GravityModel terminology (W = V + Phi; g = grad W)." + Environment.NewLine;
            InitializeUnitChoices();
            SemanticExample = GetSemanticExample();
        }
    }
}
