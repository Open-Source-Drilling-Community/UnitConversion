using System;
using Newtonsoft.Json;

namespace OSDC.UnitConversion.DrillingUnitConversion.ModelClientShared
{
    public partial class QuantityDataConversion : DataConversion
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public QuantityDataConversion() : base()
        {

        }
        /// <summary>
        /// copy constructor
        /// </summary>
        /// <param name="src"></param>
        public QuantityDataConversion(QuantityDataConversion src) : base(src)
        {
            if (src != null)
            {
                ID = src.ID;
                QuantityID = src.QuantityID;
            }
        }
        /// <summary>
        /// Serialize a QuantityDataConversion to Json
        /// </summary>
        /// <returns></returns>
        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        /// <summary>
        /// deserialize a string that is expected to be in Json into an instance of QuantityDataConversion
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static QuantityDataConversion FromJson(string str)
        {
            QuantityDataConversion values = null;
            if (!string.IsNullOrEmpty(str))
            {
                try
                {
                    values = JsonConvert.DeserializeObject<QuantityDataConversion>(str);
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
