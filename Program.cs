using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);


builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddOcelot();

builder.Services.AddControllers();
builder.Services.AddOcelot(builder.Configuration);


var app = builder.Build();
app.MapControllers();
await app.UseOcelot();

app.Run();
