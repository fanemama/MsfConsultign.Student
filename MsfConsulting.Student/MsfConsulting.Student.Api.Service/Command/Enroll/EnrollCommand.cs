using MediatR;
using MsfConsulting.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Student.Api.Service.Command
{
    public class EnrollCommand : IRequest
    {
        public long Id { get; set; }
        public string Course { get; set; }
        public string Grade { get; set; }
    }
}
