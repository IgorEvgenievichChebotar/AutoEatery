using WebSocketHub;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

builder.Services.AddCors(options => options.AddPolicy("CorsPolicy",
    corsPolicyBuilder =>
    {
        corsPolicyBuilder.AllowAnyHeader()
            .AllowAnyMethod()
            .SetIsOriginAllowed((host) => true)
            .AllowCredentials();
    }));

var app = builder.Build();

app.UseCors("CorsPolicy");

app.MapHub<EateryHub>("/hub");

app.Run();