# Generating quantity definitions

Read the Conversion and Conversion.DrillingEngineering READMEs before adding a quantity. The generator references both source projects. It emits Conversion/Constructors.cs, Conversion/Factors.cs and both libraries' EnumerationQuantities.cs; do not maintain these outputs manually.

1. Add the quantity, stable quantity/unit GUIDs, symbolic conversion formulas using existing Factors, and DescriptionMD explanations. For an initial build, a subclass may look up a new base unit by its unit-name string until its enum exists.
2. Build GenerateEnumerations, then run it with the working directory set to this GenerateEnumerations folder (its path discovery requires a descendant of UnitConversion).
3. Replace bootstrap string lookups with generated enums, then add enum-based default choices to the unit systems. SI discovers the canonical IsSI choice; Metric, US and Imperial require explicit defaults.
4. Rebuild and rerun the generator, then build and test the libraries, unit systems and consumers.

Example, with the repository's required SDK installed:

```powershell
# Working directory: UnitConversion/GenerateEnumerations
dotnet build -c Release
dotnet bin/Release/net8.0/GenerateEnumerations.dll
```

The generator retains the compiled QuantityEnum order and appends new quantities in name order, preserving existing numeric enum values when adding quantities. Removing quantities requires a separate compatibility review. Stable GUIDs remain the persisted catalogue identities.
