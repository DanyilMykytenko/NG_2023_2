using RepoUofExample.DAL.Entities;

namespace RepoUofExample.DAL.Repositories.Interfaces;

public interface IBaseRepository<TEntity> where TEntity : BaseEntity
{
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity?> GetById(Guid id);
    Task AddAsync(TEntity entity);
    Task UpdateASync(TEntity entity);
    Task DeleteAsync(Guid id);
}