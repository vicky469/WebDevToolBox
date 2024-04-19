namespace TransformAPI.Configuration.Model;

public class WebClientConfig : Dictionary<string, ClientConfig>, IWebClientConfig
{
}

public interface IWebClientConfig : IDictionary<string, ClientConfig>
{
}