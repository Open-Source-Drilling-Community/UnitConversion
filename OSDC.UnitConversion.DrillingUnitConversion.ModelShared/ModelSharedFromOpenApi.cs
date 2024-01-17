//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v14.0.2.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 612 // Disable "CS0612 '...' is obsolete"
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"
#pragma warning disable 8603 // Disable "CS8603 Possible null reference return"
#pragma warning disable 8604 // Disable "CS8604 Possible null reference argument for parameter"
#pragma warning disable 8625 // Disable "CS8625 Cannot convert null literal to non-nullable reference type"

namespace OSDC.UnitConversion.DrillingUnitConversion.ModelShared
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.2.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class MetaInfo
    {

        [System.Text.Json.Serialization.JsonPropertyName("ID")]
        public System.Guid ID { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("Name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("Description")]
        public string Description { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("TypeName")]
        public string TypeName { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("CreationDate")]
        public System.DateTimeOffset CreationDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("LastModificationDate")]
        public System.DateTimeOffset LastModificationDate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("HttpHostName")]
        public string HttpHostName { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("HttpHostBasePath")]
        public string HttpHostBasePath { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("HttpEndPoint")]
        public string HttpEndPoint { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.2.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DrillingUnitChoiceSet
    {

        [System.Text.Json.Serialization.JsonPropertyName("Choices")]
        public System.Collections.Generic.IDictionary<string, string> Choices { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("ID")]
        public System.Guid ID { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("Name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("Description")]
        public string Description { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("IsDefault")]
        public bool IsDefault { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("IsSI")]
        public bool IsSI { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.2.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PhysicalQuantity
    {

        [System.Text.Json.Serialization.JsonPropertyName("TypicalSymbol")]
        public string TypicalSymbol { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("SIUnitName")]
        public string SIUnitName { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("SIUnitLabel")]
        public string SIUnitLabel { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("LengthDimension")]
        public double LengthDimension { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("TimeDimension")]
        public double TimeDimension { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("Name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("ID")]
        public System.Guid ID { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("UnitChoices")]
        public System.Collections.Generic.ICollection<UnitChoice> UnitChoices { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("MassDimension")]
        public double MassDimension { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("TemperatureDimension")]
        public double TemperatureDimension { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("AmountSubstanceDimension")]
        public double AmountSubstanceDimension { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("ElectricCurrentDimension")]
        public double ElectricCurrentDimension { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("LuminousIntensityDimension")]
        public double LuminousIntensityDimension { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("PlaneAngleDimension")]
        public double PlaneAngleDimension { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("SolidAngleDimension")]
        public double SolidAngleDimension { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("MeaningfulPrecisionInSI")]
        public double? MeaningfulPrecisionInSI { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.2.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UnitChoice
    {

        [System.Text.Json.Serialization.JsonPropertyName("UnitName")]
        public string UnitName { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("UnitLabel")]
        public string UnitLabel { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("ID")]
        public System.Guid ID { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("ConversionFactorFromSI")]
        public double ConversionFactorFromSI { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("ConversionBiasFromSI")]
        public double ConversionBiasFromSI { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("IsSI")]
        public bool IsSI { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.2.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataConversion
    {

        [System.Text.Json.Serialization.JsonPropertyName("DataIn")]
        public double DataIn { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("DataOut")]
        public double? DataOut { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("DataOutString")]
        public string DataOutString { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("DataOutUnitChoiceLabel")]
        public string DataOutUnitChoiceLabel { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("Conversion")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public ConversionType Conversion { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.2.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum ConversionType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"FromSI")]
        FromSI = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"ToSI")]
        ToSI = 1,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.2.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataUnitConversionSet
    {

        [System.Text.Json.Serialization.JsonPropertyName("ID")]
        public System.Guid ID { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("Name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("Description")]
        public string Description { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("ReferenceUnitChoiceSetID")]
        public System.Guid ReferenceUnitChoiceSetID { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("QuantityUnitConversions")]
        public System.Collections.Generic.ICollection<QuantityUnitConversion> QuantityUnitConversions { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.2.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class QuantityDataConversion
    {

        [System.Text.Json.Serialization.JsonPropertyName("DataIn")]
        public double DataIn { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("DataOut")]
        public double? DataOut { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("DataOutString")]
        public string DataOutString { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("DataOutUnitChoiceLabel")]
        public string DataOutUnitChoiceLabel { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("Conversion")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public ConversionType Conversion { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("ID")]
        public System.Guid ID { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("QuantityID")]
        public System.Guid QuantityID { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("UnitChoiceID")]
        public System.Guid UnitChoiceID { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.2.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class QuantityUnitConversion
    {

        [System.Text.Json.Serialization.JsonPropertyName("PhysicalQuantityID")]
        public System.Guid PhysicalQuantityID { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("DataConversions")]
        public System.Collections.Generic.ICollection<DataConversion> DataConversions { get; set; }

    }



}

#pragma warning restore  108
#pragma warning restore  114
#pragma warning restore  472
#pragma warning restore  612
#pragma warning restore 1573
#pragma warning restore 1591
#pragma warning restore 8073
#pragma warning restore 3016
#pragma warning restore 8603
#pragma warning restore 8604
#pragma warning restore 8625
