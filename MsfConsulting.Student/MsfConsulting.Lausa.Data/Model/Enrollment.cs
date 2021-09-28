using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Data.Model
{
    public class Enrollment
    {
        public int Id { get; set; }
        public Grade Grade { get; set; }
        public Course Course { get; set; }
        public DateTime Date { get; set; }
    }
}
