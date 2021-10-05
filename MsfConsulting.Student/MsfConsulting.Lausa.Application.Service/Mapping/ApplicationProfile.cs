using AutoMapper;
using MsfConsulting.Lausa.Application.Service.Command;
using MsfConsulting.Lausa.Data.Model;
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
            
            CreateMap<Dto.RegisterStudent, RegisterCommand>();
            CreateMap<RegisterCommand, Student>()
                .ForMember(x => x.Enrollements, opt => opt.Ignore())
                .ForMember(x => x.Unenrollements, opt => opt.Ignore());

            CreateMap<Dto.StudentPersonalInfo, EditPersonalInfoCommand>();
            CreateMap<EditPersonalInfoCommand, Student>();

            CreateMap<Dto.Enroll, EnrollCommand>();
            CreateMap<Dto.Unenroll, UnenrollCommand>();

            CreateMap<Dto.EnrollmentInfo, UpadteEnrollmentCommand>();



        }
       
    }
}
