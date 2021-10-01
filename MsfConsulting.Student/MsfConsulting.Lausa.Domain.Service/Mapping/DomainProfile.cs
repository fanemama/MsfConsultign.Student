using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Domain.Service.Mapping
{
    public class DomainProfile: Profile
    {
        public DomainProfile()
        {
            CreateMap<Data.Model.Course, Model.Course>().ReverseMap();
            CreateMap<Data.Model.Enrollment, Model.Enrollment>().ReverseMap();
            CreateMap<Data.Model.Unenrollment, Model.Unenrollment>().ReverseMap();
            CreateMap<Data.Model.Grade, Domain.Model.Grade>().ReverseMap();
            CreateMap<Data.Model.Student, Domain.Model.Student>().ReverseMap();
        }
       
    }
}
