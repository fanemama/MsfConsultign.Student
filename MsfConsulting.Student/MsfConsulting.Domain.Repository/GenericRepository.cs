using System;

namespace MsfConsulting.Domain.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void DeleteT(int id)
        {
            throw new NotImplementedException();
        }

        public T GetTByID(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertT(T entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateT(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
