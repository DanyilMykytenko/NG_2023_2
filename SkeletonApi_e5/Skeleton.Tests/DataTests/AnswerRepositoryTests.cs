﻿using NUnit.Framework;
using Skeleton.DAL.Context;
using Skeleton.DAL.Entities;
using Skeleton.DAL.Repositories;
using Skeleton.Tests.Data;

namespace Skeleton.Tests.DataTests;

public class AnswerRepositoryTests
{
    [TestCase("d8d06d13-6a7e-417c-bbdb-76f9c6a1cfab")]
    [TestCase("6225b805-399f-47eb-8b37-b4ed4c286914")]
    public async Task AnswerRepository_GetByIdAsync_ReturnsValue(string id)
    {
        // arrange
        
        using var context = new QuizHubDatabaseContext(UnitTestHelper.GetUnitTestsDbOptions());
        var answerRepository = new AnswerRepository(context);

        var expected = RepositoryData.ExpectedAnswers.FirstOrDefault(x => x.Id.ToString() == id);

        // act

        var result = await answerRepository.GetByIdAsync(Guid.Parse(id));

        // assert
        
        Assert.IsNotNull(result, message: "Expected not null");
        Assert.That(result, Is.EqualTo(expected).Using(new AnswerEqualityComparer()), message: "Result is invalid");
    }

    [Test]
    public async Task AnswerRepository_GetAllAsync_ReturnsAllValues()
    {
        using var context = new QuizHubDatabaseContext(UnitTestHelper.GetUnitTestsDbOptions());
        var answerRepository = new AnswerRepository(context);

        var result = await answerRepository.GetAllAsync();
        
        Assert.That(result, Is.EqualTo(RepositoryData.ExpectedAnswers).Using(new AnswerEqualityComparer()), 
            message: "Results are not equal to expected");
    }

    [Test]
    public async Task AnswerRepository_AddAsync_AddsValueToDatabase()
    {
        using var context = new QuizHubDatabaseContext(UnitTestHelper.GetUnitTestsDbOptions());
        var answerRepository = new AnswerRepository(context);

        var newAnswer = new Answer { Text = "New question" };

        await answerRepository.AddAsync(newAnswer);
        await context.SaveChangesAsync();
        
        Assert.That(context.Answers.Count(), !Is.EqualTo(RepositoryData.ExpectedAnswers.Count()), message: "AddAsync works");
    }
    
    [Test]
    public async Task AnswerRepository_UpdateAsync_ValueUpdated()
    {
        using var context = new QuizHubDatabaseContext(UnitTestHelper.GetUnitTestsDbOptions());
        var answerRepository = new AnswerRepository(context);

        var answerId = Guid.Parse("6225b805-399f-47eb-8b37-b4ed4c286914");
        var notExpected = RepositoryData.ExpectedAnswers.FirstOrDefault(x => x.Id == answerId);
        var answer = new Answer
        {
            Id = answerId,
            Text = "Update test"
        };

        await answerRepository.UpdateAsync(answer);
        await context.SaveChangesAsync();
        
        Assert.That(answer, !Is.EqualTo(notExpected), message: "UpdateAsync works");
    }

    [TestCase("6225b805-399f-47eb-8b37-b4ed4c286914")]
    [TestCase("b1a30461-2173-416b-8281-a227c5cff8f7")]
    public async Task AnswerRepository_DeleteAsync_ObjectIsDeleted(string id)
    {
        using var context = new QuizHubDatabaseContext(UnitTestHelper.GetUnitTestsDbOptions());

        var answerRepository = new AnswerRepository(context);

        await answerRepository.DeleteAsync(Guid.Parse(id));
        await context.SaveChangesAsync();

        Assert.That(context.Answers.Count(), !Is.EqualTo(RepositoryData.ExpectedAnswers.Count()), message: "DeleteByIdAsync works incorrect");
    }
}