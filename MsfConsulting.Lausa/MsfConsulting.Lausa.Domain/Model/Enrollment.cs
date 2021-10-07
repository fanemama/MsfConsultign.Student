using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Domain.Model
{
    public class Enrollment: IEntity
    {
        private Enrollment()
        {

        }
        public Enrollment(Course course, Grade grade)
        {
            Course = course;
            Grade = grade;
        }

        public int Id { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int? GradeId { get; set; }
        public Grade Grade { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
