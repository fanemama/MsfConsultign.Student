using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Data.Repository
{
    public interface IUnitOfWork 
    {
        Task SaveChanges();
    }
}
