using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Motoronderhoud.Infrastructure.Identity;
using Motoronderhoud.Infrastructure.Persistence;

namespace Motoronderhoud.Infrastructure;

/// <summary>
/// Registreert Infrastructure-laag services in de DI-container.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Voegt alle Infrastructure-services toe aan de service collection.
    /// </summary>
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("DefaultConnection")
                ?? "Data Source=motoronderhoud.db"));

        services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit            = true;
                options.Password.RequiredLength          = 8;
                options.Password.RequireUppercase        = false;
                options.Password.RequireNonAlphanumeric  = false;
                options.SignIn.RequireConfirmedAccount    = false;
                options.User.RequireUniqueEmail           = true;
            })
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();

        services.ConfigureApplicationCookie(options =>
        {
            options.LoginPath  = "/account/login";
            options.LogoutPath = "/account/logout";
            options.AccessDeniedPath = "/account/login";
            options.SlidingExpiration = true;
            options.ExpireTimeSpan = TimeSpan.FromHours(8);
        });

        return services;
    }
}
