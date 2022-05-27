namespace OSDC.UnitConversion.DrillingUnitConversion.Model
{
    public static class DataUtils
    {
        //default values
        public const double DEFAULT_VALUE = 999.25; // this value is duplicated in namespace DrillingUnitConversion.ModelClientShared because default values cannot be passed through the json conversion process
        public static string DEFAULT_NAME = "DefaultName";
        public static string DEFAULT_DESCR = "Default description";
        public static string DEFAULT_SUFFIX_TPLSUBDATA1 = "-tplSubData1";
        public static string DEFAULT_SUFFIX_TPLITERDATA1 = "-drillingPhysicalQuantity";
        public static string DEFAULT_SUFFIX_OUTPUT = "-output";

        //unit conversion constants
        public const double TO_PERCENT = 100.0;
    }
}
