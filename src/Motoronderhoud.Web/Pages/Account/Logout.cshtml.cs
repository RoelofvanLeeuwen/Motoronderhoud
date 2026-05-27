using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Motoronderhoud.Infrastructure.Identity;

namespace Motoronderhoud.Web.Pages.Account;

/// <summary>
/// Uitlogpagina — verwerkt POST-verzoek om de Identity-cookie te verwijderen.
/// </summary>
public class LogoutModel : PageModel
{
    private readonly SignInManager<ApplicationUser> _signInManager;

    public LogoutModel(SignInManager<ApplicationUser> signInManager)
        => _signInManager = signInManager;

    public async Task<IActionResult> OnPostAsync()
    {
        await _signInManager.SignOutAsync();
        return LocalRedirect("/account/login");
    }

    public IActionResult OnGet() => LocalRedirect("/account/login");
}
