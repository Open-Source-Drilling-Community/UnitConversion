using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace OSDC.UnitConversion.DrillingUnitConversion.ModelClientShared
{
    public partial class MetaInfo
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public MetaInfo() : base()
        {
        }

        /// <summary>
        /// constructor
        /// </summary>
        [JsonConstructor]
        public MetaInfo(Guid id, string name, string descr, string typeName,
                Dictionary<string, bool> flags,
                Dictionary<string, Guid> filterIDs,
                Dictionary<string, string> labels,
                Dictionary<string, double> values)
        {
            ID = id;
            Name = name;
            Description = descr;
            TypeName = typeName;
            CreationDate = DateTime.UtcNow;
            LastModificationDate = CreationDate;
            Flags = flags;
            FilterIDs = filterIDs;
            Labels = labels;
            Values = values;

        }

        /// <summary>
        /// constructor
        /// </summary>
        public MetaInfo(Guid id) :
            this(id, "", "", typeof(object).Name,
                new Dictionary<string, bool>(),
                new Dictionary<string, Guid>(),
                new Dictionary<string, string>(),
                new Dictionary<string, double>())
        {
        }

        /// <summary>
        /// constructor
        /// </summary>
        public MetaInfo(Guid id, string name) :
            this(id, name, "", typeof(object).Name,
                new Dictionary<string, bool>(),
                new Dictionary<string, Guid>(),
                new Dictionary<string, string>(),
                new Dictionary<string, double>())
        {
        }

        /// <summary>
        /// constructor
        /// </summary>
        public MetaInfo(Guid id, string name, string descr, Dictionary<string, bool> flags) :
            this(id, name, descr, typeof(object).Name,
                flags,
                new Dictionary<string, Guid>(),
                new Dictionary<string, string>(),
                new Dictionary<string, double>())
        {
        }

        /// <summary>
        /// constructor
        /// </summary>
        public MetaInfo(Guid id, string name, string descr, string typeName, Dictionary<string, Guid> filterIDs) :
            this(id, name, descr, typeName,
                new Dictionary<string, bool>(),
                filterIDs,
                new Dictionary<string, string>(),
                new Dictionary<string, double>())
        {
        }

        /// <summary>
        /// Serialize a MetaInfo to Json
        /// </summary>
        /// <returns></returns>
        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        /// <summary>
        /// deserialize a string that is expected to be in Json into an instance of MetaInfo
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static MetaInfo FromJson(string str)
        {
            MetaInfo value = null;
            if (!string.IsNullOrEmpty(str))
            {
                try
                {
                    value = JsonConvert.DeserializeObject<MetaInfo>(str);
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



