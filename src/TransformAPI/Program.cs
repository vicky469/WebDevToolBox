using TransformAPI;

var builder = WebApplication.CreateBuilder(args);
// add services to the container
builder.Services.AddConfig(builder.Configuration)
    .AddDependencyGroup();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();