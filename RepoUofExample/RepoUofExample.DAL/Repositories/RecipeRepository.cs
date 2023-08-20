using Microsoft.EntityFrameworkCore;
using RepoUofExample.DAL.Entities;
using RepoUofExample.DAL.Repositories.Interfaces;

namespace RepoUofExample.DAL.Repositories;

public class RecipeRepository : BaseRepository<Recipe>, IRecipeRepository
{
    public RecipeRepository(RecipeContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Recipe>> GetRangeAsync(int take, int skip)
    {
        var result = await _context.Recipes.Skip(skip).Take(take).ToListAsync();

        return result;
    }

    public async Task<IEnumerable<Recipe>> GetByNameAsync(string name)
    {
        var result = await _context.Recipes
            .Where(x => x.Name.Contains(name))
            .ToListAsync();

        return result;
    }

    public async Task<Recipe?> GetWithAuthor(Guid id)
    {
        var recipe = await _context.Recipes
            .Include(x => x.Author)
            .ThenInclude(x => x.User)
            .Include(x => x.Tags)
            .FirstOrDefaultAsync(x => x.Id == id);

        return recipe;
    }
}