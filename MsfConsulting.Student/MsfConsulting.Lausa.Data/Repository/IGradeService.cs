using MsfConsulting.Lausa.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Data.Repository
{
    public interface IGradeRepository
    {
        Task<Grade> GetByCode(string code);
    }
}
