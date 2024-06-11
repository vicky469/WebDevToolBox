using GraphiQl;
using GraphQL.Types;
using static GraphQLApi.ServiceInitializer;
using GraphQL.Server;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
InitializeServices(builder.Services);


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseGraphiQl("/graphql");
}

app.UseMvc();

app.Run();
