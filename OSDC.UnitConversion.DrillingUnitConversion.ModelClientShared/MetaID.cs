using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.DrillingUnitConversion.ModelClientShared
{
    public partial class MetaID
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public MetaID() : base()
        {
        }

        /// <summary>
        /// constructor
        /// </summary>
        [JsonConstructor]
        public MetaID(Guid id, string name, string descr, string typeName, Dictionary<string, bool> flags, Dictionary<string, Guid> filterIDs)
        {
            ID = id;
            Name = name;
            Description = descr;
            TypeName = typeName;
            Flags = flags;
            FilterIDs = filterIDs;
        }

        /// <summary>
        /// constructor
        /// </summary>
        public MetaID(Guid id) :
            this(id, "", "", typeof(object).Name, new Dictionary<string, bool>(), new Dictionary<string, Guid>())
        {
        }

        /// <summary>
        /// constructor
        /// </summary>
        public MetaID(Guid id, string name) :
            this(id, name, "", typeof(object).Name, new Dictionary<string, bool>(), new Dictionary<string, Guid>())
        {
        }

        /// <summary>
        /// constructor
        /// </summary>
        public MetaID(Guid id, string name, string descr, Dictionary<string, bool> flags) :
            this(id, name, descr, typeof(object).Name, flags, new Dictionary<string, Guid>())
        {
        }

        /// <summary>
        /// constructor
        /// </summary>
        public MetaID(Guid id, string name, string descr, string typeName, Dictionary<string, Guid> filterIDs) :
            this(id, name, descr, typeName, new Dictionary<string, bool>(), filterIDs)
        {
        }

        /// <summary>
        /// Serialize a MetaID to Json
        /// </summary>
        /// <returns></returns>
        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        /// <summary>
        /// deserialize a string that is expected to be in Json into an instance of MetaID
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static MetaID FromJson(string str)
        {
            MetaID value = null;
            if (!string.IsNullOrEmpty(str))
            {
                try
                {
                    value = JsonConvert.DeserializeObject<MetaID>(str);
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



