using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Application.Service.Query
{
    public class SearchStudentQuery: IRequest<IEnumerable<MsfConsulting.Lausa.Dto.Student>>
    {
    }
}
