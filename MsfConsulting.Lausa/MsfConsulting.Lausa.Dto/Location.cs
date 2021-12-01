using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Dto
{
    public class Location
    {
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Speed { get; set; }
        public double Elevation { get; set; }
        public double Heading { get; set; }
        public DateTime Date { get; set; }
        public int? StudentId { get; set; }
    }
}
