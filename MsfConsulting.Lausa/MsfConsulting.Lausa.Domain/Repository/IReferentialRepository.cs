using MsfConsulting.Lausa.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Domain.Repository
{
    public interface IReferentialRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity, IReferential
    {
        Task<TEntity> GetByCode(string code);
    }
}
