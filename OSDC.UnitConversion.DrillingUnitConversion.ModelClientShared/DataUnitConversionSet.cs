using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.DrillingUnitConversion.ModelClientShared
{
    public partial class DataUnitConversionSet
    {
        /// <summary>
        /// main constructor (the exact copy of the original from namespace OSDC.UnitConversion.DrillingUnitConversion.Model
        /// </summary>
        [JsonConstructor]
        public DataUnitConversionSet(Guid guid, string name, string descr, Guid unitChoiceSetID, List<QuantityUnitConversion> conversions)
        {
            ID = guid;
            Name = name;
            Description = descr;
            ReferenceUnitChoiceSetID = unitChoiceSetID;
            if (QuantityUnitConversions == null)
            {
                QuantityUnitConversions = new List<QuantityUnitConversion>();
            }
            QuantityUnitConversions.Clear();
            if (conversions != null)
            {
                foreach (QuantityUnitConversion conversion in conversions)
                {
                    QuantityUnitConversions.Add(new QuantityUnitConversion(conversion));
                }
            }
        }

        /// <summary>
        /// Serialize a DataUnitConversionSet to Json
        /// </summary>
        /// <returns></returns>
        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        /// <summary>
        /// deserialize a string that is expected to be in Json into an instance of DataUnitConversionSet
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DataUnitConversionSet FromJson(string str)
        {
            DataUnitConversionSet values = null;
            if (!string.IsNullOrEmpty(str))
            {
                try
                {
                    values = JsonConvert.DeserializeObject<DataUnitConversionSet>(str);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return values;
        }
    }
}
