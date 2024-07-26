using OSDC.UnitConversion.ModelShared;

public static class APIUtils
{
    // API parameters
    public static readonly string HostNameUnitConversion = OSDC.UnitConversion.WebApp.Configuration.UnitConversionHostURL!;
    public static readonly string HostBasePathUnitConversion = "UnitConversion/api/";
    public static readonly HttpClient HttpClientUnitConversion = APIUtils.SetHttpClient(HostNameUnitConversion, HostBasePathUnitConversion);
    public static readonly Client ClientUnitConversion = new(APIUtils.HttpClientUnitConversion.BaseAddress!.ToString(), APIUtils.HttpClientUnitConversion);

    // API utility methods
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
}