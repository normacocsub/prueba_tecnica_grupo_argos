using Domain.Services;
using Domain.Shared;
using Infrastructure.Services;
using Infrastructure.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configuration;

public static class ConfigureServices
{
    public static void ConfigureService(this IServiceCollection services)
    {
        services.AddScoped<IMediaService, MediaService>();
        services.AddScoped(typeof(IClassResponse<>), typeof(ClassResponse<>));
    }
}