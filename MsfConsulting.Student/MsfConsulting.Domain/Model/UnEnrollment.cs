using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Domain.Model
{
    public class UnEnrollment
    {
        public int Id { get; set; }
        public Course Course { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
    }
}
