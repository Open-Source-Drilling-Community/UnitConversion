using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Globalization;

namespace OSDC.UnitConversion.Conversion
{
    public partial class BasePhysicalQuantity
    {
        private static List<BasePhysicalQuantity> availableBasePhysicalQuantities_ = null;
        private static Dictionary<Guid, BasePhysicalQuantity> basePhysicalQuantitiesByGuid_ = null;
        private static Dictionary<string, BasePhysicalQuantity> basePhysicalQuantitiesByName_ = null;

        protected Dictionary<string, UnitChoice> unitChoicesByName_ = new Dictionary<string, UnitChoice>();
        protected Dictionary<Guid, UnitChoice> unitChoicesByGuid_ = new Dictionary<Guid, UnitChoice>();

        public static List<BasePhysicalQuantity> AvailableBasePhysicalQuantities
        {
            get
            {
                if (availableBasePhysicalQuantities_ == null)
                {
                    Initialize();
                }
                return availableBasePhysicalQuantities_;
            }
        }

        /// <summary>
        /// the name of the physical quantity
        /// </summary>
        public string Name { get; protected set; } = null;
        /// <summary>
        /// the guid for that physical quantity
        /// </summary>
        public Guid ID { get; protected set; } = Guid.Empty;
        /// <summary>
        /// usual names of the physical quantity
        /// </summary>
        public HashSet<string> UsualNames { get; protected set; }
        /// <summary>
        /// the SI unit name for this base unit
        /// </summary>
        public virtual string SIUnitName { get; }
        /// <summary>
        /// the SI unit symbol for this base unit
        /// </summary>
        public virtual string SIUnitLabel { get; }
        /// <summary>
        /// the possible non SI unit choices for this base unit
        /// </summary>
        public List<UnitChoice> UnitChoices { get; protected set; } = null;
        /// <summary>
        /// the physical dimension for length, abbreviated L
        /// </summary>
        public virtual double LengthDimension { get; } = 0;
        /// <summary>
        /// the physical dimension for mass, abbreviated M
        /// </summary>
        public virtual double MassDimension { get; } = 0;
        /// <summary>
        /// the physical dimension for time, abbreviated T
        /// </summary>
        public virtual double TimeDimension { get; } = 0;
        /// <summary>
        /// the physical dimension for temperature, abbreviated K
        /// </summary>
        public virtual double TemperatureDimension { get; } = 0;
        /// <summary>
        /// the physical dimension for amount of substance, abbreviated N
        /// </summary>
        public virtual double AmountSubstanceDimension { get; } = 0;
        /// <summary>
        /// the physical dimension for electric current, abbreviated I
        /// </summary>
        public virtual double ElectricCurrentDimension { get; } = 0;
        /// <summary>
        /// the physicsal dimension for luminous intensity, abbreviated J
        /// </summary>
        public virtual double LuminousIntensityDimension { get; } = 0;
        /// <summary>
        /// the physical dimension for angles in a plane, abbreviated θ
        /// </summary>
        public virtual double PlaneAngleDimension { get; } = 0;
        /// <summary>
        /// the physical dimension for solid angle, abbreviated Ω
        /// </summary>
        public virtual double SolidAngleDimension { get; } = 0;
        /// the smallest absolute value of the quantity that makes any sense with regards to its usage
        /// ex: drilling depth 0.001m, pipe diameter 0.0001m
        public virtual double? MeaningfulPrecisionInSI { get; } = null;
        /// <summary>
        /// the symbol used for this base unit in physical quantity descriptions: L, T, M, ...
        /// </summary>
        public virtual string TypicalSymbol { get; } = null;

        //////////////////////
        /// Static methods ///
        //////////////////////
        
