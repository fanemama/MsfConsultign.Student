using AutoMapper;
using MsfConsulting.Lausa.Application.Service.Command;
using MsfConsulting.Lausa.Application.Service.Command.SetLocation;
using MsfConsulting.Lausa.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Domain.Service.Mapping
{
    public class ApplicationProfile: Profile
    {
        public ApplicationProfile()
        {
            
            CreateMap<RegisterCommand, Student>()
                .ForMember(x => x.Enrollements, opt => opt.Ignore())
                .ForMember(x => x.Unenrollements, opt => opt.Ignore());

            CreateMap<EditPersonalInfoCommand, Student>();
            CreateMap<SetLocationCommand, Location>();
        }
       
    }
}
