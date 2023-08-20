using Microsoft.EntityFrameworkCore;
using RepoUofExample.DAL.Entities;
using RepoUofExample.DAL.Repositories.Interfaces;

namespace RepoUofExample.DAL.Repositories;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
    where TEntity : BaseEntity
{
    protected readonly RecipeContext _context;

    protected BaseRepository(RecipeContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        var result = await _context.Set<TEntity>().ToListAsync();

        return result;
    }

    public async Task<TEntity?> GetById(Guid id)
    {
        var result = await _context.Set<TEntity>().FindAsync(id);

        return result;
    }

    public async Task AddAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateASync(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await _context.Set<TEntity>().FirstAsync(x => x.Id == id);
        _context.Set<TEntity>().Remove(entity);
        await _context.SaveChangesAsync();
    }
}