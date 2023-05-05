//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace OSDC.UnitConversion.DrillingUnitConversion.ModelClientShared
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class DataUnitConversionSet
    {
        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid ID { get; set; }

        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        [Newtonsoft.Json.JsonProperty("ReferenceUnitChoiceSetID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid ReferenceUnitChoiceSetID { get; set; }

        [Newtonsoft.Json.JsonProperty("QuantityUnitConversions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<QuantityUnitConversion> QuantityUnitConversions { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class QuantityUnitConversion
    {
        [Newtonsoft.Json.JsonProperty("PhysicalQuantityID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid PhysicalQuantityID { get; set; }

        [Newtonsoft.Json.JsonProperty("DataConversions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<DataConversion> DataConversions { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class DataConversion
    {
        [Newtonsoft.Json.JsonProperty("DataIn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double DataIn { get; set; }

        [Newtonsoft.Json.JsonProperty("DataOut", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DataOut { get; set; }

        [Newtonsoft.Json.JsonProperty("DataOutString", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DataOutString { get; set; }

        [Newtonsoft.Json.JsonProperty("DataOutUnitChoiceLabel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DataOutUnitChoiceLabel { get; set; }

        [Newtonsoft.Json.JsonProperty("Conversion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ConversionType Conversion { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum ConversionType
    {

        FromSI = 0,


        ToSI = 1,


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class DrillingUnitChoiceSet : UnitChoiceSet
    {

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class UnitChoiceSet
    {
        [Newtonsoft.Json.JsonProperty("Choices", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> Choices { get; set; }

        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid ID { get; set; }

        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        [Newtonsoft.Json.JsonProperty("IsDefault", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsDefault { get; set; }

        [Newtonsoft.Json.JsonProperty("IsSI", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsSI { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PhysicalQuantity
    {
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid ID { get; set; }

        [Newtonsoft.Json.JsonProperty("SIUnitName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SIUnitName { get; set; }

        [Newtonsoft.Json.JsonProperty("SIUnitLabel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SIUnitLabel { get; set; }

        [Newtonsoft.Json.JsonProperty("UnitChoices", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<UnitChoice> UnitChoices { get; set; }

        [Newtonsoft.Json.JsonProperty("LengthDimension", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double LengthDimension { get; set; }

        [Newtonsoft.Json.JsonProperty("MassDimension", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double MassDimension { get; set; }

        [Newtonsoft.Json.JsonProperty("TimeDimension", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double TimeDimension { get; set; }

        [Newtonsoft.Json.JsonProperty("TemperatureDimension", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double TemperatureDimension { get; set; }

        [Newtonsoft.Json.JsonProperty("AmountSubstanceDimension", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double AmountSubstanceDimension { get; set; }

        [Newtonsoft.Json.JsonProperty("ElectricCurrentDimension", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double ElectricCurrentDimension { get; set; }

        [Newtonsoft.Json.JsonProperty("LuminousIntensityDimension", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double LuminousIntensityDimension { get; set; }

        [Newtonsoft.Json.JsonProperty("PlaneAngleDimension", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double PlaneAngleDimension { get; set; }

        [Newtonsoft.Json.JsonProperty("SolidAngleDimension", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double SolidAngleDimension { get; set; }

        [Newtonsoft.Json.JsonProperty("MeaningfulPrecisionInSI", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MeaningfulPrecisionInSI { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class UnitChoice
    {
        [Newtonsoft.Json.JsonProperty("UnitName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitName { get; set; }

        [Newtonsoft.Json.JsonProperty("UnitLabel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitLabel { get; set; }

        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid ID { get; set; }

        [Newtonsoft.Json.JsonProperty("ConversionFactorFromSI", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double ConversionFactorFromSI { get; set; }

        [Newtonsoft.Json.JsonProperty("ConversionBiasFromSI", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double ConversionBiasFromSI { get; set; }

        [Newtonsoft.Json.JsonProperty("IsSI", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsSI { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class QuantityDataConversion : DataConversion
    {
        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid ID { get; set; }

        [Newtonsoft.Json.JsonProperty("QuantityID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid QuantityID { get; set; }

        [Newtonsoft.Json.JsonProperty("UnitChoiceID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid UnitChoiceID { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.9.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class TupleOfDataUnitConversionSetAndDrillingUnitChoiceSetAndPhysicalQuantityAndQuantityDataConversion
    {
        [Newtonsoft.Json.JsonProperty("Item1", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DataUnitConversionSet Item1 { get; set; }

        [Newtonsoft.Json.JsonProperty("Item2", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DrillingUnitChoiceSet Item2 { get; set; }

        [Newtonsoft.Json.JsonProperty("Item3", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PhysicalQuantity Item3 { get; set; }

        [Newtonsoft.Json.JsonProperty("Item4", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public QuantityDataConversion Item4 { get; set; }


    }
}
