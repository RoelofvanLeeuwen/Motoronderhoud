using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Motoronderhoud.Infrastructure.Identity;

namespace Motoronderhoud.Infrastructure.Persistence;

/// <summary>
/// Hoofddatabasecontext van de applicatie.
/// </summary>
public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    /// <inheritdoc />
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}
