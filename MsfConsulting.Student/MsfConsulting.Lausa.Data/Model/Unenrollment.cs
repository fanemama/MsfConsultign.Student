using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Data.Model
{
    public class Unenrollment: IEntity
    {
        private Unenrollment()
        {

        }

        public Unenrollment(Course course, string comment)
        {
            Course = course;
            Comment = comment;
        }

        public int Id { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Comment { get; set; }
    }
}
