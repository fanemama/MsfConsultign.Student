using MediatR;
using MsfConsulting.Lausa.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Application.Service.Command.SetLocation
{
    public class SetLocationCommand : IRequest<Location>
    {
        public int StudentId { get; private set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Speed { get; set; }
        public double Elevation { get; set; }
        public double Heading { get; set; }
        public DateTime Date { get; set; }


        public SetLocationCommand(int studentId)
        {
            StudentId = studentId;
        }
    }
}
