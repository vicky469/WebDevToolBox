namespace TransformAPI.Common.HttpFactory;

public interface IHttpClient
{
    Task<HttpClientResponse<TResponse>> SendAsync<TRequest, TResponse>(HttpRequestMessage requestMessage,
        string clientName = default, TRequest body = default, CancellationToken cancellationToken = default)
        where TRequest : class
        where TResponse : class;
}