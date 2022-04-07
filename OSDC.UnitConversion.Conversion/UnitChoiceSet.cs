using System;
using System.Collections.Generic;
using System.Text;

namespace OSDC.UnitConversion.Conversion
{
    public class UnitChoiceSet
    {
        private static UnitChoiceSet SIUnitChoiceSet_ = null;
        private static UnitChoiceSet MetricUnitChoiceSet_ = null;
        private static UnitChoiceSet ImperialUnitChoiceSet_ = null;
        private static UnitChoiceSet USUnitChoiceSet_ = null;

        public static UnitChoiceSet SIUnitChoiceSet
        {
            get
            {
                if (SIUnitChoiceSet_ == null)
                {
                    SIUnitChoiceSet_ = new UnitChoiceSet(UnitChoice.DefaultUnitSetChoiceEnum.SI);
                }
                return SIUnitChoiceSet_;
            }
        }

        public static UnitChoiceSet MetricUnitChoiceSet
        {
            get
            {
                if (MetricUnitChoiceSet_ == null)
                {
                    MetricUnitChoiceSet_ = new UnitChoiceSet(UnitChoice.DefaultUnitSetChoiceEnum.Metric);
                }
                return MetricUnitChoiceSet_;
            }
        }

        public static UnitChoiceSet ImperialUnitChoiceSet
        {
            get
            {
                if (ImperialUnitChoiceSet_ == null)
                {
                    ImperialUnitChoiceSet_ = new UnitChoiceSet(UnitChoice.DefaultUnitSetChoiceEnum.Imperial);
                }
                return ImperialUnitChoiceSet_;
            }
        }
        public static UnitChoiceSet USUnitChoiceSet
        {
            get
            {
                if (USUnitChoiceSet_ == null)
                {
                    USUnitChoiceSet_ = new UnitChoiceSet(UnitChoice.DefaultUnitSetChoiceEnum.US);
                }
                return USUnitChoiceSet_;
            }
        }

        private Dictionary<Guid, Guid> Choices { get; } = new Dictionary<Guid, Guid>();

        /// <summary>
        /// default constructor
        /// </summary>
        public UnitChoiceSet() : base()
        {

        }

        public UnitChoice GetChoice(Guid physicalQuantityID)
        {
            UnitChoice choice = null;
            Guid unitChoiceID;
            PhysicalQuantity quantity = PhysicalQuantity.GetQuantity(physicalQuantityID);
            if (quantity != null && Choices.TryGetValue(physicalQuantityID, out unitChoiceID))
            {
                if (unitChoiceID != Guid.Empty)
                {
                    choice = quantity.GetUnitChoice(unitChoiceID);
                }
            }
            return choice;
        }
        public UnitChoice GetChoice(string physicalQuantityName)
        {
            UnitChoice choice = null;
            Guid unitChoiceID;
            PhysicalQuantity quantity = PhysicalQuantity.GetQuantity(physicalQuantityName);
            if (quantity != null &&  Choices.TryGetValue(quantity.ID, out unitChoiceID))
            {
                if (unitChoiceID != Guid.Empty)
                {
                    choice = quantity.GetUnitChoice(unitChoiceID);
                }
            }
            return choice;
        }
        public UnitChoice GetChoice(PhysicalQuantity.QuantityEnum physicalQuantityID)
        {
            UnitChoice choice = null;
            Guid unitChoiceID;
            PhysicalQuantity quantity = PhysicalQuantity.GetQuantity(physicalQuantityID);
            if (quantity != null && Choices.TryGetValue(quantity.ID, out unitChoiceID))
            {
                if (unitChoiceID != Guid.Empty)
                {
                    choice = quantity.GetUnitChoice(unitChoiceID);
                }
            }
            return choice;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="defaultUnitChoice"></param>
        internal UnitChoiceSet(UnitChoice.DefaultUnitSetChoiceEnum defaultUnitChoice)
        {
            List<PhysicalQuantity> quantities = PhysicalQuantity.AvailableQuantities;
            if (quantities != null)
            {
                foreach (PhysicalQuantity quantity in quantities)
                {
                    if (quantity.ID != Guid.Empty)
                    {
                        Guid unitChoiceID = Guid.Empty;
                        foreach (UnitChoice unitChoice in quantity.UnitChoices)
                        {
                            if (unitChoice.IsDefault(defaultUnitChoice))
                            {
                                unitChoiceID = unitChoice.ID;
                                break;
                            }
                        }
                        if (unitChoiceID != Guid.Empty)
                        {
                            if (!Choices.ContainsKey(quantity.ID))
                            {
                                Choices.Add(quantity.ID, unitChoiceID);
                            }
                            else
                            {
                                throw new Exception("duplicate guid for physical quantity");
                            }
                        }
                        else
                        {
                            throw new Exception("missing default unit choice for this physical quantity");
                        }
                    }
                }
            }
        }
    }
}
