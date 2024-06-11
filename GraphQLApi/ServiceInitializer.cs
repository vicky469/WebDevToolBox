using GraphiQl;
using GraphQL.Server;
using GraphQLApi.Data;
using Microsoft.EntityFrameworkCore;
using GraphQL.Types;
using GraphQLApi.Queries;
using GraphQLApi.Schemas;
using GraphQLApi.Types;

namespace GraphQLApi;
public static class ServiceInitializer
{
    public static void InitializeServices(IServiceCollection services)
    {
        services.AddDbContext<CourseDbContext>(options => { options.UseSqlite("Data Source=Data/coursedb.sqlite"); });

        // because ProQuery has a dependency on CourseDbContext and db context is registered as Scoped service
        // if ProQuery was registered as Singleton, it cannot access a Scoped service like CourseDbContext that has a shorter lifetime
        services.AddScoped<ProQuery>();

        services.AddScoped<CourseSchema>();

        services.AddScoped<CourseType>();
        services.AddScoped<RatingType>();
        services.AddScoped<PaymentTypeEnum>();
        
        services.AddMvc(options => options.EnableEndpointRouting = false);
    }
}
