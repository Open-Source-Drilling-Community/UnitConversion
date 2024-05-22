using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using OSDC.UnitConversion.Conversion;
using OSDC.UnitConversion.Conversion.DrillingEngineering;

namespace OSDC.UnitConversion.DrillingUnitConversion.Model
{
    public class DataUnitConversionSet
    {
        /// <summary>
        /// an ID for the DataUnitConversionSet, typed as a string to support GUID
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// name of the DataUnitConversionSet
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// a description for the DataUnitConversionSet
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// the ID reference DrillingUnitChoiceSet
        /// </summary>
        public Guid ReferenceUnitChoiceSetID { get; set; }

        /// <summary>
        /// the list of QuantityUnitConversions
        /// </summary>
        public List<QuantityUnitConversion> QuantityUnitConversions { get; set; }

        /// <summary>
        /// default constructor required for parsing the data model as a json file
        /// </summary>
        public DataUnitConversionSet() : base()
        {
        }

        /// <summary>
        /// copy constructor
        /// </summary>
        public DataUnitConversionSet(DataUnitConversionSet src)
        {
            if (src != null)
            {
                ID = src.ID;
                Name = src.Name;
                Description = src.Description;
                ReferenceUnitChoiceSetID = src.ReferenceUnitChoiceSetID;
                QuantityUnitConversions ??= new List<QuantityUnitConversion>();
                QuantityUnitConversions.Clear();
                if (src.QuantityUnitConversions != null)
                {
                    foreach (QuantityUnitConversion conversion in src.QuantityUnitConversions)
                    {
                        QuantityUnitConversions.Add(new QuantityUnitConversion(conversion));
                    }
                }

            }
        }

        /// <summary>
        ///  performs the calculation for the output of type UnitConversionSet
        /// </summary>
        /// <returns></returns>
        public bool CalculateOutputUnitConversionSet()
        {
            bool success = false;
            if (ReferenceUnitChoiceSetID != Guid.Empty && QuantityUnitConversions != null)
            {
                UnitChoiceSet unitChoiceSet = DrillingUnitChoiceSet.Get(ReferenceUnitChoiceSetID);
                if (unitChoiceSet != null)
                {
                    success = true;
                    foreach (QuantityUnitConversion quantityConversion in QuantityUnitConversions)
                    {
                        success &= CalculateOutputUnitConversionSet(unitChoiceSet, quantityConversion);
                    }
                }
            }
            return success;
        }

        private bool CalculateOutputUnitConversionSet(UnitChoiceSet unitChoiceSet, QuantityUnitConversion quantityConversion)
        {
            bool success = false;
            if (unitChoiceSet != null && quantityConversion != null && quantityConversion.PhysicalQuantityID != Guid.Empty)
            {
                PhysicalQuantity quantity = DrillingPhysicalQuantity.GetQuantity(quantityConversion.PhysicalQuantityID);
                if (quantity != null)
                {
                    success = true;
                    string userChoiceLabel = unitChoiceSet.GetUnitLabel(quantity.ID);
                    string SILabel = quantity.SIUnitLabel;
                    foreach (DataConversion conv in quantityConversion.DataConversions)
                    {
                        if (conv != null)
                        {
                            switch (conv.Conversion)
                            {
                                case DataConversion.ConversionType.FromSI:
                                    conv.DataOut = unitChoiceSet.FromSI(quantity.ID, conv.DataIn);
                                    conv.DataOutString = unitChoiceSet.FromSIString(quantity.ID, conv.DataIn);
                                    conv.DataOutUnitChoiceLabel = userChoiceLabel;
                                    success &= conv.DataOut != null && !string.IsNullOrEmpty(conv.DataOutString);
                                    break;
                                default:
                                    conv.DataOut = unitChoiceSet.ToSI(quantity.ID, conv.DataIn);
                                    conv.DataOutString = unitChoiceSet.ToSIString(quantity.ID, conv.DataIn);
                                    conv.DataOutUnitChoiceLabel = SILabel;
                                    success &= conv.DataOut != null;
                                    break;
                            }
                        }
                    }
                }
            }
            return success;
        }
    }
}
