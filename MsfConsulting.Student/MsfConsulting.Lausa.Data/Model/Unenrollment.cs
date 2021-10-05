using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Data.Model
{
    public class Unenrollment: IEntity
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public Course Course { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Comment { get; set; }
    }
}
