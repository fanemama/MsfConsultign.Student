using AutoMapper;
using MsfConsulting.Lausa.Application.Service.Command;
using MsfConsulting.Lausa.Dto;
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
            //CreateMap<Dto.StudentPersonalInfo, Model.Student>().ReverseMap();
            //CreateMap<Dto.Enrollment, Model.Enrollment>().ReverseMap();
            //CreateMap<Dto.Unenrollment, Model.Unenrollment>().ReverseMap();
            
            CreateMap<RegisterStudent, RegisterCommand>();

            CreateMap<RegisterCommand, Model.Student>()
                .ForMember(x => x.Enrollements, opt => opt.Ignore())
                .ForMember(x => x.Unenrollements, opt => opt.Ignore());

           // .ForMember(dest => dest.Tags, opt => opt.MapFrom(so => so.Tags.Select(t => t.Name).ToList()));
        }
       
    }
}
