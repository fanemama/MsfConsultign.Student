using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Data.Repository
{
    public interface IGenericRepository<T> where T:class
    {
        T GetTByID(int id);
        void Save(T entity);
        void DeleteT(int id);
        void UpdateT(T entity);
    }
}
