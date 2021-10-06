using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Threading.Tasks;
using MsfConsulting.Lausa.Domain.Model;

namespace MsfConsulting.Lausa.Domain.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {

        protected readonly DbSet<TEntity> _dbSet;
        protected LausaDbContext _dbContext;
        public Repository(LausaDbContext lausaContext)
        {
            _dbContext = lausaContext;
            _dbSet = lausaContext.Set<TEntity>();
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(x=> x.Id == id);
        }

        public virtual void Insert(TEntity entity)
        {
             _dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
