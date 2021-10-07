using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Dto
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public IList<Enrollment> Enrollements { get; set; } = new List<Enrollment>();
        public IList<Unenrollment> Unenrollements { get; set; } = new List<Unenrollment>();
    }
}
