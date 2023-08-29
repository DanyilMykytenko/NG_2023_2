using Skeleton.DAL.Context;
using Skeleton.DAL.Entities;
using Skeleton.DAL.Interfaces;

namespace Skeleton.DAL.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(QuizHubDatabaseContext dbContext) : base(dbContext)
    {
    }

    public Task<User> GetUserByCredentialsAsync(string name, string password)
    {
        throw new NotImplementedException();
    }
}