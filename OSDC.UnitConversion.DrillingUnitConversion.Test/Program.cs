using Newtonsoft.Json;
using OSDC.UnitConversion.DrillingUnitConversion.ModelClientShared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OSDC.UnitConversion.DrillingUnitConversion.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestSuite(args);
        }

        static async void TestSuite(string[] args)
        {
            //string host = "https://app.DigiWells.no/";
            //string host = "http://localhost:80/"; // for debugging outside VS using docker (https not working)
            string host = "http://localhost:5002/"; // for debugging local

            if (args != null && args.Length >= 1)
            {
                host = args[0];
            }

            List<PhysicalQuantity> drillingQuantities = await TestDrillingPhysicalQuantities(host);
            List<UnitChoiceSet> unitChoiceSets = await TestDrillingUnitChoiceSets(host, drillingQuantities);
            await TestDataUnitConversionSets(host, drillingQuantities, unitChoiceSets);
            await TestQuantityDataConversions(host, drillingQuantities);
            Thread.Sleep(20000);
        }

        /// <summary>
        /// Functional tests for DrillingPhysicalQuantities
        /// </summary>
        /// <param name="args"></param>
        static async Task<List<PhysicalQuantity>> TestDrillingPhysicalQuantities(string host)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(host + "DrillingUnitConversion/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage message;

            #region readIDs
            // Test DrillingPhysicalQuantities #1: read the IDs
            Tuple<Guid, string>[] drillingPhysicalQuantityIDs = null;
            var a = client.GetAsync("DrillingPhysicalQuantities");
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                string str = await message.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(str))
                {
                    drillingPhysicalQuantityIDs = JsonConvert.DeserializeObject<Tuple<Guid, string>[]>(str);
                    if (drillingPhysicalQuantityIDs != null)
                    {
                        Console.WriteLine("Test DrillingPhysicalQuantities #1: read IDs: success. IDs: ");
                        for (int i = 0; i < drillingPhysicalQuantityIDs.Length; i++)
                        {
                            Console.Write("\t" + drillingPhysicalQuantityIDs[i].ToString());
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("Test DrillingPhysicalQuantities #1: read IDs: success. but no IDs");
                    }
                }
                else
                {
                    Console.WriteLine("Test DrillingPhysicalQuantities #1: read IDs: failure b");
                }
            }
            else
            {
                Console.WriteLine("Test DrillingPhysicalQuantities #1: read IDs: failure a");
            }
            Console.WriteLine();
            #endregion

            #region readData
            List<PhysicalQuantity> results = null;
            // Test DrillingPhysicalQuantities #2: read a DrillingPhysicalQuantity 
            if (drillingPhysicalQuantityIDs != null)
            {
                results = new List<PhysicalQuantity>();
                foreach (Tuple<Guid, string> tuple in drillingPhysicalQuantityIDs)
                {
                    a = client.GetAsync("DrillingPhysicalQuantities/" + tuple.Item1.ToString());
                    a.Wait();
                    message = a.Result;
                    if (message.IsSuccessStatusCode)
                    {
                        string str = await message.Content.ReadAsStringAsync();
                        if (!string.IsNullOrEmpty(str))
                        {
                            PhysicalQuantity downloadedDrillingPhysicalQuantity = JsonConvert.DeserializeObject<PhysicalQuantity>(str);
                            results.Add(downloadedDrillingPhysicalQuantity);
                            if (downloadedDrillingPhysicalQuantity != null)
                            {
                                Console.WriteLine("Test DrillingPhysicalQuantities #2: read the DrillingPhysicalQuantity: success");
                            }
                            else
                            {
                                Console.WriteLine("Test DrillingPhysicalQuantities #2: read the new DrillingPhysicalQuantity: failure c");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Test DrillingPhysicalQuantities #2: read the new DrillingPhysicalQuantity: failure b");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Test DrillingPhysicalQuantities #2: read the new DrillingPhysicalQuantity: failure a");
                    }
                    Console.WriteLine();
                }
            }
            return results;
            #endregion

        }

        /// <summary>
        /// Functional tests for DrillingUnitChoiceSets
        /// </summary>
        /// <param name="args"></param>
        static async Task<List<UnitChoiceSet>> TestDrillingUnitChoiceSets(string host, List<PhysicalQuantity> drillingPhysicalQuantities)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(host + "DrillingUnitConversion/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            StringContent content;
            HttpResponseMessage message;

            #region readIDs
            // Test DrillingUnitChoiceSets #1: read the IDs
            Tuple<Guid,string>[] initialDrillingUnitChoiceSetIDs;
            var a = client.GetAsync("DrillingUnitChoiceSets");
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                string str = await message.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(str))
                {
                    initialDrillingUnitChoiceSetIDs = JsonConvert.DeserializeObject<Tuple<Guid, string>[]>(str);
                    if (initialDrillingUnitChoiceSetIDs != null)
                    {
                        Console.WriteLine("Test DrillingUnitChoiceSets #1: read IDs: success. IDs: ");
                        for (int i = 0; i < initialDrillingUnitChoiceSetIDs.Length; i++)
                        {
                            Console.Write("\t" + initialDrillingUnitChoiceSetIDs[i]);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("Test DrillingUnitChoiceSets #1: read IDs: success. but no IDs");
                    }
                }
                else
                {
                    Console.WriteLine("Test DrillingUnitChoiceSets #1: read IDs: failure b");
                }
            }
            else
            {
                Console.WriteLine("Test DrillingUnitChoiceSets #1: read IDs: failure a");
            }
            Console.WriteLine();
            #endregion

            #region postData
            // Test DrillingUnitChoiceConversionSet #2: post a new unitChoiceSet
            Guid newId = Guid.NewGuid();
            // associations
            Dictionary<string, string> choices = new Dictionary<string, string>();
            Random rnd = new Random();
            int j = 0;
            foreach (PhysicalQuantity quantity in drillingPhysicalQuantities)
            {
                if (quantity != null && quantity.UnitChoices != null)
                {
                    int unitChoiceIdx = rnd.Next(0, quantity.UnitChoices.Count);
                    int i = 0;
                    Guid unitChoiceID = Guid.Empty;
                    foreach (UnitChoice choice in quantity.UnitChoices)
                    {
                        if (i++ == unitChoiceIdx)
                        {
                            unitChoiceID = choice.ID;
                            break;
                        }
                    }
                    choices.Add(quantity.ID.ToString(), unitChoiceID.ToString());
                }
                else
                {
                    choices.Add(quantity.ID.ToString(), Guid.Empty.ToString());
                }
                j++;
            }
            DrillingUnitChoiceSet unitChoiceSet = new DrillingUnitChoiceSet(newId, "My test DrillingUnitChoiceSet", "description of my test DrillingUnitChoiceSet", choices);

            // First, post the DrillingUnitChoiceConversionSet
            string json = unitChoiceSet.GetJson();
            content = new StringContent(json, Encoding.UTF8, "application/json");
            a = client.PostAsync("DrillingUnitChoiceSets", content);
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                Console.WriteLine("Test DrillingUnitChoiceSets #2: post of DrillingUnitChoiceSet: success");
            }
            else
            {
                Console.WriteLine("Test DrillingUnitChoiceSets #2: post of DrillingUnitChoiceSet: failure a");
            }

            // Then, get it back from the database
            a = client.GetAsync("DrillingUnitChoiceSets/" + newId.ToString());
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                string str = await message.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(str))
                {
                    DrillingUnitChoiceSet unitChoiceSetDownloaded = JsonConvert.DeserializeObject<DrillingUnitChoiceSet>(str);
                    if (unitChoiceSetDownloaded != null &&
                        unitChoiceSet.ID == unitChoiceSetDownloaded.ID &&
                        unitChoiceSet.Name.Equals(unitChoiceSetDownloaded.Name) &&
                        unitChoiceSet.Description.Equals(unitChoiceSetDownloaded.Description) &&
                        unitChoiceSet.Choices.Count == unitChoiceSetDownloaded.Choices.Count)
                    {
                        bool eq = true;
                        foreach (string quantitySrc in unitChoiceSet.Choices.Keys)
                        {
                            string unitChoiceSrc;
                            unitChoiceSet.Choices.TryGetValue(quantitySrc, out unitChoiceSrc);
                            bool found = false;
                            foreach (string quantityCmp in unitChoiceSetDownloaded.Choices.Keys)
                            {
                                if (!string.IsNullOrEmpty(quantityCmp) && quantityCmp.Equals(quantitySrc))
                                {
                                    string unitChoiceCmp;
                                    unitChoiceSetDownloaded.Choices.TryGetValue(quantityCmp, out unitChoiceCmp);
                                    found = !string.IsNullOrEmpty(unitChoiceCmp) && unitChoiceCmp.Equals(unitChoiceSrc);
                                    break;
                                }
                            }
                            eq &= found;
                        }
                        if (eq)
                        {
                            Console.WriteLine("Test DrillingUnitChoiceSets #2: post of DrillingUnitChoiceSet: succes");
                        }
                        else
                        {
                            Console.WriteLine("Test DrillingUnitChoiceSets #2: post of DrillingUnitChoiceSet: failure e");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Test DrillingUnitChoiceSets #2: post of DrillingUnitChoiceSet: failure b");
                    }
                }
                else
                {
                    Console.WriteLine("Test DrillingUnitChoiceSets #2: post of DrillingUnitChoiceSet: failure c");
                }
            }
            else
            {
                Console.WriteLine("Test DrillingUnitChoiceSets #2: post of DrillingUnitChoiceSet: failure d");
            }
            Console.WriteLine();
            #endregion

            #region putData
            // Test DrillingUnitChoiceConversionSets #4: put (update) the previous DrillingUnitChoiceSet 
            unitChoiceSet.Name = "New DrillingUnitChoiceSet name";

            content = new StringContent(unitChoiceSet.GetJson(), Encoding.UTF8, "application/json");
            a = client.PutAsync("DrillingUnitChoiceSets" + "/" + unitChoiceSet.ID.ToString(), content);
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                Console.Write("Test DrillingUnitChoiceSets #4: put of the new DrillingUnitChoiceSet: success. ID = " + unitChoiceSet.ID.ToString());
            }
            else
            {
                Console.WriteLine("Test DrillingUnitChoiceSets #4: put of the new DrillingUnitChoiceSet: failure a");
            }
            Console.WriteLine();
            #endregion

            #region readData
            // Test DataUnitConversionSets #5: read the calculationData for the updated ID 
            a = client.GetAsync("DrillingUnitChoiceSets/" + newId);
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                string str = await message.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(str))
                {
                    DataUnitConversionSet downloadedDataUnitConversionSet = JsonConvert.DeserializeObject<DataUnitConversionSet>(str);
                    if (downloadedDataUnitConversionSet != null && downloadedDataUnitConversionSet.Name.Equals(unitChoiceSet.Name))
                    {
                        Console.WriteLine("Test DrillingUnitChoiceSets #5: read the DrillingUnitChoiceSet: success. ID = " + unitChoiceSet.ID.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Test DrillingUnitChoiceSets #5: read the DrillingUnitChoiceSet: failure c");
                    }
                }
                else
                {
                    Console.WriteLine("Test DrillingUnitChoiceSets #5: read the DrillingUnitChoiceSet: failure b");
                }
            }
            else
            {
                Console.WriteLine("Test DrillingUnitChoiceSets #5: read the DrillingUnitChoiceSet: failure a");
            }
            Console.WriteLine();
            #endregion

            #region deleteData
            // Test DrillingUnitChoiceSets #6: delete the DrillingUnitChoiceSet 
            a = client.DeleteAsync("DrillingUnitChoiceSets/" + newId.ToString());
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                Console.WriteLine("Test DrillingUnitChoiceSets #6: delete of DrillingUnitChoiceSet: success");
            }
            else
            {
                Console.WriteLine("Test DrillingUnitChoiceSets #6: delete of DrillingUnitChoiceSet: failure a");
            }
            Console.WriteLine();
            #endregion

            #region readIDs
            // Test DataUnitConversionSets #7: check that the new calculationData has been deleted
            List<Guid> updatedDrillingUnitChoiceSetIDs = null;
            a = client.GetAsync("DrillingUnitChoiceSets");
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                string str = await message.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(str))
                {
                    updatedDrillingUnitChoiceSetIDs = JsonConvert.DeserializeObject<List<Guid>>(str);
                    if (updatedDrillingUnitChoiceSetIDs != null)
                    {
                        bool found = false;
                        foreach (Guid ID in updatedDrillingUnitChoiceSetIDs)
                        {
                            if (ID != null && ID.Equals(newId))
                            {
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Test DrillingUnitChoiceSets #7: check that the new DrillingUnitChoiceSet has been deleted: success. IDs: ");
                            for (int i = 0; i < updatedDrillingUnitChoiceSetIDs.Count; i++)
                            {
                                Console.Write("\t" + updatedDrillingUnitChoiceSetIDs[i].ToString());
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Test DrillingUnitChoiceSets #7: check that the new DrillingUnitChoiceSet has been deleted: failure c1");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Test DrillingUnitChoiceSets #7: check that the new DrillingUnitChoiceSet has been deleted: failure c2");
                    }
                }
                else
                {
                    Console.WriteLine("Test DrillingUnitChoiceSets #7: check that the new DrillingUnitChoiceSet has been deleted: failure b");
                }
            }
            else
            {
                Console.WriteLine("Test DrillingUnitChoiceSets #7: check that the new DrillingUnitChoiceSet has been deleted: failure a");
            }
            #endregion

            #region readData
            List<UnitChoiceSet> results = null;
            // Test DrillingUnitChoiceSets #8: read all the unitChoiceSets 
            if (updatedDrillingUnitChoiceSetIDs != null)
            {
                results = new List<UnitChoiceSet>();
                foreach (Guid ID in updatedDrillingUnitChoiceSetIDs)
                {
                    a = client.GetAsync("DrillingUnitChoiceSets/" + ID.ToString());
                    a.Wait();
                    message = a.Result;
                    if (message.IsSuccessStatusCode)
                    {
                        string str = await message.Content.ReadAsStringAsync();
                        if (!string.IsNullOrEmpty(str))
                        {
                            UnitChoiceSet downloadedUnitChoiceSet = JsonConvert.DeserializeObject<UnitChoiceSet>(str);
                            results.Add(downloadedUnitChoiceSet);
                            if (downloadedUnitChoiceSet != null)
                            {
                                Console.WriteLine("Test DrillingUnitChoiceSets #8: read the UnitChoiceSet: success");
                            }
                            else
                            {
                                Console.WriteLine("Test DrillingUnitChoiceSets #8: read the new UnitChoiceSet: failure c");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Test DrillingUnitChoiceSets #8: read the new UnitChoiceSet: failure b");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Test DrillingUnitChoiceSets #8: read the new UnitChoiceSet: failure a");
                    }
                    Console.WriteLine();
                }
            }
            #endregion
            return results;
        }
        /// <summary>
        /// Functional tests for DataUnitConversionSets
        /// </summary>
        /// <param name="args"></param>
        static async Task<bool> TestDataUnitConversionSets(string host, List<PhysicalQuantity> drillingPhysicalQuantities, List<UnitChoiceSet> unitChoiceSets)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(host + "DrillingUnitConversion/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            StringContent content;
            HttpResponseMessage message;

            #region readIDs
            // Test DrillingUnitChoiceSets #1: read the IDs
            Guid[] initialDrillingUnitChoiceSetIDs;
            var a = client.GetAsync("DataUnitConversionSets");
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                string str = await message.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(str))
                {
                    initialDrillingUnitChoiceSetIDs = JsonConvert.DeserializeObject<Guid[]>(str);
                    if (initialDrillingUnitChoiceSetIDs != null)
                    {
                        Console.WriteLine("Test DataUnitConversionSets #1: read IDs: success. IDs: ");
                        for (int i = 0; i < initialDrillingUnitChoiceSetIDs.Length; i++)
                        {
                            Console.Write("\t" + initialDrillingUnitChoiceSetIDs[i]);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("Test DataUnitConversionSets #1: read IDs: success. but no IDs");
                    }
                }
                else
                {
                    Console.WriteLine("Test DataUnitConversionSets #1: read IDs: failure b");
                }
            }
            else
            {
                Console.WriteLine("Test DataUnitConversionSets #1: read IDs: failure a");
            }
            Console.WriteLine();
            #endregion

            #region postData
            // Test DataUnitConversionSets #2: post a new DataUnitConversionSet
            Guid newId = Guid.NewGuid();
            Random rnd = new Random();
            int idxQuantity1 = rnd.Next(drillingPhysicalQuantities.Count);
            int idxQuantity2 = rnd.Next(drillingPhysicalQuantities.Count);
            QuantityUnitConversion quantitySet1 = new QuantityUnitConversion();
            QuantityUnitConversion quantitySet2 = new QuantityUnitConversion();
            int j = 0;
            foreach (PhysicalQuantity quantity in drillingPhysicalQuantities)
            {
                if (quantity != null && j == idxQuantity1)
                {
                    quantitySet1.PhysicalQuantityID = quantity.ID;
                    if (quantitySet1.DataConversions == null)
                    {
                        quantitySet1.DataConversions = new List<DataConversion>();
                    }
                    quantitySet1.DataConversions.Clear();
                    DataConversion conversion1 = new DataConversion();
                    conversion1.DataIn = 1.0;
                    conversion1.Conversion = ConversionType.FromSI;
                    DataConversion conversion2 = new DataConversion();
                    conversion2.DataIn = 2.0;
                    conversion2.Conversion = ConversionType.ToSI;
                    quantitySet1.DataConversions.Add(conversion1);
                    quantitySet1.DataConversions.Add(conversion2);
                }
                if (quantity != null && j == idxQuantity2)
                {
                    quantitySet2.PhysicalQuantityID = quantity.ID;
                    if (quantitySet2.DataConversions == null)
                    {
                        quantitySet2.DataConversions = new List<DataConversion>();
                    }
                    quantitySet2.DataConversions.Clear();
                    DataConversion conversion1 = new DataConversion();
                    conversion1.DataIn = 1.0;
                    conversion1.Conversion = ConversionType.FromSI;
                    DataConversion conversion2 = new DataConversion();
                    conversion2.DataIn = 3.0;
                    conversion2.Conversion = ConversionType.ToSI;
                    quantitySet2.DataConversions.Add(conversion1);
                    quantitySet2.DataConversions.Add(conversion2);
                }
                j++;
            }
            List<QuantityUnitConversion> conversions = new List<QuantityUnitConversion>();
            conversions.Add(quantitySet1);
            conversions.Add(quantitySet2);
            int unitChoiceSetIdx = rnd.Next(unitChoiceSets.Count);
            DataUnitConversionSet conversionSet = new DataUnitConversionSet(newId, "My new conversion set", "New conversion set description", unitChoiceSets[unitChoiceSetIdx].ID, conversions);

            // First, post the DrillingUnitChoiceConversionSet
            string json = conversionSet.GetJson();
            content = new StringContent(json, Encoding.UTF8, "application/json");
            a = client.PostAsync("DataUnitConversionSets", content);
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                Console.WriteLine("Test DataUnitConversionSets #2: post of DataUnitConversionSet: success");
            }
            else
            {
                Console.WriteLine("Test DataUnitConversionSets #2: post of DataUnitConversionSet: failure a");
            }

            // Then, get it back from the database
            a = client.GetAsync("DataUnitConversionSets/" + newId.ToString());
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                string str = await message.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(str))
                {
                    DataUnitConversionSet dataUnitConversionSetDownloaded = JsonConvert.DeserializeObject<DataUnitConversionSet>(str);
                    if (dataUnitConversionSetDownloaded != null &&
                        conversionSet.ID == dataUnitConversionSetDownloaded.ID &&
                        conversionSet.Name.Equals(dataUnitConversionSetDownloaded.Name) &&
                        conversionSet.Description.Equals(dataUnitConversionSetDownloaded.Description) &&
                        conversionSet.QuantityUnitConversions != null &&
                        dataUnitConversionSetDownloaded.QuantityUnitConversions != null &&
                        conversionSet.QuantityUnitConversions.Count == dataUnitConversionSetDownloaded.QuantityUnitConversions.Count)
                    {
                        bool eq = true;
                        foreach (QuantityUnitConversion unitConversion in conversionSet.QuantityUnitConversions)
                        {
                            
                        }
                        if (eq)
                        {
                            Console.WriteLine("Test DataUnitConversionSets #2: post of DataUnitConversionSet: succes");
                        }
                        else
                        {
                            Console.WriteLine("Test DataUnitConversionSets #2: post of DataUnitConversionSet: failure e");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Test DataUnitConversionSets #2: post of DataUnitConversionSet: failure b");
                    }
                }
                else
                {
                    Console.WriteLine("Test DataUnitConversionSets #2: post of DataUnitConversionSet: failure c");
                }
            }
            else
            {
                Console.WriteLine("Test DataUnitConversionSets #2: post of DataUnitConversionSet: failure d");
            }
            Console.WriteLine();
            #endregion

            #region putData
            // Test DataUnitConversionSets #4: put (update) the previous DataUnitConversionSet 
            conversionSet.Name = "New DataUnitConversionSet name";

            content = new StringContent(conversionSet.GetJson(), Encoding.UTF8, "application/json");
            a = client.PutAsync("DataUnitConversionSets" + "/" + conversionSet.ID.ToString(), content);
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                Console.Write("Test DataUnitConversionSets #4: put of the new DataUnitConversionSet: success. ID = " + conversionSet.ID.ToString());
            }
            else
            {
                Console.WriteLine("Test DataUnitConversionSets #4: put of the new DataUnitConversionSet: failure a");
            }
            Console.WriteLine();
            #endregion

            #region readData
            // Test DataUnitConversionSets #5: read the DataUnitConversionSet for the updated ID 
            a = client.GetAsync("DataUnitConversionSets/" + newId);
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                string str = await message.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(str))
                {
                    DataUnitConversionSet downloadedDataUnitConversionSet = JsonConvert.DeserializeObject<DataUnitConversionSet>(str);
                    if (downloadedDataUnitConversionSet != null && downloadedDataUnitConversionSet.Name.Equals(conversionSet.Name))
                    {
                        Console.WriteLine("Test DataUnitConversionSets #5: read the DataUnitConversionSet: success. ID = " + conversionSet.ID.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Test DataUnitConversionSets #5: read the DataUnitConversionSet:failure c");
                    }
                }
                else
                {
                    Console.WriteLine("Test DataUnitConversionSets #5: read the DataUnitConversionSet:failure b");
                }
            }
            else
            {
                Console.WriteLine("Test DataUnitConversionSets #5: read the DataUnitConversionSet:failure a");
            }
            Console.WriteLine();
            #endregion

            #region deleteData
            // Test DataUnitConversionSets #6: delete the DataUnitConversionSet 
            a = client.DeleteAsync("DataUnitConversionSets/" + newId.ToString());
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                Console.WriteLine("Test DataUnitConversionSets #6: delete of DataUnitConversionSet: success");
            }
            else
            {
                Console.WriteLine("Test DataUnitConversionSets #6: delete of DataUnitConversionSet: failure a");
            }
            Console.WriteLine();
            #endregion

            #region readIDs
            // Test DataUnitConversionSets #7: check that the new calculationData has been deleted
            List<Guid> updatedDataUnitConversionSetIDs = null;
            a = client.GetAsync("DataUnitConversionSets");
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                string str = await message.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(str))
                {
                    updatedDataUnitConversionSetIDs = JsonConvert.DeserializeObject<List<Guid>>(str);
                    if (updatedDataUnitConversionSetIDs != null && !updatedDataUnitConversionSetIDs.Contains(newId))
                    {
                        Console.WriteLine("Test DataUnitConversionSets #7: check that the new DataUnitConversionSet has been deleted: success. IDs: ");
                        for (int i = 0; i < updatedDataUnitConversionSetIDs.Count; i++)
                        {
                            Console.Write("\t" + updatedDataUnitConversionSetIDs[i].ToString());
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Test DataUnitConversionSets #7: check that the new DataUnitConversionSet has been deleted: failure c");
                    }
                }
                else
                {
                    Console.WriteLine("Test DataUnitConversionSets #7: check that the new DataUnitConversionSet has been deleted: failure b");
                }
            }
            else
            {
                Console.WriteLine("Test DataUnitConversionSets #7: check that the new DataUnitConversionSet has been deleted: failure a");
            }
            #endregion
            return true;
        }

        /// <summary>
        /// Functional tests for DrillingUnitChoiceSets
        /// </summary>
        /// <param name="args"></param>
        static async Task<bool> TestQuantityDataConversions(string host, List<PhysicalQuantity> drillingPhysicalQuantities)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(host + "DrillingUnitConversion/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            StringContent content;
            HttpResponseMessage message;

            #region readIDs
            // Test DrillingUnitChoiceSets #1: read the IDs
            Guid[] initialQuantityDataConversionIDs;
            var a = client.GetAsync("QuantityDataConversions");
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                string str = await message.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(str))
                {
                    initialQuantityDataConversionIDs = JsonConvert.DeserializeObject<Guid[]>(str);
                    if (initialQuantityDataConversionIDs != null)
                    {
                        Console.WriteLine("Test QuantityDataConversions #1: read IDs: success. IDs: ");
                        for (int i = 0; i < initialQuantityDataConversionIDs.Length; i++)
                        {
                            Console.Write("\t" + initialQuantityDataConversionIDs[i]);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("Test QuantityDataConversions #1: read IDs: success. but no IDs");
                    }
                }
                else
                {
                    Console.WriteLine("Test QuantityDataConversions #1: read IDs: failure b");
                }
            }
            else
            {
                Console.WriteLine("Test QuantityDataConversions #1: read IDs: failure a");
            }
            Console.WriteLine();
            #endregion

            #region postData
            // Test QuantityDataConversions #2: post a new QuantityDataConversion
            Guid newId = Guid.NewGuid();
            Random rnd = new Random();
            int idxQuantity = rnd.Next(drillingPhysicalQuantities.Count);
            QuantityDataConversion quantityDataConversion = new QuantityDataConversion();
            quantityDataConversion.ID = newId;
            quantityDataConversion.QuantityID = drillingPhysicalQuantities[idxQuantity].ID;
            int idxUnitChoice = rnd.Next(drillingPhysicalQuantities[idxQuantity].UnitChoices.Count);
            int j = 0;
            foreach (UnitChoice choice in drillingPhysicalQuantities[idxQuantity].UnitChoices)
            {
                if (j == idxUnitChoice)
                {
                    quantityDataConversion.UnitChoiceID = choice.ID;
                    break;
                }
                j++;
            }
            quantityDataConversion.DataIn = 1.0;
            quantityDataConversion.Conversion = ConversionType.FromSI;

            // First, post the DrillingUnitChoiceConversionSet
            string json = quantityDataConversion.GetJson();
            content = new StringContent(json, Encoding.UTF8, "application/json");
            a = client.PostAsync("QuantityDataConversions", content);
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                Console.WriteLine("Test QuantityDataConversions #2: post of QuantityDataConversion: success");
            }
            else
            {
                Console.WriteLine("Test QuantityDataConversions #2: post of QuantityDataConversion: failure a");
            }

            // Then, get it back from the database
            a = client.GetAsync("QuantityDataConversions/" + newId.ToString());
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                string str = await message.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(str))
                {
                    QuantityDataConversion quantityDataConversionDownloaded = JsonConvert.DeserializeObject<QuantityDataConversion>(str);
                    if (quantityDataConversionDownloaded != null &&
                        quantityDataConversion.ID == quantityDataConversionDownloaded.ID &&
                        quantityDataConversion.QuantityID == quantityDataConversionDownloaded.QuantityID &&
                        quantityDataConversion.UnitChoiceID == quantityDataConversionDownloaded.UnitChoiceID &&
                        quantityDataConversion.Conversion == quantityDataConversionDownloaded.Conversion &&
                        System.Math.Abs(quantityDataConversion.DataIn - quantityDataConversionDownloaded.DataIn) < 1e-6)
                    {
                        Console.WriteLine("Test QuantityDataConversions #2: post of QuantityDataConversion: succes");
                    }
                    else
                    {
                        Console.WriteLine("Test QuantityDataConversions #2: post of QuantityDataConversion: failure b");
                    }
                }
                else
                {
                    Console.WriteLine("Test QuantityDataConversions #2: post of QuantityDataConversion: failure c");
                }
            }
            else
            {
                Console.WriteLine("Test QuantityDataConversions #2: post of QuantityDataConversion: failure d");
            }
            Console.WriteLine();
            #endregion

            #region putData
            // Test QuantityDataConversions #4: put (update) the previous DataUnitConversionSet 
            quantityDataConversion.DataIn = 2.0;
            quantityDataConversion.Conversion = ConversionType.ToSI;

            content = new StringContent(quantityDataConversion.GetJson(), Encoding.UTF8, "application/json");
            a = client.PutAsync("QuantityDataConversions" + "/" + quantityDataConversion.ID.ToString(), content);
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                Console.Write("Test QuantityDataConversions #4: put of the new QuantityDataConversion: success. ID = " + quantityDataConversion.ID.ToString());
            }
            else
            {
                Console.WriteLine("Test QuantityDataConversions #4: put of the new QuantityDataConversion: failure a");
            }
            Console.WriteLine();
            #endregion

            #region readData
            // Test QuantityDataConversions #5: read the QuantityDataConversion for the updated ID 
            a = client.GetAsync("QuantityDataConversions/" + newId);
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                string str = await message.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(str))
                {
                    QuantityDataConversion downloadedQuantityDataConversion = JsonConvert.DeserializeObject<QuantityDataConversion>(str);
                    if (downloadedQuantityDataConversion != null && 
                        downloadedQuantityDataConversion.Conversion == quantityDataConversion.Conversion &&
                        System.Math.Abs(downloadedQuantityDataConversion.DataIn-quantityDataConversion.DataIn) < 1e-6)
                    {
                        Console.WriteLine("Test QuantityDataConversions #5: read the QuantityDataConversion: success. ID = " + quantityDataConversion.ID.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Test QuantityDataConversions #5: read the QuantityDataConversion:failure c");
                    }
                }
                else
                {
                    Console.WriteLine("Test QuantityDataConversions #5: read the QuantityDataConversion:failure b");
                }
            }
            else
            {
                Console.WriteLine("Test QuantityDataConversions #5: read the QuantityDataConversion:failure a");
            }
            Console.WriteLine();
            #endregion

            #region deleteData
            // Test QuantityDataConversions #6: delete the QuantityDataConversion 
            a = client.DeleteAsync("QuantityDataConversions/" + newId.ToString());
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                Console.WriteLine("Test QuantityDataConversions #6: delete of QuantityDataConversion: success");
            }
            else
            {
                Console.WriteLine("Test QuantityDataConversions #6: delete of QuantityDataConversion: failure a");
            }
            Console.WriteLine();
            #endregion

            #region readIDs
            // Test QuantityDataConversions #7: check that the new QuantityDataConversion has been deleted
            List<Guid> updatedQuantityDataConversionIDs = null;
            a = client.GetAsync("QuantityDataConversions");
            a.Wait();
            message = a.Result;
            if (message.IsSuccessStatusCode)
            {
                string str = await message.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(str))
                {
                    updatedQuantityDataConversionIDs = JsonConvert.DeserializeObject<List<Guid>>(str);
                    if (updatedQuantityDataConversionIDs != null && !updatedQuantityDataConversionIDs.Contains(newId))
                    {
                        Console.WriteLine("Test QuantityDataConversions #7: check that the new QuantityDataConversion has been deleted: success. IDs: ");
                        for (int i = 0; i < updatedQuantityDataConversionIDs.Count; i++)
                        {
                            Console.Write("\t" + updatedQuantityDataConversionIDs[i].ToString());
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Test QuantityDataConversions #7: check that the new QuantityDataConversion has been deleted: failure c");
                    }
                }
                else
                {
                    Console.WriteLine("Test QuantityDataConversions #7: check that the new QuantityDataConversion has been deleted: failure b");
                }
            }
            else
            {
                Console.WriteLine("Test QuantityDataConversions #7: check that the new QuantityDataConversion has been deleted: failure a");
            }
            #endregion
            return true;
        }
    }
}
