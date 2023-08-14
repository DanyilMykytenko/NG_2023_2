
Greetings, we learnt Entity Framework, and ready for new challenge.

So, your task is to configure database for your future project using Entity Framework Core. 
Using of Fluent is required (no data annotations).  

We have several tables:
All tables are followed by BaseEntity abstraction (Id field);
 * The first entity is 'User' has such fields: Name, Surname, Password.
User may have several tests.
 * 'Test' entity: Title, Description, CreatedForUserId(FK).
Test may have several questions.
 * 'Question' entity has fields: Text, TestId(FK).
Question may have several answers
 * Entity 'Answer': Text, IsCorrect(true/false), QuestionId(FK) 
 
All entities must be included in AppDbContext.cs as DbSets and applying all configuration to 
the database.