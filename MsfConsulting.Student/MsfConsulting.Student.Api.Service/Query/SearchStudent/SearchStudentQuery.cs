using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Student.Api.Service.Query
{
    public class SearchStudentQuery: IRequest<IEnumerable<Dto.Student>>
    {
    }
}
