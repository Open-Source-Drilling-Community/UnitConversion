using Newtonsoft.Json;
using System;

namespace OSDC.UnitConversion.DrillingUnitConversion.ModelClientShared
{
    public partial class PhysicalQuantity 
    {
        /// <summary>
        /// Serialize a DrillingPhysicalQuantity to Json
        /// </summary>
        /// <returns></returns>
        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        /// <summary>
        /// deserialize a string that is expected to be in Json into an instance of DrillingPhysicalQuantity
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static PhysicalQuantity FromJson(string str)
        {
            PhysicalQuantity value = null;
            if (!string.IsNullOrEmpty(str))
            {
                try
                {
                    value = JsonConvert.DeserializeObject<PhysicalQuantity>(str);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return value;
        }
    }
}

