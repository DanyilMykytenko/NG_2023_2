using System.Collections;
using Moq;
using NUnit.Framework;
using Skeleton.DAL.Context;
using Skeleton.DAL.Entities;
using Skeleton.DAL.Repositories;
using Skeleton.Tests.Data;

namespace Skeleton.Tests.DataTests;

[TestFixture]
public class TestRepositoryTests
{
    [TestCase("f626f7b9-b1c0-4c0c-90c6-4246aced0c22")]
    [TestCase("c9e3368b-601a-4f9a-b4f2-e2e207de3b54")]
    public async Task TestRepository_GetByIdAsync_ReturnsValue(string id)
    {
        // arrange
        
        using var context = new QuizHubDatabaseContext(UnitTestHelper.GetUnitTestsDbOptions());
        var testRepository = new TestRepository(context);

        var expected = RepositoryData.ExpectedTests.FirstOrDefault(x => x.Id.ToString() == id);

        // act

        var result = await testRepository.GetByIdAsync(Guid.Parse(id));

        // assert
        
        Assert.IsNotNull(result, message: "Expected not null");
        Assert.That(result, Is.EqualTo(expected).Using(new TestEqualityComparer()), message: "Result is invalid");
    }

    [Test]
    public async Task TestRepository_GetAllAsync_ReturnsAllValues()
    {
        using var context = new QuizHubDatabaseContext(UnitTestHelper.GetUnitTestsDbOptions());
        var testRepository = new TestRepository(context);

        var result = await testRepository.GetAllAsync();
        
        Assert.That(result, Is.EqualTo(RepositoryData.ExpectedTests).Using(new TestEqualityComparer()), 
            message: "Results are not equal to expected");
    }

    [Test]
    public async Task TestRepository_AddAsync_AddsValueToDatabase()
    {
        using var context = new QuizHubDatabaseContext(UnitTestHelper.GetUnitTestsDbOptions());
        var testRepository = new TestRepository(context);

        var newTest = new Test { Title = "New test", Description = "Some test" };

        await testRepository.AddAsync(newTest);
        await context.SaveChangesAsync();
        
        Assert.That(context.Tests.Count(), Is.EqualTo(4), message: "AddAsync works");
    }
    
    [Test]
    public async Task TestRepository_UpdateAsync_ValueUpdated()
    {
        using var context = new QuizHubDatabaseContext(UnitTestHelper.GetUnitTestsDbOptions());
        var testRepository = new TestRepository(context);

        var testId = Guid.Parse("f626f7b9-b1c0-4c0c-90c6-4246aced0c22");
        var notExpected = RepositoryData.ExpectedTests.FirstOrDefault(x => x.Id == testId);
        var test = new Test
        {
            Id = testId,
            Title = "new title", 
            Description = "new description"
        };

        await testRepository.UpdateAsync(test);
        await context.SaveChangesAsync();
        
        Assert.That(test, !Is.EqualTo(notExpected), message: "UpdateAsync works");
    }

    [TestCase("f626f7b9-b1c0-4c0c-90c6-4246aced0c22")]
    [TestCase("c9e3368b-601a-4f9a-b4f2-e2e207de3b54")]
    public async Task TestRepository_DeleteAsync_ObjectIsDeleted(string id)
    {
        using var context = new QuizHubDatabaseContext(UnitTestHelper.GetUnitTestsDbOptions());

        var testRepository = new TestRepository(context);

        await testRepository.DeleteAsync(Guid.Parse(id));
        await context.SaveChangesAsync();

        Assert.That(context.Tests.Count(), !Is.EqualTo(RepositoryData.ExpectedTests.Count()), message: "DeleteByIdAsync works incorrect");
    }
    
}