# Model for unit conversion of BasePhysicalQuantity

This nuget package hosts the C# model for converting units of a BasePhysicalQuantity.
Classes and methods are scoped within the namespace: ``UnitConversion.Conversion``

More info on:

https://github.com/Open-Source-Drilling-Community/UnitConversion

# Descriptive Definitions of UnitChoice Conversions
For each `UnitChoice`, it is possible to define a conversion factor and a conversion bias.
These are defined in the properties `ConversionFactorFromSIFormula` and `ConversionBiasFromSIFormula` respectively, which 
are string values. The content of these strings is the code to calculate the conversion factor and the conversion bias.
The code is in plain C#. If the code involves some mathematics operator like square root or Pi, these need to be fully
qualified, i.e., `System.Math.Sqrt` or `System.Math.Pi`. Otherwise, it is possible to use already defined `Factors`, like `Factors.Inch`.
These factors are also defined as formulas as a function of other definition. This symbolic definition of the conversion
factor and bias allows to generate a comprehensive description of the conversion factors and bias by calling the method `GetConversionDescription` of `UnitChoice`.

Here is the result obtained on calling `GetConversionDescription` on the Fahrenheit unit choice:
```
[v] = a * [SI] + b
where
[v] is the value in fahrenheit
[SI] is the value in SI, i.e., in kelvin
a = 1.0/FahrenheitSlope, i.e., 1.7999999999999998
b = -FahrenheitBias, i.e., -459.67
and
FahrenheitSlope = 5.0 / 9.0 reference: https://nn.wikipedia.org/wiki/Fahrenheit
FahrenheitBias = 459.67 reference: https://nn.wikipedia.org/wiki/Fahrenheit
```

and here is the result obtained with the Furlong unit choice:
```
[v] = a * [SI]
where
[v] is the value in furlong
[SI] is the value in SI, i.e., in metre
a = 1.0/Furlong, i.e., 0.004970969537898672
and
Furlong = 660.0 * Foot reference: https://www.britannica.com/science/furlong
Foot = 12.0 * Inch
Inch = 0.0254 reference: https://www.nist.gov/pml/owm/si-units-length
```

For efficiency, there is a conversion that is made from the symbolic description to code when calling the program `GenerateEnumerations` (see below).

# Generation of Enumerations
This project has one file that is automaticaly generated `EnumerationQuantities.cs`. 
This file contains partial classes for each of the physical quantities. 
Each partial class definition defines an enumeration for each of the
unit choices that are defined for this physical quantity and a 
lookup table that defines the association between the enumeration
and the `GUID` of the unit choice.

To generate the file `EnumerationQuantities.cs`, one must run the program
`GenerateEnumerations`. The generation of the file is necessary each
time a modification is made in the list of unit choices of a physical
quantity or when a new physical quantity is added or removed. 

# Contributors

**Eric Cayeux**, *NORCE Energy Modelling and Automation*

**Gilles Pelfrene**, *NORCE Energy Modelling and Automation*

## Gravity potential

`GravityPotentialQuantity` describes gravity potential with dimensions L² T⁻² and no application-specific meaningful precision. `EarthGravityPotentialQuantity` inherits its units and defines `MeaningfulPrecisionInSI = 0.01` m²/s² for terrestrial presentation. This is approximately a millimetre of height difference near Earth's surface, not a claim of model accuracy or a rounding of stored values.

Both expose explanatory `DescriptionMD` text covering the geodetic convention W = V + Phi, g = grad W, reference-potential considerations, and the distinction from energy density. Supported units are m²/s², J/kg, ft²/s² and ft·lbf/lbm. Factors are formulas built from existing base factors: `1.0/(Factors.Foot*Factors.Foot)` and `Factors.Pound/(Factors.Foot*Factors.PoundForce)` convert from SI. One ft·lbf/lbm is 2.98906692 J/kg; pound-force uses standard gravity, not local gravity.

When adding quantities, follow [the generator workflow](../GenerateEnumerations/README.md). It writes `Constructors.cs`, `Factors.cs` and the enumeration files; regenerate before adding enum-based defaults to unit systems.

## Inverse flattening

`InverseFlatteningQuantity` specializes DimensionlessQuantity in the general Conversion library. Its meaningful display precision is 1e-9, preserving nine decimal places such as WGS84's 298.257223563. Numeric conversion is the identity and does not round stored values. The dimensionless unit and its symbolic factor `1.0/Factors.Unit` are inherited from the parent. Flattening and inverse flattening are different quantities, not unit choices. A provider's zero sentinel for a sphere remains untouched.

The new quantity is registered through GenerateEnumerations, with dimensionless defaults in SI, Metric, US and Imperial. Intra-solution dependencies use unconditional project references so generation, tests and consumers see the same source catalogue. NuGet packing still records package dependencies; published dependency versions must be aligned during release.

## Helmert scale difference

`HelmertScaleDifferenceQuantity` specializes DimensionlessQuantity in the general Conversion library, with meaningful precision 1e-12 (0.000001 ppm). It describes the signed increment s in a full scale factor 1+s. Zero means no scale change. Numeric conversions preserve the full value. All systems use the shared dimensionless unit and inherited symbolic identity factor `1.0/Factors.Unit`; ppm is described for interpretation but is not an exposed unit choice. Source ppm values must be converted to SI by multiplying by 1e-6. This precision is a display convention, not a transformation-accuracy claim.

## Projection scale factor

`ProjectionScaleFactorQuantity` specializes DimensionlessQuantity with meaningful display precision 1e-9. It describes the full method-defined projection factor k (unity means no local scale change), distinct from the Helmert increment s in 1+s. UTM uses 0.9996 at its central meridian. SI, Metric, US and Imperial share the dimensionless unit and inherited symbolic factor `1.0/Factors.Unit`; percent and ppm are not exposed unit choices. Numeric conversion does not round values. DescriptionMD explains context, precision and the distinction from scale differences and unit-conversion factors.
