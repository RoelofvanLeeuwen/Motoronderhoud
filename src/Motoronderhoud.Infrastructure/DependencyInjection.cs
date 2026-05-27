using Microsoft.Extensions.DependencyInjection;

namespace Motoronderhoud.Infrastructure;

/// <summary>
/// Registreert Infrastructure-laag services in de DI-container.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Voegt alle Infrastructure-services toe aan de service collection.
    /// </summary>
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // DbContext, repositories en externe services worden hier geregistreerd per user story.
        return services;
    }
}
