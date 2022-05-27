using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace OSDC.UnitConversion.Conversion.DrillingEngineering
{
    public partial class DrillingPhysicalQuantity : PhysicalQuantity
    {
        private static List<PhysicalQuantity> availableQuantities_ = null;
        internal static Dictionary<string, PhysicalQuantity> physicalQuantitiesByName_ = null;
        internal static Dictionary<Guid, PhysicalQuantity> physicalQuantitiesByGuid_ = null;
        public static new List<PhysicalQuantity> AvailableQuantities
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
            Assembly assembly = Assembly.GetAssembly(typeof(DrillingPhysicalQuantity));
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
                                    throw new Exception("problem with ID of drilling physical quantity");
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
                                    throw new Exception("problem with name of drilling physical quantity");
                                }
                            }
                        }
                    }
                }
            }
        }

        public static PhysicalQuantity GetQuantity(DrillingPhysicalQuantity.QuantityEnum choice)
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
        public static new PhysicalQuantity GetQuantity(Guid choiceID)
        {
            PhysicalQuantity quantity = null;
            if (physicalQuantitiesByGuid_ == null)
            {
                Initialize();
            }
            physicalQuantitiesByGuid_.TryGetValue(choiceID, out quantity);
            if (quantity == null)
            {
                quantity = PhysicalQuantity.GetQuantity(choiceID);
            }
            return quantity;
        }

        public static new PhysicalQuantity GetQuantity(string choiceName)
        {
            PhysicalQuantity quantity = null;
            if (physicalQuantitiesByName_ == null)
            {
                Initialize();
            }
            physicalQuantitiesByName_.TryGetValue(choiceName, out quantity);
            if (quantity == null)
            {
                quantity = PhysicalQuantity.GetQuantity(choiceName);
            }
            return quantity;
        }

    }
}
