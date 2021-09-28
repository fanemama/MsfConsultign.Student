using MediatR;
using MsfConsulting.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Student.Api.Service.Command
{
    public class RegisterCommand : IRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public IList<Enrollment> Enrollements { get; set; }
        public IList<UnEnrollment> UnEnrollements { get; set; }
    }
}
