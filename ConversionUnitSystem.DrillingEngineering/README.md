# Model for unit conversion of BasePhysicalQuantity

This nuget package hosts the C# model for managing sets of unit choices for physical quantities.
Such a set forms a BaseUnitSystem.

More info on:

https://github.com/Open-Source-Drilling-Community/UnitConversion

# Default UnitChoices for the Base Unit Systems
There are four default base unit systems: `SI`, `Metric`, `Imperial` and `US`.
It is mandatory to define the unit choice for every physical quantities for
each of these based unit systems. This is done by adding a line for each
 of the `BaseUnitSystem` in the file `BaseUnitSystem.cs`. This line looks like that:
```csharp
Choices.Add(AccelerationDrillingQuantity.Instance.ID.ToString(), AccelerationDrillingQuantity.Instance.GetUnitChoice(AccelerationDrillingQuantity.UnitChoicesEnum.MetrePerSecondSquared).ID.ToString());
```

# Contributors

**Eric Cayeux**, *NORCE Energy Modelling and Automation*

**Gilles Pelfrene**, *NORCE Energy Modelling and Automation*

## General inverse-flattening quantity

The local source dependency chain includes the general `InverseFlattening` quantity and its dimensionless unit with 1e-9 meaningful display precision. It is inherited from Conversion rather than defined as drilling-specific. Intra-solution dependencies are unconditional project references; release package versions must be aligned before publication.

## Projection scale factor

Drilling systems inherit the general ProjectionScaleFactor defaults: dimensionless in SI, Metric, US and Imperial, with 1e-9 meaningful display precision.
