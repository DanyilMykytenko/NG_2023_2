using AutoMapper;
using Skeleton.BLL.Interfaces;
using Skeleton.BLL.Models;
using Skeleton.BLL.Models.AddModels;
using Skeleton.DAL.Interfaces;

namespace Skeleton.BLL.Services;

public class TestService : ITestService
{
    private readonly ITestRepository _testRepository;
    private readonly IMapper _mapper;

    public TestService(ITestRepository testRepository, IMapper mapper)
    {
        _testRepository = testRepository;
        _mapper = mapper;
    }

    public Task<IEnumerable<string>> GetTestsByUserIdAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<TestModel> GetTestWithQuestionsAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetTestDescriptionAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteTestAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task AddTestAsync(AddTestModel model)
    {
        throw new NotImplementedException();
    }

    public Task UpdateTestAsync(UpdateTestModel model)
    {
        throw new NotImplementedException();
    }
}