# UnitConversion

This repository has been created and is maintained by the NORCE Energy Modelling & Simulation team. This research work has been funded by the [Research Council of Norway](https://www.forskningsradet.no/) and [Industry partners](https://www.digiwells.no/about/board/) in the framework of the center for research-based innovation [SFI Digiwells (2020-2028)](https://www.digiwells.no/) focused on Digitalization, Drilling Engineering and GeoSteering. Part of it is hereby donated **without any limit or warranty** to the Society of Petroleum (SPE) Open Source Drilling Community under the **MIT** license, a sub-committee of the Drilling System Automation Technical Section. Anyone is thus **free to use** the source code of this repository **under its own responsibility**.

## General description
UnitConversion is a .NET library designed to handle unit conversions. It allows to use standard systems of units (SI, US, Imperial, Metric) and to define custom systems of units (called UnitChoiceSet's). A very broad range of physical quantities (PhysicalQuantity's) is defined. For the developer's convenience, and dedicated set of physical quantities typically used in drilling engineering is also defined. Physical quantities are agremented with unit choices (UnitChoice) and conversions between unit choices are associated with the physical quantity in question. Unit conversions can also be performed by batch using DataUnitConversionSet's.

## Deployment (library)
The different .NET projects of this package have been packaged as .NET NuGets and published to [nuget.org](https://www.nuget.org/packages?q=OSDC.UnitConversion&prerel=true&sortby=relevance).

## Deployement (microservice)
This library is also packaged as a microservice that can be queried by 3rd part applications to conduct all operations mentioned above (definition of system of units and unit conversion). A web application has also been implemented to perform the same operations using a user friendly interface. The endpoints for each feature available are provided in the table below:

|microservice|webapp|
|------------|-------------|
|[DrillingUnitChoiceSets](https://app.digiwells.no/DrillingUnitConversion/api/DrillingUnitChoiceSets)|[DrillingUnitChoiceSets](https://app.digiwells.no/DrillingUnitConversion/webapp/DrillingUnitChoiceSets)|
|[DrillingPhysicalQuantities](https://app.digiwells.no/DrillingUnitConversion/api/DrillingPhysicalQuantities)|[DrillingPhysicalQuantities](https://app.digiwells.no/DrillingUnitConversion/webapp/DrillingPhysicalQuantities)|
|[DataUnitConversionSets](https://app.digiwells.no/DrillingUnitConversion/api/DataUnitConversionSets)|[DataUnitConversionSets](https://app.digiwells.no/DrillingUnitConversion/webapp/DataUnitConversionSets)|

