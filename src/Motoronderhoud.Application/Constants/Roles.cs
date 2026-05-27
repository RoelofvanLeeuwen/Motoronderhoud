namespace Motoronderhoud.Application.Constants;

/// <summary>
/// Roldefinities voor autorisatie binnen de applicatie.
/// </summary>
public static class Roles
{
    /// <summary>Eigenaar van het bedrijf — volledige toegang inclusief gebruikersbeheer.</summary>
    public const string Eigenaar = "Eigenaar";

    /// <summary>Medewerker — kan onderhoud plannen en loggen.</summary>
    public const string Medewerker = "Medewerker";
}
