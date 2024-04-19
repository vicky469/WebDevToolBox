namespace TransformAPI.Configuration.Model;

public class WebClientConfigSettings
{
    public Dictionary<string, ClientConfig> WebClientConfigs { get; set; }
}

public class ClientConfig
{
    public string BaseUrl { get; set; }
    public Dictionary<string, string> RequestHeaders { get; set; }
    public int Timeout { get; set; } = 30;
    public int RetryCnt { get; set; } = 0;
    public int BeforeCircuitBreakerCnt { get; set; } = 5;
    public int DurationOfBreak { get; set; } = 20;
}