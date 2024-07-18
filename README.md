# UnitConversion

<details>
   <summary>Physical quantities</summary>

The UnitConversion repository contains tools to handle unit conversions of a wide variety of physical quantities:

- either 78 base physical quantities, called *BasePhysicalQuantity*

- or 66 physical quantities specific to the drilling engineering field, called *PhysicalQuantity*

- note that *PhysicalQuantity* extends *BasePhysicalQuantity* and hence encompasses it, so that the class *PhysicalQuantity* opens access to a total of **144 physical quantities**.

- see the complete list of physical quantities by technical fields [below](# List-of-physical-quantities)

</details>

<details>
   <summary>Unit conversion classes</summary>

Unit conversions can be handled:

- either through *UnitSystemConversionSet* that converts a user-defined collection physical quantities from one unit system to another

  - *UnitSystemConversionSet* class is useful for web pages that rely on a user-selected unit system
  
  - a unit system is a collection of quantities where each *PhysicalQuantity* is assigned one pre-defined *UnitChoice*

    - *BaseUnitSystem* are standard unit systems, i.e. *SI*, *US*, *Imperial*, *Metric*

    - *UnitSystem* are custom unit systems that allow the user to map every *PhysicalQuantity* to a preferred *UnitChoice*
  
    - note that *UnitSystem* extends *BaseUnitSystem* and hence encompasses it
 
 - or through *UnitConversionSet* that converts a user-defined collection physical quantities from one unit choice to another
 
   - *UnitConversionSet* class is more versatile and useful for daily unit conversions technical people must perform in their every day life

</details>

# Unit conversion tools

The UnitConversion repository hosts a:

- [.NET library (nuget package)](https://www.nuget.org/packages/OSDC.UnitConversion.Conversion) that handles unit conversions of base physical quantities

- [.NET library (nuget package)](https://www.nuget.org/packages/OSDC.UnitConversion.Conversion.DrillingEngineering) that handles unit conversions of physical quantities specific to the drilling engineering field

- a microservice to handle unit conversions programmatically
  - [microservice API](https://app.digiwells.no/UnitConversion/api/swagger) (swagger)
  - [PhysicalQuantity endpoint](https://app.digiwells.no/UnitConversion/api/PhysicalQuantity)
  - [UnitSystem endpoint](https://app.digiwells.no/UnitConversion/api/UnitSystem)
  - [UnitSystemConversionSet endpoint](https://app.digiwells.no/UnitConversion/api/UnitSystemConversionSet)
  - [UnitConversionSet endpoint](https://app.digiwells.no/UnitConversion/api/UnitConversionSet)

- a client user interface to handle unit conversions
  - [PhysicalQuantity endpoint](https://app.digiwells.no/UnitConversion/webapp/PhysicalQuantity)
  - [UnitSystem endpoint](https://app.digiwells.no/UnitConversion/webapp/UnitSystem)
  - [UnitSystemConversionSet endpoint](https://app.digiwells.no/UnitConversion/webapp/UnitSystemConversionSet)
  - [UnitConversionSet endpoint](https://app.digiwells.no/UnitConversion/webapp/UnitConversionSet)

# Data model architecture

<details>
   <summary>Hybrid data access</summary>
   
- physical quantities and standard unit systems are accessed in-memory, through the nuget packages [OSDC.UnitConversion.Conversion.DrillingEngineering](https://www.nuget.org/packages/OSDC.UnitConversion.Conversion) and [OSDC.UnitConversion.Conversion](https://www.nuget.org/packages/OSDC.UnitConversion.Conversion.DrillingEngineering)

- custom unit systems, unit system conversion sets, and unit conversion sets are accessed from the database of the containerized microservice

</details>

<details>
   <summary>*BasePhysicalQuantity* and *BaseUnitSystem*</summary>
   
- base physical quantities are accessed in-memory through `BasePhysicalQuantity.AvailableBasePhysicalQuantities`. Each `BasePhysicalQuantity` holds a reference on a list of `UnitChoice` which simply represent units available for this quantity.

- base unit systems (*SI*, *Metric*, *Imperial*, *US*) are also access in-memory through `BaseUnitSystem.SIBaseUnitSystem` for example. Each of them holds a reference on a Dictionary<string, string> that assigns one `UnitChoice` to each `BasePhysicalQuantity`

- class diagram is as follows




- *PhysicalQuantity* extends *BasePhysicalQuantity* and *UnitSystem* extends *BaseUnitSystem* so that the same considerations as above apply

- class diagram is as follows

- all these classes are identified with a simple `Guid`. The `MetaInfo` available in nuget package [`OSDC.DotnetLibraries.General.DataManagement`](https://www.nuget.org/packages/OSDC.DotnetLibraries.General.DataManagement) concept is not necessary here due to the in-memeory data access.

</details>

<details>
   <summary>Unit conversion classes</summary>

- the base class that performs `double` to `double?` unit conversions is *ValueConversion*

- *ValueConversion* is aggregated in two intermediate super-classes
  - *QuantityConversion* that holds a reference on the `Guid` of a *PhysicalQuantity*
  - *QuantityUnitConversion* that holds a reference on both the `Guid` of a *PhysicalQuantity*, the `Guid` of a *UnitChoice* for the input data, and the `Guid` of a *UnitChoice* for the output data
  
- *QuantityConversion* is itself aggregated in the *UnitSystemConversionSet* super-class that holds a reference on
  - the `Guid` of an input *UnitSystem*
  - the `Guid` of an output *UnitSystem*
  - a *MetaInfo* used to identify the conversion set in the microservice architecture and store it in the database
  
- *QuantityUnitConversion* is itself aggregated in the *UnitConversionSet* super-class that simply holds a reference on a *MetaInfo* used to identify the conversion set in the microservice architecture and store it in the database
  - no unit system or unit choice identifier are necessary at the *UnitConversionSet* level, since unit choices are already decided at the level of the *QuantityUnitConversion*
  
- therefore, *UnitSystemConversionSet* is useful to convert quantities from a unit system to another and *UnitConversionSet* is more versatile as it allows to tune the unit choice at the level of each quantity aggregated in the list. In particular, with the *UnitConversionSet*, it is possible to convert 2 quantities of the same type according to different unit choices. Whereas, with the *UnitSystemConversionSet*, all quantities of the same type must stick to the unit choice of the selected input or output *UnitSystem*

- class diagram is as follows




   
</details>

# List of physical quantities

<details>
   <summary>BasePhysicalQuantity (count = 74)</summary>
   
|Physical Quantity Name|Usual Names||||
|---|---|---|---|---|
|Acceleration|Acceleration||||
|AmountSubstance|Amount Substance||||
|AngleMagneticFluxDensity|Angle Magnetic Flux Density||||
|AngleVariationGradient|Angle Variation Gradient||||
|AngularVelocity|Angular Velocity||||
|Area|Area||||
|Compressibility|Compressibility||||
|Curvature|Curvature||||
|Density|Density||||
|DensityGradientDepth|Density Gradient Depth||||
|DensityGradientTemperature|Density Gradient Temperature||||
|DensityRateOfChange|Density Rate of Change||||
|Dimensionless|Dimensionless||||||
|DynamicViscosity|Dynamic Viscosity||||
|EarthMagneticFluxDensity|Earth Magnetic Flux Density||||
|ElectricalCapacitance|Electrical Capacitance||||
|ElectricalCurrent|Electrical Current||||
|ElectricTension|Electric Tension||||
|ElongationGradient|Elongation Gradient||||
|Energy|Energy||||
|FluidShearRate|Fluid Shear Rate||||
|FluidShearStress|Fluid Shear Stress||||
|Force|Force||||
|ForceGradient|Force Gradient||||
|Frequency|Frequency||||
|FrequencyRateOfChange|Frequency Rate Of Change||||
|GravitationalLoad|Gravitational Load||||
|HeatTransferCoefficient|Heat Transfer Coefficient||||
|HydraulicConductivity|Hydraulic Conductivity||||
|ImageScale|Image Scale||||
|InterfacialTension|Interfacial Tension||||
|LargeVolume|Large Volume||||
|Length|Length||||
|LuminousIntensity|Luminous Intensity||||
|MagneticFlux|Magnetic Flux||||
|MagneticFluxDensity|Magnetic Flux Density||||
|Mass|Mass||||
|MassGradient|Mass Gradient||||
|MassRate|Mass Rate||||
|MaterialStrength|Material Strength||||
|Permeability|Permeability||||
|PlaneAngle|Plane Angle||||
|Porosity|Porosity||||
|Power|Power||||
|Pressure|Pressure||||
|PressureGradient|Pressure Gradient||||
|PressureLossConstant|Pressure Loss Constant||||
|Proportion|Proportion||||
|RandomWalk|Random Walk||||
|RelativeTemperature|Relative Temperature||||
|Resistivity|Resistivity||||
|RheologyConsistencyIndex|Rheology Consistency Index||||
|RotationFrequency|Rotation Frequency|Rotary speed|RPM|
|RotationFrequencyRateOfChange|Rotation Frequency Rate Of Change||||
|SmallDiameter|Small Diameter||||
|SmallLength|Small Length||||
|SmallProportion|Small Proportion||||
|SmallRotationFrequency|Small Rotation Frequency|Small rotary speed|Small RPM|
|SmallTorque|Small Torque||||
|SolidAngle|Solid Angle||||
|SpecificHeatCapacity|Specific Heat Capacity||||
|SpecificHeatCapacityTemperatureGradient|Specific Heat Capacity Temperature Gradient||||
|StandardDimensionless|Standard Dimensionless||||
|StandardLength|Standard Length||||
|StandardProportion|Standard Proportion||||
|Temperature|Temperature||||
|TemperatureGradient|Temperature Gradient||||
|Tension|Tension||||
|ThermalConductivity|Thermal Conductivity||||
|ThermalConductivityTemperatureGradient|Thermal Conductivity Temperature Gradient||||
|Time|Time||||
|Torque|Torque|Bending moment|||
|Velocity|Velocity||||
|Volume|Volume||||
|VolumetricFlowRate|Volumetric Flow Rate|Flow Rate (volumetric)|||
|VolumetricFlowRateRateOfChange|Volumetric Flow Rate Rate Of Change||||
|WaveNumber|Wave Number||||
|YoungModulus|Young Modulus||||
   
</details>

<details>
   <summary>PhysicalQuantity, drilling-specific only (count = 66)</summary>
   
|Physical Quantity Name|Usual Names||||
|---|---|---|---|---|
|AccelerationDrilling|Acceleration (drilling)||||||
|AngleVariationGradientDrilling|Angle Variation Gradient (drilling)|||
|AngularVelocityDrilling|Angular Velocity (drilling)||||||
|AreaDrilling|Area (drilling)||||||
|AxialVelocityDrilling|Axial Velocity (drilling)||||||
|BlockVelocity|Block Velocity (drilling)||||||
|CableDiameter|Cable Diameter (drilling)||||||
|CapillaryPressure|Capillary Pressure (drilling)||||||
|CompressibilityDrilling|Compressibility (drilling)||||||
|CurvatureDrilling|Curvature (drilling)|DLS|Dogleg severity||
|DensityDrilling|Density (drilling)||||||
|DensityGradientDepthDrilling|Density Gradient Depth (drilling)||||||
|DensityGradientTemperatureDrilling|Density Gradient Temperature (drilling)||||||
|DensityRateOfChangeDrilling|Density Rate of Change (drilling)||||||
|Depth|Depth (drilling)||||||
|DrillStemMaterialStrength|Drill Stem Material Strength (drilling)||||||
|DrillStringMagneticFluxDrilling|Drill String Magnetic Flux (drilling)||||||
|DurationDrilling|Duration (drilling)||||||
|DynamicViscosityDrilling|Dynamic Viscosity (drilling)||||||
|ElongationGradientDrilling|Elongation Gradient (drilling)||||||
|FluidVelocityDrilling|Fluid Velocity (drilling)||||||
|ForceDrilling|Force (drilling)||||||
|ForceGradientDrilling|Force Gradient (drilling)||||||
|FormationResistivity|Formation Resistivity (drilling)||||||
|FormationStrength|Formation Strength (drilling)||||||
|GammaRay|Gamma Ray (drilling)||||||
|GasShow|Gas Show (drilling)||||||
|GasVolumetricFlowRate|Gas Volumetric Flow Rate (drilling)||||||
|HeatTransferCoefficientDrilling|Heat Transfer Coefficient (drilling)||||||
|Height|Height (drilling)||||||
|HookLoad|Hook Load (drilling)||||||
|HydraulicConductivityDrilling|Hydraulic Conductivity (drilling)||||||
|InterfacialTensionDrilling|Interfacial Tension (drilling)||||||
|MassDrilling|Mass (drilling)||||||
|MassGradientDrilling|Mass Gradient (drilling)||||||
|MassRateDrilling|Mass Rate (drilling)||||||
|NozzleDiameter|Nozzle Diameter (drilling)||||||
|PipeDiameter|Pipe Diameter (drilling)||||||
|PlaneAngleDrilling|Plane Angle (drilling)||||||
|PoreDiameter|Pore Diameter (drilling)||||||
|PoreSurface|Pore Surface (drilling)||||||
|Position|Position (drilling)||||||
|PowerDrilling|Power (drilling)||||||
|PressureDrilling|Pressure (drilling)|MSE (as a pressure)|||
|PressureGradientDrilling|Pressure Gradient (drilling)||||||
|PressureLossConstantDrilling|Pressure Loss Constant (drilling)||||||
|RandomWalkDrilling|Random Walk (drilling)||||||
|RateOfPenetration|Rate Of Penetration (drilling)||ROP||
|RotationFrequencyRateOfChangeDrilling|Rotation Frequency Rate Of Change (drilling)||||||
|ShockRate|Shock Rate (drilling)||||||
|SpecificHeatCapacityDrilling|Specific Heat Capacity (drilling)||||||
|SpecificHeatCapacityTemperatureGradientDrilling|Specific Heat Capacity Temperature Gradient (drilling)|||
|StickDurationDrilling|Stick Duration (drilling)||||||
|SurveyInstrumentAngleMagneticFluxDensityDrilling|Survey Instrument Angle Magnetic Flux Density (drilling)||||||
|SurveyInstrumentAngularVelocityDrilling|Survey Instrument Angular Velocity (drilling)||||||
|SurveyInstrumentReciprocalLengthDrilling|Survey Instrument Reciprocal Length (drilling)||||||
|TemperatureDrilling|Temperature (drilling)||||||
|TemperatureGradientDrilling|Temperature Gradient (drilling)||||||
|TensionDrilling|Tension (drilling)||||||
|ThermalConductivityDrilling|Thermal Conductivity (drilling)||||||
|ThermalConductivityTemperatureGradientDrilling|Thermal Conductivity Temperature Gradient (drilling)||||||
|TorqueDrilling|Torque (drilling)|Bending moment (drilling)|TOB|BOB|
|VolumeDrilling|Volume (drilling)||||||
|VolumetricFlowRateDrilling|Volumetric Flow Rate (drilling)|Flow Rate (volumetric, drilling)||||
|VolumetricFlowRateOfChangeDrilling|Volumetric Flow Rate Of Change (drilling)||||||
|WeightOnBit|Weight On Bit (drilling)|WOB||||

</details>

<details>
   <summary>PhysicalQuantity, by technical field (count = 144)</summary>
   
<style>
.table-fixed {
  width: 100%;
  table-layout: fixed;
}
.table-fixed td:nth-child(2) {
  width: 400px; /* Ajustez la largeur comme nécessaire */
  word-wrap: break-word;
}
</style>

<table class="table-fixed">
  <tr>
    <th>Technical Field</th>
    <th>Physical Quantities</th>
  </tr>
  <tr>
    <td>Chemistry_and_Material_Properties</td>
    <td>AmountSubstance, DensityGradientDepth, DensityGradientDepthDrilling, DensityGradientTemperature, DensityGradientTemperatureDrilling, DensityDrilling, DensitySpeedDrilling, FormationResistivity, FormationStrength, GasShow, Mass, MassDrilling, MassGradient, MassGradientDrilling, MassRate, MassRateDrilling, Porosity, Proportion, Resistivity, RheologyConsistencyIndex, ShockRate, SmallProportion, SpecificHeatCapacity, SpecificHeatCapacityDrilling, SpecificHeatCapacityTemperatureGradient, SpecificHeatCapacityTemperatureGradientDrilling</td>
  </tr>
  <tr>
    <td>Drilling_Technology</td>
    <td>AccelerationDrilling, AngleVariationGradientDrilling, AngularVelocityDrilling, AreaDrilling, AxialVelocityDrilling, CompressibilityDrilling, CurvatureDrilling, DensityDrilling, DensityGradientDepthDrilling, DensityGradientTemperatureDrilling, DensitySpeedDrilling, DrillStringMagneticFlux, DrillStemMaterialStrength, DurationDrilling, DynamicViscosityDrilling, ElongationGradientDrilling, FluidVelocityDrilling, ForceDrilling, ForceGradientDrilling, HeatTransferCoefficientDrilling, HydraulicConductivityDrilling, InterfacialTensionDrilling, MagneticFluxDensityDrilling, PlaneAngleDrilling, PowerDrilling, PressureDrilling, PressureGradientDrilling, PressureLossConstantDrilling, RandomWalkDrilling, RotationFrequencyRateOfChangeDrilling, StickDurationDrilling, SurveyInstrumentAngularVelocityDrilling, SurveyInstrumentMagneticFluxDensityDrilling, SurveyInstrumentReciprocalLengthDrilling, TemperatureDrilling, TemperatureGradientDrilling, ThermalConductivityDrilling, ThermalConductivityTemperatureGradientDrilling, TorqueDrilling, VolumetricFlowRateDrilling, VolumetricFlowRateOfChangeDrilling</td>
  </tr>
  <tr>
    <td>Electromagnetism</td>
    <td>AngleMagneticFluxDensity, EarthMagneticFluxDensity, ElectricalCurrent, ElectricTension, MagneticFlux, MagneticFluxDensity, SurveyInstrumentMagneticFluxDensityDrilling</td>
  </tr>
  <tr>
    <td>Fluid_Dynamics_and_Hydraulics</td>
    <td>Capacitance, Depth, Density, Dimensionless, FluidShearRate, FluidShearStress, FlowRate, FluidVelocityDrilling, HydraulicConductivity, HydraulicConductivityDrilling, InterfacialTension, InterfacialTensionDrilling, Permeability, PressureLossConstant, PressureLossConstantDrilling, VolumetricFlowRateRateOfChange, WaveNumber, VolumetricFlowRateDrilling, VolumetricFlowRateOfChangeDrilling</td>
  </tr>
  <tr>
    <td>Geometric_and_Dimensional_Analysis</td>
    <td>Area, Curvature, CurvatureDrilling, Dimensionless, ImageScale, Length, PlaneAngle, PlaneAngleDrilling, SolidAngle</td>
  </tr>
  <tr>
    <td>Instrumentation_and_Measurement</td>
    <td>Frequency, FrequencyRateOfChange, GammaRay, Height, ImageScale, LuminousIntensity, RelativeTemperature, StandardDimensionless, StandardLength, StandardProportion</td>
  </tr>
  <tr>
    <td></td>
    <td></td>
  </tr>
  <tr>
    <td>Mechanics</td>
    <td>Acceleration, AngularVelocity, BlockVelocity, DensitySpeed, Force, ForceGradient, GravitationalLoad, HookLoad, Position, RandomWalk, RateOfPenetration, RotationFrequency, RotationFrequencyRateOfChange, SmallRotationFrequency, SmallTorque, Torque, Velocity, WeightOnBit, YoungModulus</td>
  </tr>
  <tr>
    <td>Structural_and_Material_Science</td>
    <td>CableDiameter, DrillStemMaterialStrength, ElongationGradient, LargeVolume, MaterialStrength, NozzleDiameter, PoreDiameter, PoreSurface, SmallDiameter, SmallLength, SmallProportion, StandardDimensionless, StandardLength, StandardProportion, Volume</td>
  </tr>
  <tr>
    <td>Thermodynamics_and_Heat_Transfer</td>
    <td>CapillaryPressure, Compressibility, Energy, HeatTransferCoefficient, HeatTransferCoefficientDrilling, SpecificHeatCapacity, SpecificHeatCapacityDrilling, SpecificHeatCapacityTemperatureGradient, SpecificHeatCapacityTemperatureGradientDrilling, Temperature, TemperatureGradient, ThermalConductivity, ThermalConductivityDrilling, ThermalConductivityTemperatureGradient, ThermalConductivityTemperatureGradientDrilling</td>
  </tr>
</table>
   
</details>

# Funding

The current work has been funded by the [Research Council of Norway](https://www.forskningsradet.no/) and [Industry partners](https://www.digiwells.no/about/board/) in the framework of the cent for research-based innovation [SFI Digiwells (2020-2028)](https://www.digiwells.no/) focused on Digitalization, Drilling Engineering and GeoSteering.

# Contributors

**Eric Cayeux**, *NORCE Energy Modelling and Automation*

**Gilles Pelfrene**, *NORCE Energy Modelling and Automation*

# License

Part of it is hereby donated **without any limit or warranty** to the Society of Petroleum (SPE) Open Source Drilling Community under the **MIT** license, a sub-committee of the Drilling System Automation Technical Section. Anyone is thus **free to use** the source code of this repository **under its own responsibility**.
