namespace TransformAPI.Common.HttpFactory;

public class HttpClientResponse<TResponse>
{
    public int Success { get; set; }
    public int StatusCode { get; set; }
    public TResponse Response { get; set; }
    public Exception Exception { get; set; }
}