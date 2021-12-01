using MediatR;
using MsfConsulting.Lausa.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Read.Application.Service.Query.GetAllStudentLocation
{
    public class GetAllStudentLocationQuery : IRequest<IEnumerable<StudentLocation>>
    {
    }
}
