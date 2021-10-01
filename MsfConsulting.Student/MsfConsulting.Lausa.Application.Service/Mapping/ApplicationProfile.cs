using AutoMapper;
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
            CreateMap<Dto.StudentPersonalInfo, Model.Student>().ReverseMap();
            CreateMap<Dto.Enrollment, Model.Enrollment>().ReverseMap();
            CreateMap<Dto.Unenrollment, Model.Unenrollment>().ReverseMap();
            CreateMap<Dto.Student, Domain.Model.Student>().ReverseMap();
        }
       
    }
}