        private static void Initialize()
        {
            Assembly assembly = Assembly.GetAssembly(typeof(BasePhysicalQuantity));
            if (assembly != null)
            {
                foreach (Type typ in assembly.GetTypes())
                {
                    if (typ.IsSubclassOf(typeof(BasePhysicalQuantity)))
                    {
                        MethodInfo method = null;
                        foreach (MethodInfo meth in typ.GetMethods())
                        {
                            if (meth.IsStatic &&
                                meth.Name.EndsWith("Instance") &&
                                meth.ReturnType.IsSubclassOf(typeof(BasePhysicalQuantity)))
                            {
                                method = meth;
                                break;
                            }
                        }
                        // call the method
                        if (method != null)
                        {
                            object obj = method.Invoke(null, null);
                            if (obj != null)
                            {
                                var res = (BasePhysicalQuantity)obj;
                                if (availableBasePhysicalQuantities_ == null)
                                {
                                    availableBasePhysicalQuantities_ = new List<BasePhysicalQuantity>();
                                }
                                availableBasePhysicalQuantities_.Add(res);
                                if (basePhysicalQuantitiesByGuid_ == null)
                                {
                                    basePhysicalQuantitiesByGuid_ = new Dictionary<Guid, BasePhysicalQuantity>();
                                }
                                if (res.ID != Guid.Empty && !basePhysicalQuantitiesByGuid_.ContainsKey(res.ID))
                                {
                                    basePhysicalQuantitiesByGuid_.Add(res.ID, res);
                                }
                                else
                                {
                                    throw new Exception("problem with ID of physical quantity");
                                }
                                if (basePhysicalQuantitiesByName_ == null)
                                {
                                    basePhysicalQuantitiesByName_ = new Dictionary<string, BasePhysicalQuantity>();
                                }
                                if (!string.IsNullOrEmpty(res.Name) && !basePhysicalQuantitiesByName_.ContainsKey(res.Name))
                                {
                                    basePhysicalQuantitiesByName_.Add(res.Name, res);
                                }
                                else
                                {
                                    throw new Exception("problem with name of physical quantity");
                                }
                            }
                        }
                    }
                }
            }
        }
        public static BasePhysicalQuantity GetQuantity(Guid ID)
        {
            BasePhysicalQuantity quantity = null;
            if (basePhysicalQuantitiesByGuid_ == null)
            {
                Initialize();
            }
            basePhysicalQuantitiesByGuid_.TryGetValue(ID, out quantity);
            return quantity;
        }
        public static BasePhysicalQuantity GetQuantity(string name)
        {
            BasePhysicalQuantity quantity = null;
            if (basePhysicalQuantitiesByName_ == null)
            {
                Initialize();
            }
            basePhysicalQuantitiesByName_.TryGetValue(name, out quantity);
            return quantity;
        }
        public static BasePhysicalQuantity GetQuantity(BasePhysicalQuantity.QuantityEnum choice)
        {
            BasePhysicalQuantity quantity = null;
            Guid guid;
            if (enumLookUp_.TryGetValue(choice, out guid))
            {
                if (basePhysicalQuantitiesByGuid_ == null)
                {
                    Initialize();
                }
                basePhysicalQuantitiesByGuid_.TryGetValue(guid, out quantity);
            }
            return quantity;
        }
        /// <summary>
        /// Getting assemblies is much harder than you think, be really cautious:
        /// https://dotnetcoretutorials.com/2020/07/03/getting-assemblies-is-harder-than-you-think-in-c/
        /// </summary>
        /// <returns></returns>
        private static Assembly[] GetAllAssemblies()
        {
            var assemblies = System.IO.Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll").Select(x => Assembly.Load(AssemblyName.GetAssemblyName(x)));
            var returnAssemblies = new List<Assembly>();
            var loadedAssemblies = new HashSet<string>();
            var assembliesToCheck = new Queue<Assembly>();

            assembliesToCheck.Enqueue(Assembly.GetEntryAssembly());

            while (assembliesToCheck.Any())
            {
                var assemblyToCheck = assembliesToCheck.Dequeue();

                foreach (var reference in assemblyToCheck.GetReferencedAssemblies())
                {
                    if (!loadedAssemblies.Contains(reference.FullName))
                    {
                        var assembly = Assembly.Load(reference);
                        assembliesToCheck.Enqueue(assembly);
                        loadedAssemblies.Add(reference.FullName);
                        returnAssemblies.Add(assembly);
                    }
                }
            }
            return returnAssemblies.ToArray();
        }

