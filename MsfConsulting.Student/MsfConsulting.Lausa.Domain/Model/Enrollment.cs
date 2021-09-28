using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Domain.Model
{
    public class Enrollment
    {
        public Enrollment(Course course, Grade grade)
        {
            Course = course;
            Grade = grade;
            Date = DateTime.Now;
        }

        public int Id { get; set; }
        public Grade Grade { get; set; }
        public Course Course { get; set; }
        public DateTime Date { get; set; } 
    }
}
