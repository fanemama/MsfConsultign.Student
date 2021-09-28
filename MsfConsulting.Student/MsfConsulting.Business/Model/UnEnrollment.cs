using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Business.Model
{
    public class Unenrollment
    {
        public Unenrollment(Course course, string comment)
        {
            Course = course;
            Comment = comment;
        }

        public int Id { get; set; }
        public Course Course { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
    }
}
