using TransformAPI.Configuration.Model;

namespace TransformAPI.Common.Util;

public class HttpUtil
{
    public static string AddCorrelationIDToRequest(IHttpContextAccessor httpContextAccessor,
        HttpRequestMessage requestmessage)
    {
        string corrId = null;
        if (httpContextAccessor?.HttpContext?.Request?.Headers != null &&
            httpContextAccessor.HttpContext.Request.Headers.TryGetValue(HttpConstants.CorrelationHeaderKey,
                out var correlationId))
            corrId = correlationId.ToString();
        else
            corrId = new Guid().ToString();
        requestmessage.Headers.Add(HttpConstants.CorrelationHeaderKey, corrId);
        return corrId;
    }
}