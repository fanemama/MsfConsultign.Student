using Microsoft.EntityFrameworkCore;
using MsfConsulting.Lausa.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Domain.Repository
{
    public class ReferentialRepository<TEntity> : Repository<TEntity>, IReferentialRepository<TEntity>
        where TEntity : class, IEntity, IReferential
    {
        public ReferentialRepository(LausaDbContext lausaContext) : base(lausaContext)
        {
        }

        public async Task<TEntity> GetByCode(string code)
        {
            return await this._dbSet.FirstOrDefaultAsync(x => x.Code == code);
        }
    }
}
