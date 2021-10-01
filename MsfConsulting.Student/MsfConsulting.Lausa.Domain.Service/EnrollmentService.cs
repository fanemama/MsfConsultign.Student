using AutoMapper;
using MsfConsulting.Lausa.Data.Repository;
using MsfConsulting.Lausa.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Domain.Service
{
    public class EnrollmentService : DomainService, IEnrollmentService
    {
        public EnrollmentService(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper,unitOfWork)
        {

        }
        public void Transfer(long id, Course course)
        {
            throw new NotImplementedException();
        }
    }
}
