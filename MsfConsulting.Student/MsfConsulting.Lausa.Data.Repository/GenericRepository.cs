using System;

namespace MsfConsulting.Lausa.Data.Repository
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

        public void Save(T entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateT(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
