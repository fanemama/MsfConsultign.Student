using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Domain.Model
{
    public class Enrollement
    {
        public Grade Grade { get; set; }
        public Course Course { get; set; }
        public DateTime Date { get; set; }
    }
}