        //////////////////////////////
        /// Administration methods ///
        //////////////////////////////
        
        protected void Reset()
        {
            if (UnitChoices == null)
            {
                UnitChoices = new List<UnitChoice>();
            }
            UnitChoices.Clear();
            unitChoicesByName_.Clear();
            unitChoicesByGuid_.Clear();
        }
        protected void PostProcess()
        {
            if (UnitChoices != null)
            {
                foreach (UnitChoice choice in UnitChoices)
                {
                    if (!unitChoicesByName_.ContainsKey(choice.UnitName))
                    {
                        unitChoicesByName_.Add(choice.UnitName, choice);
                    }
                    else
                    {
                        throw new Exception("duplicate unit choice name");
                    }
                    if (!unitChoicesByGuid_.ContainsKey(choice.ID))
                    {
                        unitChoicesByGuid_.Add(choice.ID, choice);
                    }
                    else
                    {
                        throw new Exception("duplicate unit choice Guid");
                    }
                }
            }
        }

        ///////////////////////
        /// Utility methods ///
        ///////////////////////

        /// <summary>
        /// return an alphabetically sorted list of the unit choice names
        /// </summary>
        /// <returns></returns>
        public List<string> GetUnitChoiceNames()
        {
            if (UnitChoices != null)
            {
                List<string> choices = new List<string>(UnitChoices.Count);
                foreach (UnitChoice choice in UnitChoices)
                {
                    choices.Add(choice.UnitName);
                }
                choices.Sort();
                return choices;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// return a dictionary of the unit choice names and IDs
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, Guid> GetUnitChoiceIDs()
        {
            if (UnitChoices != null)
            {
                Dictionary<string, Guid> dict = new Dictionary<string, Guid>();
                foreach (UnitChoice choice in UnitChoices)
                {
                    dict.Add(choice.UnitName, choice.ID);
                }
                return dict;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// return the unit choice correpsonding to guid
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public UnitChoice GetUnitChoice(Guid guid)
        {
            UnitChoice c = null;
            if (unitChoicesByGuid_ != null && unitChoicesByGuid_.ContainsKey(guid))
            {
                unitChoicesByGuid_.TryGetValue(guid, out c);
            }
            return c;
        }
        /// <summary>
        /// return the unit choice corresponding to unitChoiceName
        /// </summary>
        /// <param name="unitChoiceName"></param>
        /// <returns></returns>
        public UnitChoice GetUnitChoice(string unitChoiceName)
        {
            UnitChoice c = null;
            if (unitChoicesByName_ != null && unitChoicesByName_.ContainsKey(unitChoiceName))
            {
                unitChoicesByName_.TryGetValue(unitChoiceName, out c);
            }
            return c;
        }
        /// <summary>
        /// convert a SI value into the unit choice, given a UnitChoice name
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unitChoiceName"></param>
        /// <returns>the converted value typed as a double</returns>
        public double FromSI(double value, string unitChoiceName)
        {
            UnitChoice unitChoice;
            if (unitChoicesByName_.TryGetValue(unitChoiceName, out unitChoice))
            {
                return unitChoice.FromSI(value);
            }
            else
            {
                throw new Exception("unknown unit choice");
            }
        }
        /// <summary>
        /// convert a SI value into the unit choice, given a UnitChoice ID
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unitChoiceID"></param>
        /// <returns>the converted value typed as a double</returns>
        public double FromSI(double value, Guid unitChoiceID)
        {
            UnitChoice unitChoice;
            if (unitChoicesByGuid_.TryGetValue(unitChoiceID, out unitChoice))
            {
                return unitChoice.FromSI(value);
            }
            else
            {
                throw new Exception("unknown unit choice");
            }
        }
        /// <summary>
        /// convert a SI value into the unit choice, given a UnitChoice name
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unitChoiceName"></param>
        /// <returns>the converted value typed as a string</returns>
        public string FromSIString(double value, string unitChoiceName)
        {
            UnitChoice unitChoice;
            if (unitChoicesByName_.TryGetValue(unitChoiceName, out unitChoice))
            {
                if (MeaningfulPrecisionInSI != null)
                {
                    return unitChoice.FromSI(value, MeaningfulPrecisionInSI);
                } else
                {
                    return unitChoice.FromSI(value).ToString(CultureInfo.InvariantCulture.NumberFormat);
                }
            }
            else
            {
                throw new Exception("unknown unit choice");
            }
        }
        /// <summary>
        /// convert a SI value into the unit choice, given a UnitChoice ID
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unitChoiceID"></param>
        /// <returns>the converted value typed as a string</returns>
        public string FromSIString(double value, Guid unitChoiceID)
        {
            UnitChoice unitChoice;
            if (unitChoicesByGuid_.TryGetValue(unitChoiceID, out unitChoice))
            {
                if (MeaningfulPrecisionInSI != null)
                {
                    return unitChoice.FromSI(value, MeaningfulPrecisionInSI);
                }
                else
                {
                    return unitChoice.FromSI(value).ToString(CultureInfo.InvariantCulture.NumberFormat);
                }
            }
            else
            {
                throw new Exception("unknown unit choice");
            }
        }
        /// <summary>
        /// convert a value from the unit choice to SI unit, given a UnitChoice ID
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unitChoiceName"></param>
        /// <returns>the converted value typed as a double</returns>
        public double ToSI(double value, Guid unitChoiceID)
        {
            UnitChoice unitChoice;
            if (unitChoicesByGuid_.TryGetValue(unitChoiceID, out unitChoice))
            {
                return unitChoice.ToSI(value);
            }
            else
            {
                throw new Exception("unknown unit choice");
            }
        }
        /// <summary>
        /// convert a value from the unit choice to SI unit, given a UnitChoice name
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unitChoiceName"></param>
        /// <returns>the converted value typed as a double</returns>
        public double ToSI(double value, string unitChoiceName)
        {
            UnitChoice unitChoice;
            if (unitChoicesByName_.TryGetValue(unitChoiceName, out unitChoice))
            {
                return unitChoice.ToSI(value);
            }
            else
            {
                throw new Exception("unknown unit choice");
            }
        }
        /// <summary>
        /// convert a value from the unit choice to SI unit, given a UnitChoice ID
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unitChoiceID"></param>
        /// <returns>the converted value typed as a string</returns>
        public string ToSIString(double value, Guid unitChoiceID)
        {
            UnitChoice unitChoice;
            if (unitChoicesByGuid_.TryGetValue(unitChoiceID, out unitChoice))
            {
                if (MeaningfulPrecisionInSI != null)
                {
                    return unitChoice.ToSI(value, MeaningfulPrecisionInSI);
                }
                else
                {
                    return unitChoice.ToSI(value).ToString(CultureInfo.InvariantCulture.NumberFormat);
                }
            }
            else
            {
                throw new Exception("unknown unit choice");
            }
        }
        /// <summary>
        /// convert a value from the unit choice to SI unit
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unitChoiceName"></param>
        /// <returns>the converted value typed as a string</returns>
        public string ToSIString(double value, string unitChoiceName)
        {
            UnitChoice unitChoice;
            if (unitChoicesByName_.TryGetValue(unitChoiceName, out unitChoice))
            {
                if (MeaningfulPrecisionInSI != null)
                {
                    return unitChoice.ToSI(value, MeaningfulPrecisionInSI);
                }
                else
                {
                    return unitChoice.ToSI(value).ToString(CultureInfo.InvariantCulture.NumberFormat);
                }
            }
            else
            {
                throw new Exception("unknown unit choice");
            }
        }
     }
}
