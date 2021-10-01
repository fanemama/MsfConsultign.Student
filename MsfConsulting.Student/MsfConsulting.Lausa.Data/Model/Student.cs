using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Data.Model
{
    public class Student: IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public  IList<Enrollment> Enrollements { get; set; }
        public IList<Unenrollment> UnEnrollements { get; set; }
    }
}
