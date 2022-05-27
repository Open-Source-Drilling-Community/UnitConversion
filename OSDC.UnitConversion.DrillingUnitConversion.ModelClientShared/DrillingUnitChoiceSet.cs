using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OSDC.UnitConversion.DrillingUnitConversion.ModelClientShared
{
    public partial class DrillingUnitChoiceSet
    {
        /// <summary>
        /// main constructor (the exact copy of the original from namespace OSDC.UnitConversion.DrillingUnitConversion.Model
        /// </summary>
        public DrillingUnitChoiceSet(Guid guid, string name, string descr, Dictionary<string, string> choices)
        {
            ID = guid;
            Name = name;
            Description = descr;
            Choices = choices;
        }

        /// <summary>
        /// Serialize a UnitConversionSet to Json
        /// </summary>
        /// <returns></returns>
        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        /// <summary>
        /// deserialize a string that is expected to be in Json into an instance of UnitConversionSet
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DrillingUnitChoiceSet FromJson(string str)
        {
            DrillingUnitChoiceSet values = null;
            if (!string.IsNullOrEmpty(str))
            {
                try
                {
                    values = JsonConvert.DeserializeObject<DrillingUnitChoiceSet>(str);
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
