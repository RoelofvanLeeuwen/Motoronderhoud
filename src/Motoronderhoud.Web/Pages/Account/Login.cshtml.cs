using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Motoronderhoud.Infrastructure.Identity;

namespace Motoronderhoud.Web.Pages.Account;

/// <summary>
/// Loginpagina — verwerkt het inlogformulier buiten het Blazor SignalR-circuit.
/// </summary>
public class LoginModel : PageModel
{
    private readonly SignInManager<ApplicationUser> _signInManager;

    public LoginModel(SignInManager<ApplicationUser> signInManager)
        => _signInManager = signInManager;

    [BindProperty] public string Email    { get; set; } = string.Empty;
    [BindProperty] public string Password { get; set; } = string.Empty;

    public string Foutmelding { get; private set; } = string.Empty;

    public IActionResult OnGet()
    {
        if (_signInManager.IsSignedIn(User))
            return LocalRedirect("/");

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(string? returnUrl = null)
    {
        returnUrl ??= "/";

        var result = await _signInManager.PasswordSignInAsync(
            Email, Password, isPersistent: false, lockoutOnFailure: false);

        if (result.Succeeded)
            return LocalRedirect(returnUrl);

        Foutmelding = "Onjuist e-mailadres of wachtwoord.";
        return Page();
    }
}
