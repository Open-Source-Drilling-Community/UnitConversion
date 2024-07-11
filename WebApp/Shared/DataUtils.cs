using OSDC.UnitConversion.ModelShared;

public static class DataUtils
{
    // default values
    public const double DEFAULT_VALUE = 999.25;
    public static string DEFAULT_NAME_DataUnitConversionSet = "Default DataUnitConversionSet Name";
    public static string DEFAULT_DESCR_DataUnitConversionSet = "Default DataUnitConversionSet Description";
    public static string DEFAULT_NAME_QuantityUnitConversion = "Default QuantityUnitConversion Name";
    public static string DEFAULT_DESCR_QuantityUnitConversion = "Default QuantityUnitConversion Description";

    // unit management
    public static class UnitAndReferenceParameters
    {
        public static string? UnitChoiceSetName { get; set; } = "Metric";
        public static string? DepthReferenceName { get; set; }
        public static string? PositionReferenceName { get; set; }
        public static string? AzimuthReferenceName { get; set; }
        public static string? PressureReferenceName { get; set; }
        public static string? DateReferenceName { get; set; }
    }

    public static void UpdateUnitChoiceSetName(string? val)
    {
        if (val != null)
        {
            UnitAndReferenceParameters.UnitChoiceSetName = (string)val;
        }
    }

    //DataUnitConversionSet parameters units
    public static readonly string DataUnitConversionSetInputParamListLabel = "DataUnitConversionSetInputParamList";
    public static readonly string DataUnitConversionSetOutputParamLabel = "DataUnitConversionSetOutputParam";
    public static readonly string DataUnitConversionSetOutputParamQty = "Depth";
    public static readonly string OutputXValuesTitle = "Some depth value";
    public static readonly string OutputXValuesQty = "Depth";
    public static readonly string OutputYValuesTitle = "Some angle value";
    public static readonly string OutputYValuesQty = "DrillingPlaneAngle";

    //QuantityUnitConversion parameters units
    public static readonly string QuantityUnitConversionLabel = "QuantityUnitConversion name";
    public static readonly string QuantityUnitConversionParamLabel = "QuantityUnitConversionParam";
    public static readonly string QuantityUnitConversionParamQty = "Depth";
    public static readonly string InputXValuesTitle = "Other depth value";
    public static readonly string InputXValuesQty = "Depth";
    public static readonly string InputYValuesTitle = "Other angle value";
    public static readonly string InputYValuesQty = "DrillingPlaneAngle";

    public static readonly string UnidentifiedField = "Unidentified Field";
    public static Func<Field, string>
            ConverterFieldToName = field => (field != null && field.MetaInfo != null) ? field.MetaInfo.Name : UnidentifiedField;
}