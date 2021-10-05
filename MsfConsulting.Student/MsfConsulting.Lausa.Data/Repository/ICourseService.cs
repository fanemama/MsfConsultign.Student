using MsfConsulting.Lausa.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Data.Service
{
    public interface ICourseService
    {
        Task<Course> GetByCode(string code);
    }
}
