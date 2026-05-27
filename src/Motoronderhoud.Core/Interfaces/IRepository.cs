namespace Motoronderhoud.Core.Interfaces;

/// <summary>
/// Generieke repository-interface voor standaard opslaggedrag.
/// </summary>
/// <typeparam name="T">Het type entity dat wordt opgeslagen.</typeparam>
public interface IRepository<T> where T : class, IEntity
{
    /// <summary>Haalt alle actieve entities op.</summary>
    Task<IReadOnlyList<T>> ListAsync(CancellationToken cancellationToken = default);

    /// <summary>Haalt een entity op basis van id op, of null als deze niet bestaat.</summary>
    Task<T?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    /// <summary>Voegt een nieuwe entity toe.</summary>
    Task AddAsync(T entity, CancellationToken cancellationToken = default);

    /// <summary>Werkt een bestaande entity bij.</summary>
    Task UpdateAsync(T entity, CancellationToken cancellationToken = default);

    /// <summary>Verwijdert een bestaande entity.</summary>
    Task DeleteAsync(T entity, CancellationToken cancellationToken = default);
}
