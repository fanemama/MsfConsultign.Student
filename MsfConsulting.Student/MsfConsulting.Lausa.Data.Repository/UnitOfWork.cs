using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public LausaContext DbContext => _dDbContext;
       
        private LausaContext _dDbContext;
        public UnitOfWork(LausaContext context)
        {
            _dDbContext = context;
        }

        public void SaveChanges()
        {
            _dDbContext.SaveChanges();
        }
 
    }
}
