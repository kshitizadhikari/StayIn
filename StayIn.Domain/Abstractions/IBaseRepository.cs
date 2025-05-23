namespace StayIn.Domain.Abstractions;
public interface IBaseRepository<T>
{
    Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    void Add(T entity);
}
