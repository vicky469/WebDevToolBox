using Polly;
using TransformAPI.Common.HttpFactory;
using TransformAPI.Common.HttpFactory.Impl;
using TransformAPI.Configuration.Model;
using TransformAPI.DataAccess;
using TransformAPI.DataAccess.Impl;

namespace TransformAPI;

public static class ServiceInitializer
{
    public static IServiceCollection AddConfig(this IServiceCollection services, IConfiguration config)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddWebClientServices(config);
        return services;
    }

    public static IServiceCollection AddDependencyGroup(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddSingleton<IHttpClientWrapper, HttpClientWrapper>();
        services.AddSingleton<IHttpClient, HttpClientBase>();
        return services;
    }

    private static IServiceCollection AddWebClientServices(this IServiceCollection services, IConfiguration config)
    {
        var clients = config.GetSection("WebClientConfig").Get<WebClientConfig>();
        foreach (var name in clients.Keys)
        {
            var clientConfig = clients[name];
            services.AddHttpClient(name, config =>
                {
                    config.BaseAddress = new Uri(clientConfig.BaseUrl);

                    config.Timeout = new TimeSpan(0, 0, clientConfig.Timeout);
                })
                // Retry 3 times with a time interval of 2 seconds.
                // Handle transient errors such as: 
                //  - Network Failure
                //  - HTTP 5XX status codes
                //  - HTTP 408 status code
                .AddTransientHttpErrorPolicy(p => p.WaitAndRetryAsync(3, _ => TimeSpan.FromSeconds(2)))
                .AddTransientHttpErrorPolicy(policyBuilder => policyBuilder.CircuitBreakerAsync(
                    clientConfig.BeforeCircuitBreakerCnt,
                    TimeSpan.FromSeconds(clientConfig.DurationOfBreak)));
            services.AddSingleton<IWebClientConfig>(sp => clients);
        }

        return services;
    }
}