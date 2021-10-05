using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public LausaDbContext DbContext => _dDbContext;
       
        private LausaDbContext _dDbContext;
        public UnitOfWork(LausaDbContext context)
        {
            _dDbContext = context;
        }

        public async Task SaveChanges()
        {
            await _dDbContext.SaveChangesAsync();
        }
 
    }
}
