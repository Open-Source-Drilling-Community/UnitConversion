using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Globalization;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public partial class PhysicalQuantity
    {
        private static List<PhysicalQuantity> availableQuantities_ = null;
        private static Dictionary<Guid, PhysicalQuantity> physicalQuantitiesByGuid_ = null;
        private static Dictionary<string, PhysicalQuantity> physicalQuantitiesByName_ = null;

        public static List<PhysicalQuantity> AvailableQuantities
        {
            get
            {
                if (availableQuantities_ == null)
                {
                    Initialize();
                }
                return availableQuantities_;
            }
        }

        private static void Initialize()
        {
            Assembly assembly = Assembly.GetAssembly(typeof(PhysicalQuantity));
            if (assembly != null)
            {
                foreach (Type typ in assembly.GetTypes())
                {
                    if (typ.IsSubclassOf(typeof(PhysicalQuantity)))
                    {
                        MethodInfo method = null;
                        foreach (MethodInfo meth in typ.GetMethods())
                        {
                            if (meth.IsStatic &&
                                meth.Name.EndsWith("Instance") &&
                                meth.ReturnType.IsSubclassOf(typeof(PhysicalQuantity)))
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
                                var res = (PhysicalQuantity)obj;
                                if (availableQuantities_ == null)
                                {
                                    availableQuantities_ = new List<PhysicalQuantity>();
                                }
                                availableQuantities_.Add(res);
                                if (physicalQuantitiesByGuid_ == null)
                                {
                                    physicalQuantitiesByGuid_ = new Dictionary<Guid, PhysicalQuantity>();
                                }
                                if (res.ID != Guid.Empty && !physicalQuantitiesByGuid_.ContainsKey(res.ID))
                                {
                                    physicalQuantitiesByGuid_.Add(res.ID, res);
                                }
                                else
                                {
                                    throw new Exception("problem with ID of physical quantity");
                                }
                                if (physicalQuantitiesByName_ == null)
                                {
                                    physicalQuantitiesByName_ = new Dictionary<string, PhysicalQuantity>();
                                }
                                if (!string.IsNullOrEmpty(res.Name) && !physicalQuantitiesByName_.ContainsKey(res.Name))
                                {
                                    physicalQuantitiesByName_.Add(res.Name, res);
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

        public static PhysicalQuantity GetQuantity(Guid ID)
        {
            PhysicalQuantity quantity = null;
            if (physicalQuantitiesByGuid_ == null)
            {
                Initialize();
            }
            physicalQuantitiesByGuid_.TryGetValue(ID, out quantity);
            return quantity;
        }

        public static PhysicalQuantity GetQuantity(string name)
        {
            PhysicalQuantity quantity = null;
            if (physicalQuantitiesByName_ == null)
            {
                Initialize();
            }
            physicalQuantitiesByName_.TryGetValue(name, out quantity);
            return quantity;
        }

        public static PhysicalQuantity GetQuantity(PhysicalQuantity.QuantityEnum choice)
        {
            PhysicalQuantity quantity = null;
            Guid guid;
            if (enumLookUp_.TryGetValue(choice, out guid))
            {
                if (physicalQuantitiesByGuid_ == null)
                {
                    Initialize();
                }
                physicalQuantitiesByGuid_.TryGetValue(guid, out quantity);
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

        protected Dictionary<string, UnitChoice> unitChoicesByName_ = new Dictionary<string, UnitChoice>();
        protected Dictionary<Guid, UnitChoice> unitChoicesByGuid_ = new Dictionary<Guid, UnitChoice>();

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

        /// <summary>
        /// the name of the physical quantity
        /// </summary>
        public string Name { get; protected set; } = null;
        /// <summary>
        /// the guid for that physical quantity
        /// </summary>
        public Guid ID { get; protected set; } = Guid.Empty;
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
        /// the physical dimension for length
        /// </summary>
        public virtual double LengthDimension { get; } = 0;
        /// <summary>
        /// the physical dimension for mass
        /// </summary>
        public virtual double MassDimension { get; } = 0;
        /// <summary>
        /// the physical dimension for time
        /// </summary>
        public virtual double TimeDimension { get; } = 0;
        /// <summary>
        /// the physical dimension for temperature
        /// </summary>
        public virtual double TemperatureDimension { get; } = 0;
        /// <summary>
        /// the physical dimension for amount of substance
        /// </summary>
        public virtual double AmountSubstanceDimension { get;  } = 0;
        /// <summary>
        /// the physical dimension for electic current
        /// </summary>
        public virtual double ElectricCurrentDimension { get;  } = 0;
        /// <summary>
        /// the physicsl dimension for luminous intensity
        /// </summary>
        public virtual double LuminousIntensityDimension { get;  } = 0;
        /// <summary>
        /// the physical dimension for angles in a plane
        /// </summary>
        public virtual double PlaneAngleDimension { get;  } = 0;
        /// <summary>
        /// the physical dimension for solid angle
        /// </summary>
        public virtual double SolidAngleDimension { get;  } = 0;
        /// the smallest absolute value of the quantity that makes any sense with regards to its usage
        /// ex: drilling depth 0.001m, pipe diameter 0.0001m
        public virtual double? MeaningFullPrecisionInSI { get; } = null;
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
        /// convert a SI value into the unit choice
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unitChoiceName"></param>
        /// <returns></returns>
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
        /// convert a SI value into the unit choice
        /// </summary>
        /// <param name="value"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public double FromSI(double value, Guid ID)
        {
            UnitChoice unitChoice;
            if (unitChoicesByGuid_.TryGetValue(ID, out unitChoice))
            {
                return unitChoice.FromSI(value);
            }
            else
            {
                throw new Exception("unknown unit choice");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unitChoiceName"></param>
        /// <returns></returns>
        public string FromSIString(double value, string unitChoiceName)
        {
            UnitChoice unitChoice;
            if (unitChoicesByName_.TryGetValue(unitChoiceName, out unitChoice))
            {
                if (MeaningFullPrecisionInSI != null)
                {
                    return unitChoice.FromSI(value, MeaningFullPrecisionInSI);
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
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public string FromSIString(double value, Guid ID)
        {
            UnitChoice unitChoice;
            if (unitChoicesByGuid_.TryGetValue(ID, out unitChoice))
            {
                if (MeaningFullPrecisionInSI != null)
                {
                    return unitChoice.FromSI(value, MeaningFullPrecisionInSI);
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
        /// convert a value from the unit choice to SI unit
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unitChoiceName"></param>
        /// <returns></returns>
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
        /// convert a value from the unit choice to SI unit
        /// </summary>
        /// <param name="value"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public string ToSIString(double value, Guid ID)
        {
            UnitChoice unitChoice;
            if (unitChoicesByGuid_.TryGetValue(ID, out unitChoice))
            {
                if (MeaningFullPrecisionInSI != null)
                {
                    return unitChoice.ToSI(value, MeaningFullPrecisionInSI);
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
        /// <returns></returns>
        public string ToSIString(double value, string unitChoiceName)
        {
            UnitChoice unitChoice;
            if (unitChoicesByName_.TryGetValue(unitChoiceName, out unitChoice))
            {
                if (MeaningFullPrecisionInSI != null)
                {
                    return unitChoice.ToSI(value, MeaningFullPrecisionInSI);
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
