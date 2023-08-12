using DataAccessLayer.Data;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Service
{
    public class DbService
    {
        private readonly CircusDatabaseContext _ctx;

        public DbService(CircusDatabaseContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Clown> AddAsync(Clown entity)
        {
            await _ctx.Set<Clown>().AddAsync(entity);
            await _ctx.SaveChangesAsync();
            return entity;
        }

        public async Task<Clown> GetByIdAsync(Guid id)
        {
            var entity = await _ctx.Set<Clown>().FirstOrDefaultAsync(x => x.Id == id);
            return entity;
        }

        public async Task<IEnumerable<Clown>> GetAllAsync()
        {
            var entities = await _ctx.Set<Clown>().Select(x => x).ToListAsync();
            return entities;
        }

        public async Task UpdateAsync(Clown model)
        {
            _ctx.Update(model);
            await _ctx.SaveChangesAsync();
        }

        public async Task DeleteAsync(Clown model)
        {
            _ctx.Set<Clown>().Remove(model);
            await _ctx.SaveChangesAsync();
        }
    }
}
