using MongoDB.Bson;
using MongoDB.Driver;
using MongoExample.Attributes;
using MongoExample.Entity.Collections;
using MongoExample.MongoDbSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MongoExample.Repository
{
    public class MongoRepository<TEntity> : IMongoRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly IMongoCollection<TEntity> _collection;
        public MongoRepository(IMongoDbSettings settings)
        {
            var database = new MongoClient(settings.ConnectionString).GetDatabase(settings.DatabaseName);
            _collection = database.GetCollection<TEntity>(GetCollectionName(typeof(TEntity)));
        }
        private protected string GetCollectionName(Type documentType)
        {
            return ((BsonCollectionAttribute)documentType.GetCustomAttributes(typeof(BsonCollectionAttribute), true).First()).CollectionName;
        }
        public virtual Task<TEntity> FindOneAsync(Expression<Func<TEntity,bool>> filterExpression)
        {
            return Task.Run(() => _collection.Find(filterExpression).FirstOrDefaultAsync());
        }
        public virtual Task<TEntity> FindByIdAsync(string id)
        {
            return Task.Run(() =>
            {
                var objectId = new ObjectId(id);
                var filter = Builders<TEntity>.Filter.Eq(doc => doc.Id, objectId);
                return _collection.Find(filter).FirstOrDefaultAsync();
            });
        }
        public virtual Task InsertOneAsync(TEntity document)
        {
            return Task.Run(()=>_collection.InsertOneAsync(document));
        }
        public virtual async Task ReplaceOneAsync(TEntity document)
        {
            var filter = Builders<TEntity>.Filter.Eq(doc => doc.Id, document.Id);
            await _collection.FindOneAndReplaceAsync(filter, document);
        } 
        public Task DeleteOneAsync(Expression<Func<TEntity,bool>> expression)
        {
            return Task.Run(()=>_collection.DeleteOneAsync(expression));
        }
    }
}
