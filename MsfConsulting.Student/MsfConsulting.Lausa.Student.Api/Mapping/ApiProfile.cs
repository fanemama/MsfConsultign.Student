using AutoMapper;
using MsfConsulting.Lausa.Application.Service.Command;
using MsfConsulting.Lausa.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Student.Api.Mapping
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

            CreateMap<Domain.Model.Student, Dto.Student>();
            CreateMap<Enrollment, Dto.Enrollment>();
            CreateMap<Unenrollment, Dto.Enrollment>();



        }
       
    }
}
