using MediatR;
using MsfConsulting.Lausa.Domain.Model.Search;
using MsfConsulting.Lausa.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Read.Application.Service.Query
{
    public class SearchStudentQuery : IRequest<IEnumerable<LightStudent>>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
