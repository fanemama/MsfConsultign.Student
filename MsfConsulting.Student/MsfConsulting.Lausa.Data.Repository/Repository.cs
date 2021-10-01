using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Threading.Tasks;
using MsfConsulting.Lausa.Data.Model;

namespace MsfConsulting.Lausa.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {

        private readonly DbSet<TEntity> _dbSet;
        private LausaDbContext _dbContext;
        public Repository(LausaDbContext lausaContext)
        {
            _dbContext = lausaContext;
            _dbSet = lausaContext.Set<TEntity>();
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(x=> x.Id == id);
        }

        public void Insert(TEntity entity)
        {
             _dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
