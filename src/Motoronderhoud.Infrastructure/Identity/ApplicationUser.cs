using Microsoft.AspNetCore.Identity;

namespace Motoronderhoud.Infrastructure.Identity;

/// <summary>
/// Applicatiegebruiker — uitbreiding van de standaard ASP.NET Core Identity gebruiker.
/// </summary>
public class ApplicationUser : IdentityUser
{
    /// <summary>Volledige naam van de gebruiker.</summary>
    public string VolledigeNaam { get; set; } = string.Empty;
}
