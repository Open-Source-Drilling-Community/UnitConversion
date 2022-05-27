cd %1\OSDC.UnitConversion.DrillingUnitConversion.Model
(docfx build -o %1\OSDC.UnitConversion.DrillingUnitConversion.Service\wwwroot\UnitConversionSet\ModelAPI) || (echo "docfx for model failed")
cd %1\OSDC.UnitConversion.DrillingUnitConversion.Service
(docfx build -o %1\OSDC.UnitConversion.DrillingUnitConversion.Service\wwwroot\UnitConversionSet\ServiceAPI) || (echo "docfx for service failed")
