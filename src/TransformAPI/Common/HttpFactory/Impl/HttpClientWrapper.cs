using TransformAPI.Configuration.Model;

namespace TransformAPI.Common.HttpFactory.Impl;

// handle auth
// add or set header
public class HttpClientWrapper : HttpClientBase, IHttpClientWrapper
{
    private readonly IWebClientConfig _clients;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public HttpClientWrapper(IHttpContextAccessor httpContextAccessor, IWebClientConfig clients,
        IHttpClientFactory clientFactory) : base(clientFactory, clients)
    {
        _httpContextAccessor = httpContextAccessor;
        _clients = clients;
    }

    public async Task<TResponse> MakeRequestAsync<TRequest, TResponse>(HttpRequestMessage requestMessage,
        string clientName, TRequest body)
        where TRequest : class
        where TResponse : class
    {
        //HttpUtil.GetOrSetCorrelationIDToRequest(_httpContextAccessor,requestMessage);
        requestMessage = await GetAndAddAuthValToRequestMessageHeader(requestMessage, clientName);
        var res = await SendAsync<TRequest, TResponse>(requestMessage, clientName, body);
        if (res.Exception != null) return default;

        return res.Response;
    }


    private async Task<HttpRequestMessage> GetAndAddAuthValToRequestMessageHeader(HttpRequestMessage requestMessage,
        string clientName)
    {
        throw new NotImplementedException();
    }
}