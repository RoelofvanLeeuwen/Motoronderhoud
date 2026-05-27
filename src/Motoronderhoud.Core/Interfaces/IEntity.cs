namespace Motoronderhoud.Core.Interfaces;

/// <summary>
/// Basisinterface voor alle persistente domeinentities.
/// </summary>
public interface IEntity
{
    /// <summary>Unieke sleutel.</summary>
    int Id { get; set; }

    /// <summary>Tijdstip van aanmaken (UTC).</summary>
    DateTime CreatedAtUtc { get; set; }

    /// <summary>Tijdstip van laatste wijziging (UTC).</summary>
    DateTime UpdatedAtUtc { get; set; }

    /// <summary>Tijdstip van verwijdering (UTC); null als de entity actief is.</summary>
    DateTime? DeletedAtUtc { get; set; }
}
