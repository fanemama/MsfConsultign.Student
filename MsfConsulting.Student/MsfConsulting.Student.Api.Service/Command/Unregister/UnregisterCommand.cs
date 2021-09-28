using MediatR;
using MsfConsulting.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Student.Api.Service.Command
{
    public class UnregisterCommand : IRequest
    {
        public long Id { get; set; }
    }
}
