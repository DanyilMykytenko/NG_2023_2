using AutoMapper;
using Skeleton.BLL.Interfaces;
using Skeleton.BLL.Models;
using Skeleton.DAL.Interfaces;

namespace Skeleton.BLL.Services;

public class QuestionService : IQuestionService
{
    private readonly IMapper _mapper;
    private readonly IQuestionRepository _questionRepository;

    public QuestionService(IQuestionRepository questionRepository, IMapper mapper)
    {
        _mapper = mapper;
        _questionRepository = questionRepository;
    }

    public Task<IEnumerable<QuestionModel>> GetQuestionsByTestIdAsync(Guid testId)
    {
        throw new NotImplementedException();
    }
}