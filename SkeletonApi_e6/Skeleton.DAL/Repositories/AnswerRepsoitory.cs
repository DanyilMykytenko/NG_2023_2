using Skeleton.DAL.Context;
using Skeleton.DAL.Entities;
using Skeleton.DAL.Interfaces;

namespace Skeleton.DAL.Repositories;

public class AnswerRepository : BaseRepository<Answer>, IAnswerRepository
{
    public AnswerRepository(QuizHubDatabaseContext dbContext) : base(dbContext)
    {
    }

    public Task<bool> CheckIsCorrectAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Answer>> GetAllByQuestionIdAsync(Guid questionId)
    {
        throw new NotImplementedException();
    }
}