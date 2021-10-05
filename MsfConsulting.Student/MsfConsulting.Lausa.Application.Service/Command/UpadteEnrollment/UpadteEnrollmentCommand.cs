using MediatR;
using MsfConsulting.Lausa.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Application.Service.Command
{
    public class UpadteEnrollmentCommand : IRequest
    {
        private long id;

        public UpadteEnrollmentCommand(long id)
        {
            this.id = id;
        }

        public int Id { get; set; }
        public string Course { get; set; }
        public string Grade { get; set; }
    }
}
