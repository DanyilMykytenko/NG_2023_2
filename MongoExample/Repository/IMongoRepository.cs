using MongoExample.Entity.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MongoExample.Repository
{
    public interface IMongoRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> FindOneAsync(Expression<Func<TEntity,bool>> filterExpression);
        Task InsertOneAsync(TEntity entity);
        Task DeleteOneAsync(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> FindByIdAsync(string id);
        Task ReplaceOneAsync(TEntity entity);
    }
}
