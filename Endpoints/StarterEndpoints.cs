using StarterKit.Api.Endpoints.Handlers;

namespace StarterKit.Api.Endpoints;

public static class StarterEndpoints
{
    public static void MapEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/starter");

        group.MapPost("/login", LoginHandler.Handler);
    }
}
