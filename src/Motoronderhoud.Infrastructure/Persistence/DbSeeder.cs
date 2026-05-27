using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Motoronderhoud.Application.Constants;
using Motoronderhoud.Infrastructure.Identity;

namespace Motoronderhoud.Infrastructure.Persistence;

/// <summary>
/// Vult de database met verplichte begindata (rollen en het standaard eigenaar-account).
/// </summary>
public static class DbSeeder
{
    /// <summary>
    /// Voert de seed uit. Veilig om meerdere keren aan te roepen.
    /// </summary>
    public static async Task SeedAsync(IServiceProvider services)
    {
        var roleManager  = services.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager  = services.GetRequiredService<UserManager<ApplicationUser>>();
        var config       = services.GetRequiredService<IConfiguration>();
        var logger       = services.GetRequiredService<ILogger<AppDbContext>>();

        await EnsureRoleAsync(roleManager, Roles.Eigenaar);
        await EnsureRoleAsync(roleManager, Roles.Medewerker);

        var email    = config["Seed:OwnerEmail"]    ?? "eigenaar@motoronderhoud.nl";
        var password = config["Seed:OwnerPassword"] ?? "Welkom01!";
        var naam     = config["Seed:OwnerNaam"]     ?? "Eigenaar";

        if (await userManager.FindByEmailAsync(email) is null)
        {
            var user = new ApplicationUser
            {
                UserName      = email,
                Email         = email,
                VolledigeNaam = naam,
                EmailConfirmed = true,
            };

            var result = await userManager.CreateAsync(user, password);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, Roles.Eigenaar);
                logger.LogInformation("Standaard eigenaar-account aangemaakt: {Email}", email);
            }
            else
            {
                logger.LogError("Eigenaar-account aanmaken mislukt: {Errors}",
                    string.Join(", ", result.Errors.Select(e => e.Description)));
            }
        }
    }

    private static async Task EnsureRoleAsync(RoleManager<IdentityRole> roleManager, string roleName)
    {
        if (!await roleManager.RoleExistsAsync(roleName))
            await roleManager.CreateAsync(new IdentityRole(roleName));
    }
}
