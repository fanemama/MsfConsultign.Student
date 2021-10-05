using MediatR;
using MsfConsulting.Lausa.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Application.Service.Command
{
    public class UnregisterCommand : IRequest
    {
        public UnregisterCommand(int id)
        {
            Id = id;
        }
        public int Id { get; private set; }
    }
}
