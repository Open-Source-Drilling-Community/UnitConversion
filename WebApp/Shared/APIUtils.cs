public static class APIUtils
{
    //API parameters and utility methods
    public static readonly string HostNameUnitConversion = OSDC.UnitConversion.WebApp.Configuration.UnitConversionHostURL!;
    public static readonly string HostBasePathUnitConversion = "UnitConversion/api/";
    public static readonly HttpClient HttpClientUnitConversion = APIUtils.SetHttpClient(HostNameUnitConversion, HostBasePathUnitConversion);
    public static readonly OSDC.UnitConversion.ModelShared.Client ClientUnitConversion = new OSDC.UnitConversion.ModelShared.Client(APIUtils.HttpClientUnitConversion.BaseAddress!.ToString(), APIUtils.HttpClientUnitConversion);

    public static readonly string HostNameDrillingUnitConversion = OSDC.UnitConversion.WebApp.Configuration.DrillingUnitConversionHostURL!;
    public static readonly string HostBasePathDrillingUnitConversion = "DrillingUnitConversion/api/";
    public static readonly HttpClient HttpClientDrillingUnitConversion = APIUtils.SetHttpClient(HostNameDrillingUnitConversion, HostBasePathDrillingUnitConversion);

    public static readonly string HostNameField = OSDC.UnitConversion.WebApp.Configuration.FieldHostURL!;
    public static readonly string HostBasePathField = "Field/api/";
    public static readonly HttpClient HttpClientField = APIUtils.SetHttpClient(HostNameField, HostBasePathField);
    public static readonly OSDC.UnitConversion.ModelShared.Client ClientField= new OSDC.UnitConversion.ModelShared.Client(APIUtils.HttpClientField.BaseAddress!.ToString(), APIUtils.HttpClientField);


    public static HttpClient SetHttpClient(string host, string microServiceUri)
    {
        HttpClient httpClient = new()
        {
            BaseAddress = new Uri(host + microServiceUri)
        };
        httpClient.DefaultRequestHeaders.Accept.Clear();
        httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        return httpClient;
    }

    ///// <summary>
    ///// loads the data of type T and of given ID identified by its datasUri from the microservice identified by its httpClient
    ///// </summary>
    //public static async Task<T> LoadData<T>(ILogger logger, HttpClient httpClient, string datasUri, Guid guid) where T : class
    //{
    //    bool success = false;
    //    T data = null;
    //    try
    //    {
    //        var a = await httpClient.GetAsync(datasUri + guid.ToString());
    //        if (a.IsSuccessStatusCode && a.Content != null)
    //        {
    //            string str = await a.Content.ReadAsStringAsync();
    //            if (!string.IsNullOrEmpty(str))
    //            {
    //                data = JsonSerializer.Deserialize<T>(str);
    //                if (data == null)
    //                    throw new NullReferenceException($"Impossible to deserialize data of type {typeof(T).Name} string:" + str);
    //                success = true;
    //            }
    //        }
    //        else
    //        {
    //            logger.LogWarning($"Impossible to get data of type {typeof(T).Name} from controller");
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        logger.LogError(ex, $"Impossible to load data of type {typeof(T).Name}");
    //    }
    //    if (success)
    //    {
    //        logger.LogInformation($"Loaded data of type {typeof(T).Name} successfully");
    //        return data;
    //    }
    //    else
    //    {
    //        logger.LogWarning($"Impossible to load {typeof(T).Name}");
    //        return null;
    //    }
    //}

    //public static async Task<List<T>> LoadDatas<T>(ILogger logger, HttpClient httpClient, string datasUri, bool heavyWeightData = false) where T : class
    //{
    //    bool success = true;
    //    List<T> dataList = new List<T>();
    //    try
    //    {
    //        // retrieve IDs or MetaInfos or LightDatas using a GET all method and the adequate httpClient + datasUri combination
    //        var a = await httpClient.GetAsync(datasUri);
    //        if (a.IsSuccessStatusCode)
    //        {
    //            string str = await a.Content.ReadAsStringAsync();
    //            if (!string.IsNullOrEmpty(str))
    //            {
    //                if (heavyWeightData)
    //                {
    //                    // in the heavyweight data case, the endpoint corresponding to IDs (Guid) must be provided
    //                    List<Guid> ids = new();
    //                    ids = (List<Guid>)JsonSerializer.Deserialize<IEnumerable<Guid>>(str);
    //                    if (ids == null)
    //                        throw new NullReferenceException($"Impossible to deserialize ids from json string:" + str);
    //                    // then, foreach id, the associated heavy weight data is retrieved
    //                    T data = null;
    //                    for (int i = 0; i < ids.Count; i++)
    //                    {
    //                        data = await APIUtils.LoadData<T>(logger, httpClient, datasUri, ids[i]);
    //                        if (data != null)
    //                            dataList.Add(data);
    //                    }
    //                    if (dataList.Count != ids.Count)
    //                        throw new Exception($"Inconsistent count of data-loaded IDs of type of type {typeof(T).Name} and loaded datas.");
    //                }
    //                else
    //                {
    //                    // in other cases where datas are either Guids, MetaInfos or lightweight datas, a corresponding GET all method is assumed to be available
    //                    // thus, datas need only to be deserialized
    //                    List<T> datas = (List<T>)JsonSerializer.Deserialize<IEnumerable<T>>(str);
    //                    if (datas == null)
    //                        throw new NullReferenceException($"Impossible to deserialize datas from json string:" + str);
    //                    dataList.AddRange(datas);
    //                }
    //            }
    //            else
    //            {
    //                logger.LogInformation($"No records in the database from client {httpClient} at Uri {datasUri}");
    //            }
    //        }
    //        else
    //        {
    //            success = false;
    //            logger.LogWarning($"Impossible to get records from client {httpClient} at Uri {datasUri}");
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        success = false;
    //        logger.LogError(ex, $"Impossible to load datas of type {typeof(T).Name}");
    //    }
    //    if (success)
    //    {
    //        logger.LogInformation($"Loaded datas of type {typeof(T).Name} successfully");
    //        return dataList;
    //    }
    //    else
    //    {
    //        logger.LogWarning($"Impossible to load datas of type {typeof(T).Name}");
    //        return null;
    //    }
    //}

    ///// <summary>
    ///// Load Guid of all records in the database identified by the http client and the URI
    ///// </summary>
    ///// <param name="logger"></param>
    ///// <param name="httpClient"></param>
    ///// <param name="datasUri"></param>
    ///// <returns></returns>
    //public static async Task<List<Guid>> LoadIds(ILogger logger, HttpClient httpClient, string datasUri)
    //{
    //    bool success = true;
    //    List<Guid> dataList = new List<Guid>();
    //    try
    //    {
    //        // retrieve IDs using a GET all method and the adequate httpClient + datasUri combination
    //        var a = await httpClient.GetAsync(datasUri);
    //        if (a.IsSuccessStatusCode)
    //        {
    //            string str = await a.Content.ReadAsStringAsync();
    //            if (!string.IsNullOrEmpty(str))
    //            {
    //                List<Guid> datas = (List<Guid>)JsonSerializer.Deserialize<IEnumerable<Guid>>(str);
    //                if (datas == null)
    //                    throw new NullReferenceException($"Impossible to deserialize datas from json string:" + str);
    //                dataList.AddRange(datas);
    //            }
    //            else
    //            {
    //                logger.LogInformation($"No records in the database from client {httpClient} at Uri {datasUri}");
    //            }
    //        }
    //        else
    //        {
    //            success = false;
    //            logger.LogWarning($"Impossible to get records from client {httpClient} at Uri {datasUri}");
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        success = false;
    //        logger.LogError(ex, $"Impossible to load ids");
    //    }
    //    if (success)
    //    {
    //        logger.LogInformation($"Loaded ids successfully");
    //        return dataList;
    //    }
    //    else
    //    {
    //        logger.LogWarning($"Impossible to load ids");
    //        return null;
    //    }
    //}

    //public static async Task<bool> PostData(ILogger logger, HttpClient httpClient, string datasUri, string content)
    //{
    //    bool success = false;
    //    try
    //    {
    //        StringContent jsonContent = new StringContent(content, Encoding.UTF8, "application/json");
    //        var a = await httpClient.PostAsync(datasUri, jsonContent);
    //        if (a.IsSuccessStatusCode)
    //        {
    //            success = true;
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        logger.LogError(ex, $"Impossible to post data of given json content");
    //    }
    //    if (success)
    //    {
    //        logger.LogInformation($"Posted data of given json content");
    //        return true;
    //    }
    //    else
    //    {
    //        logger.LogWarning($"Impossible to post data data of given json content");
    //        return false;
    //    }
    //}

    //public static async Task<bool> PutData(ILogger logger, HttpClient httpClient, string datasUri, string content, Guid ID)
    //{
    //    bool success = false;
    //    try
    //    {
    //        StringContent jsonContent = new StringContent(content, Encoding.UTF8, "application/json");
    //        var a = await httpClient.PutAsync(datasUri + ID.ToString(), jsonContent);
    //        if (a.IsSuccessStatusCode)
    //        {
    //            success = true;
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        logger.LogError(ex, $"Impossible to put data of given ID");
    //    }
    //    if (success)
    //    {
    //        logger.LogInformation($"Put data of given ID successfully");
    //        return true;
    //    }
    //    else
    //    {
    //        logger.LogWarning($"Impossible to put data of given ID");
    //        return false;
    //    }
    //}

    //public static async Task<bool> DeleteData(ILogger logger, HttpClient httpClient, string datasUri, Guid ID)
    //{
    //    bool success = false;
    //    try
    //    {
    //        var a = await httpClient.DeleteAsync(datasUri + ID.ToString());
    //        success = a.IsSuccessStatusCode;
    //    }
    //    catch (Exception ex)
    //    {
    //        logger.LogError(ex, "Impossible to delete data of given ID");
    //    }
    //    if (success)
    //    {
    //        logger.LogInformation("Deleted the data given ID successfully");
    //        return true;
    //    }
    //    else
    //    {
    //        logger.LogWarning("Impossible to delete data of given ID");
    //        return false;
    //    }
    //}
}