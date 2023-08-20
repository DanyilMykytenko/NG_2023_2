using RepoUofExample.DAL.Entities;

namespace RepoUofExample.DAL.Repositories.Interfaces;

public interface IRecipeRepository : IBaseRepository<Recipe>
{
    Task<IEnumerable<Recipe>> GetRangeAsync(int take, int skip);
    Task<IEnumerable<Recipe>> GetByNameAsync(string name);
    Task<Recipe?> GetWithAuthor(Guid id);
}