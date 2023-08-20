using RepoUofExample.DAL.Entities;
using RepoUofExample.DAL.Repositories.Interfaces;

namespace RepoUofExample.DAL.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(RecipeContext context) : base(context)
    {
    }
}