using StarterKit.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapEndpoints();

app.Run();
