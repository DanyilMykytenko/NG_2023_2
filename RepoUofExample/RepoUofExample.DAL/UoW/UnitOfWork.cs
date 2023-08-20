using RepoUofExample.DAL.Repositories;
using RepoUofExample.DAL.Repositories.Interfaces;

namespace RepoUofExample.DAL.UoW;

public class UnitOfWork : IDisposable
{
    private readonly RecipeContext _context;

    private IRecipeRepository? _recipeRepository;
    private IUserRepository? _userRepository;
    
    public UnitOfWork(RecipeContext context)
    {
        _context = context;
    }

    public IRecipeRepository GetRecipeRepository()
    {
        if (_recipeRepository is null)
        {
            _recipeRepository = new RecipeRepository(_context);
        }

        return _recipeRepository;
    }

    public IUserRepository GetUserRepository()
    {
        if (_userRepository is null)
        {
           _userRepository = new UserRepository(_context);
        }

        return _userRepository;
    }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}