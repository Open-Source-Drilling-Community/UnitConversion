---
title: "Project: Microservice for UnitConversionSets"
output: html_document
---

Objective
===
This project contains the microservice that allows to access the management of UnitConversionSets.


Principles
===
The microservice provides a web API and is containerized using Docker. The web api endpoint is `DrillingUnitConversion/api/UnitConversionSets`. It is possible to upload new UnitConversionSet 
(`Post` method), to modify already uploaded UnitConversionSet (`Put` method), to delete uploaded UnitConversionSets (`Delete` method). By calling the `Get` without arguments, 
it is possible to obtain a list of all the identifiers of the UnitConversionSets that have been uploaded. It is also possible 
to call the `Get`method with the ID of an uploaded UnitConversionSet.


