using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Data.Model
{
    public class Course: IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Label { get; set; }
    }
}
