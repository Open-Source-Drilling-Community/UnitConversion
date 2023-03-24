using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OSDC.UnitConversion.DrillingUnitConversion.ModelClientShared;
using System;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using OSDC.DotnetLibraries.General.DataManagement;

namespace OSDC.UnitConversion.DrillingUnitConversion.WebApp.Client.Shared
{
    public class APIUtils
    {
        public static HttpClient SetHttpClient(string host)
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(host + "DrillingUnitConversion/api/")
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        public static async Task<bool> PostDataUnitConversionSet(HttpClient httpClient, ILogger logger, DataUnitConversionSet request)
        {
            bool success = false;
            try
            {
                string json = request.GetJson();
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var a = await httpClient.PostAsync("DataUnitConversionSets", content);
                if (a.IsSuccessStatusCode)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Impossible to post DataUnitConversionSet");
            }
            if (success)
            {
                logger.LogInformation("Posted DataUnitConversionSet successfully");
                return true;
            }
            else
            {
                logger.LogWarning("Impossible to post DataUnitConversionSet");
                return false;
            }
        }

        public static async Task<DataUnitConversionSet> LoadDataUnitConversionSet(HttpClient httpClient, ILogger logger, Guid ID)
        {
            bool success = false;
            DataUnitConversionSet dataUnitConversionSet = null;
            try
            {
                var a = await httpClient.GetAsync("DataUnitConversionSets/" + ID.ToString());
                if (a.IsSuccessStatusCode)
                {
                    string str = await a.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(str))
                    {
                        dataUnitConversionSet = JsonConvert.DeserializeObject<DataUnitConversionSet>(str);
                        if (dataUnitConversionSet == null)
                            throw new NullReferenceException("Impossible to deserialize DataUnitConversionSet string:" + str);
                    }
                    success = true;
                }
                else
                {
                    logger.LogWarning("Impossible to get DataUnitConversionSes from controller");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Impossible to load DataUnitConversionSet");
            }
            if (success)
            {
                logger.LogInformation("Loaded DataUnitConversionSets successfully");
                return dataUnitConversionSet;
            }
            else
            {
                logger.LogWarning("Impossible to load DataUnitConversionSet");
                return null;
            }
        }
        public static async Task<bool> DeleteDataUnitConversionSet(HttpClient httpClient, ILogger logger, Guid ID)
        {
            bool success = false;
            try
            {
                var a = await httpClient.DeleteAsync("DataUnitConversionSets/" + ID.ToString());
                success = a.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Impossible to delete DataUnitConversionSet");
            }
            if (success)
            {
                logger.LogInformation("Deletion of  DataUnitConversionSets is successfull");
                return true;
            }
            else
            {
                logger.LogWarning("Impossible to delete DataUnitConversionSet");
                return false;
            }
        }
        public static async Task<List<MetaInfo>> LoadDrillingUnitChoiceSets(HttpClient httpClient, ILogger logger)
        {
            bool success = false;
            List<MetaInfo> unitChoiceSets = new();
            try
            {
                //ids of the existing UnitChoiceSets are retrieved first to keep controllers API standard
                var a = await httpClient.GetAsync("DrillingUnitChoiceSets");
                if (a.IsSuccessStatusCode)
                {
                    string str = await a.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(str))
                    {
                        unitChoiceSets = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MetaInfo>>(str);
                        success = true;
                    }
                }
                else
                {
                    logger.LogWarning("Impossible to get UnitConversionSets from controller");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Impossible to load DrillingUnitChoiceSets");
            }
            if (success)
            {
                unitChoiceSets.Sort((m1, m2) => String.Compare(m1.Name, m2.Name, false, new CultureInfo("nb-NO")));
                logger.LogInformation("Loaded UnitConversionSets successfully");
                return unitChoiceSets;
            }
            else
            {
                logger.LogWarning("Impossible to load DrillingUnitChoiceSets");
                return null;
            }
        }

