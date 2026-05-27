using Microsoft.Extensions.DependencyInjection;

namespace Motoronderhoud.Application;

/// <summary>
/// Registreert Application-laag services in de DI-container.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Voegt alle Application-services toe aan de service collection.
    /// </summary>
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Services worden hier geregistreerd per user story.
        return services;
    }
}
