using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Application.Service.Command
{
    public class UnenrollCommand : IRequest
    {
        public UnenrollCommand(int id)
        {
            StudentId = id;
        }
        public int StudentId { get; private set; }

        public int EnrollCommandId { get; set; }
        public string Comment { get; set; }
    }
}
