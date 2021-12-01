using AutoMapper;
using MsfConsulting.Lausa.Application.Service.Command;
using MsfConsulting.Lausa.Application.Service.Command.SetLocation;
using MsfConsulting.Lausa.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Api.Mapping
{
    public class ApiProfile: Profile
    {
        public ApiProfile()
        {
            
            CreateMap<Dto.RegisterStudent, RegisterCommand>();
            CreateMap<Dto.StudentPersonalInfo, EditPersonalInfoCommand>();
            CreateMap<EditPersonalInfoCommand, Domain.Model.Student>();
            CreateMap<Dto.Enroll, EnrollCommand>();
            CreateMap<Dto.Unenroll, UnenrollCommand>();
            CreateMap<Dto.EnrollmentInfo, UpadteEnrollmentCommand>();
            CreateMap<Dto.SetLocation, SetLocationCommand>();

            CreateMap<Student, Dto.Student>();
            CreateMap<Enrollment, Dto.Enrollment>()
                 .ForMember(x => x.Course, opt => opt.MapFrom(x=> x.Course.Code))
                 .ForMember(x => x.Grade, opt => opt.MapFrom(x => x.Grade.Code));
            
            CreateMap<Unenrollment, Dto.Unenrollment>()
                 .ForMember(x => x.Course, opt => opt.MapFrom(x => x.Course.Code));
            CreateMap<Location, Dto.Location>();



        }
       
    }
}
