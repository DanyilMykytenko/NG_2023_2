using Skeleton.DAL.Context;
using Skeleton.DAL.Entities;
using Skeleton.DAL.Interfaces;

namespace Skeleton.DAL.Repositories;

public class TestRepository : BaseRepository<Test>, ITestRepository
{
    public TestRepository(QuizHubDatabaseContext dbContext) : base(dbContext)
    {
    }

    public Task<IEnumerable<Test>> GetTestsByUserIdAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<Test> GetByIdWithQuestionsAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetDescriptionAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Test> GetWithQuestionsAndAnswerAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}