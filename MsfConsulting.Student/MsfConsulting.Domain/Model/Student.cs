using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Domain.Model
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public  IList<Enrollement> Enrollements { get; set; }
        public IList<UnEnrollement> UnEnrollements { get; set; }
    }
}