        public static async Task<DrillingUnitChoiceSet> LoadDrillingUnitChoiceSets(HttpClient httpClient, ILogger logger, Guid unitChoiceSetID)
        {
            bool success = false;
            DrillingUnitChoiceSet unitChoiceSet = null;
            try
            {
                var a = await httpClient.GetAsync("DrillingUnitChoiceSets/" + unitChoiceSetID);
                if (a.IsSuccessStatusCode)
                {
                    string str = await a.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(str))
                    {
                        unitChoiceSet = Newtonsoft.Json.JsonConvert.DeserializeObject<DrillingUnitChoiceSet>(str);
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Impossible to load DrillingUnitChoiceSet");
            }
            if (success)
            {
                logger.LogInformation("Loaded DrillingUnitChoiceSet successfully");
                return unitChoiceSet;
            }
            else
            {
                logger.LogWarning("Impossible to load DrillingUnitChoiceSet");
                return null;
            }
        }

        public static async Task<bool> PostDrillingUnitConversionSet(HttpClient httpClient, ILogger logger, DrillingUnitChoiceSet request)
        {
            bool success = false;
            try
            {
                string json = request.GetJson();
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var a = await httpClient.PostAsync("DrillingUnitChoiceSets", content);
                if (a.IsSuccessStatusCode)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Impossible to post DrillingUnitChoiceSet");
            }
            if (success)
            {
                logger.LogInformation("Posted DrillingUnitChoiceSet successfully");
                return true;
            }
            else
            {
                logger.LogWarning("Impossible to post DrillingUnitChoiceSet");
                return false;
            }
        }

        public static async Task<bool> PutDrillingUnitConversionSet(HttpClient httpClient, ILogger logger, DrillingUnitChoiceSet request)
        {
            bool success = false;
            try
            {
                string json = request.GetJson();
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var a = await httpClient.PutAsync("DrillingUnitChoiceSets/" + request.ID.ToString(), content);
                if (a.IsSuccessStatusCode)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Impossible to put DrillingUnitChoiceSet");
            }
            if (success)
            {
                logger.LogInformation("Put DrillingUnitChoiceSet successfully");
                return true;
            }
            else
            {
                logger.LogWarning("Impossible to put DrillingUnitChoiceSet");
                return false;
            }
        }

        public static async Task<bool> DeleteDrillingUnitConversionSet(HttpClient httpClient, ILogger logger, Guid ID)
        {
            bool success = false;
            try
            {
                var a = await httpClient.DeleteAsync("DrillingUnitChoiceSets/" + ID.ToString());
                success = a.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Impossible to delete DrillingUnitChoiceSet");
            }
            if (success)
            {
                logger.LogInformation("Deletion of DrillingUnitChoiceSet is successfull");
                return true;
            }
            else
            {
                logger.LogWarning("Impossible to delete DrillingUnitChoiceSet");
                return false;
            }
        }

        public static async Task<List<PhysicalQuantity>> LoadDrillingPhysicalQuantities(HttpClient httpClient, ILogger logger)
        {
            bool success = false;
            List<PhysicalQuantity> drillingPhysicalQuantities = new();
            try
            {
                var a = await httpClient.GetAsync("DrillingPhysicalQuantities");
                if (a.IsSuccessStatusCode)
                {
                    List<MetaInfo> metaInfos = null;
                    string str = await a.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(str))
                    {
                        metaInfos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MetaInfo>>(str);
                    }
                    for (int i = 0; i < metaInfos.Count; i++)
                    {
                        a = await httpClient.GetAsync("DrillingPhysicalQuantities/" + metaInfos[i].ID.ToString());
                        if (a.IsSuccessStatusCode && a.Content != null)
                        {
                            str = await a.Content.ReadAsStringAsync();
                            if (!string.IsNullOrEmpty(str))
                            {
                                PhysicalQuantity drillingPhysicalQuantity = JsonConvert.DeserializeObject<PhysicalQuantity>(str);
                                if (drillingPhysicalQuantity == null)
                                    throw new NullReferenceException("Impossible to deserialize DrillingPhysicalQuantities string:" + str);
                                drillingPhysicalQuantities.Add(drillingPhysicalQuantity);
                            }
                        }
                    }
                    if (drillingPhysicalQuantities.Count != metaInfos.Count)
                        throw new Exception("Inconsistent count of DataUnitConversionSet-loaded IDs and loaded DrillingPhysicalQuantities. Verify that the database garbage collector is not set with a too small time update.");
                    success = true;
                }
                else
                {
                    logger.LogWarning("Impossible to get DrillingPhysicalQuantities from controller");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Impossible to load DrillingPhysicalQuantities");
            }
            if (success)
            {
                drillingPhysicalQuantities.Sort((dpq1, dpq2) => String.Compare(dpq1.Name, dpq2.Name, false, new CultureInfo("nb-NO")));
                logger.LogInformation("Loaded DrillingPhysicalQuantities successfully");
                return drillingPhysicalQuantities;
            }
            else
            {
                logger.LogWarning("Impossible to load DrillingPhysicalQuantities");
                return null;
            }
        }
        public static async Task<Guid[]> LoadQuantityDataConversions(HttpClient httpClient, ILogger logger)
        {
            bool success = false;
            Guid[] quantityDataConversionIDs = null;
            try
            {
                var a = await httpClient.GetAsync("QuantityDataConversions");
                if (a.IsSuccessStatusCode)
                {
                    string str = await a.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(str))
                    {
                        quantityDataConversionIDs = Newtonsoft.Json.JsonConvert.DeserializeObject<Guid[]>(str);
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Impossible to load QuantityDataConversions");
            }
            if (success)
            {
                logger.LogInformation("Loaded QuantityDataConversions successfully");
                return quantityDataConversionIDs;
            }
            else
            {
                logger.LogWarning("Impossible to load QuantityDataConversions");
                return null;
            }
        }

        public static async Task<PhysicalQuantity> LoadQuantity(HttpClient httpClient, ILogger logger, Guid quantityID)
        {
            bool success = false;
            PhysicalQuantity qantity = null;
            try
            {
                var a = await httpClient.GetAsync("DrillingPhysicalQuantities/" + quantityID);
                if (a.IsSuccessStatusCode)
                {
                    string str = await a.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(str))
                    {
                        qantity = Newtonsoft.Json.JsonConvert.DeserializeObject<PhysicalQuantity>(str);
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Impossible to load QuantityDataConversions");
            }
            if (success)
            {
                logger.LogInformation("Loaded QuantityDataConversions successfully");
                return qantity;
            }
            else
            {
                logger.LogWarning("Impossible to load QuantityDataConversions");
                return null;
            }
        }
        public static async Task<bool> PostQuantityChoice(HttpClient httpClient, ILogger logger, QuantityDataConversion request)
        {
            bool success = false;
            try
            {
                string json = request.GetJson();
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var a = await httpClient.PostAsync("QuantityDataConversions", content);
                if (a.IsSuccessStatusCode)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Impossible to post QuantityDataConversions");
            }
            if (success)
            {
                logger.LogInformation("Posted QuantityDataConversions successfully");
                return true;
            }
            else
            {
                logger.LogWarning("Impossible to post QuantityDataConversions");
                return false;
            }
        }
        public static async Task<QuantityDataConversion> GetQuantityChoice(HttpClient httpClient, ILogger logger, Guid ID)
        {
            bool success = false;
            QuantityDataConversion result = null;
            try
            {
                var a = await httpClient.GetAsync("QuantityDataConversions/" + ID.ToString());
                if (a.IsSuccessStatusCode)
                {
                    if (a.IsSuccessStatusCode)
                    {
                        string str = await a.Content.ReadAsStringAsync();
                        if (!string.IsNullOrEmpty(str))
                        {
                            result = Newtonsoft.Json.JsonConvert.DeserializeObject<QuantityDataConversion>(str);
                            success = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Impossible to load QuantityDataConversions");
            }
            if (success)
            {
                logger.LogInformation("Loaded QuantityDataConversions successfully");
                return result;
            }
            else
            {
                logger.LogWarning("Impossible to load QuantityDataConversions");
                return result;
            }
        }
        public static async Task<List<MetaInfo>> LoadUnitChoiceSets(HttpClient httpClient, ILogger logger)
        {
            bool success = false;
            List<MetaInfo> choices = new();
            try
            {
                //ids of the existing UnitChoiceSets are retrieved first to keep controllers API standard
                var a = await httpClient.GetAsync("DrillingUnitChoiceSets");
                if (a.IsSuccessStatusCode)
                {
                    string str = await a.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(str))
                    {
                        choices = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MetaInfo>>(str);
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Impossible to load UnitChoiceSets");
            }
            if (success)
            {
                logger.LogInformation("Loaded UnitChoiceSets successfully");
                return choices;
            }
            else
            {
                logger.LogWarning("Impossible to load UnitChoiceSets");
                return null;
            }
        }
        public static async Task<UnitChoiceSet> LoadUnitChoiceSet(HttpClient httpClient, ILogger logger, Guid ID)
        {
            bool success = false;
            UnitChoiceSet unitChoiceSet = null;
            try
            {
                var a = await httpClient.GetAsync("DrillingUnitChoiceSets/" + ID);
                if (a.IsSuccessStatusCode)
                {
                    string str = await a.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(str))
                    {
                        unitChoiceSet = Newtonsoft.Json.JsonConvert.DeserializeObject<UnitChoiceSet>(str);
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Impossible to load UnitChoiceSets");
            }
            if (success)
            {
                logger.LogInformation("Loaded UnitChoiceSets successfully");
                return unitChoiceSet;
            }
            else
            {
                logger.LogWarning("Impossible to load UnitChoiceSets");
                return null;
            }
        }

    }
}
