namespace TransformAPI.Common.HttpFactory;

public interface IHttpClientWrapper
{
    Task<TResponse> MakeRequestAsync<TRequest, TResponse>(HttpRequestMessage requestMessage, string clientName,
        TRequest body = default)
        where TRequest : class
        where TResponse : class;
}