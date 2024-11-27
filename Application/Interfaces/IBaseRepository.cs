using Domain.Entities;

namespace Application.Interfaces;

public interface IBaseRepository<TEntity> where TEntity : BaseEntity
{
    public Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken);
    public Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken);
    public Task SaveChangesAsync(CancellationToken cancellationToken);
}