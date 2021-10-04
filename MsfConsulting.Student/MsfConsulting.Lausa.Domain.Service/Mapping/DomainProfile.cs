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
            
            CreateMap<Data.Model.Enrollment, Model.Enrollment>();
            CreateMap<Model.Enrollment, Data.Model.Enrollment>()
            .ForMember(x => x.Course, opt => opt.Ignore())
            .ForMember(x => x.Grade, opt => opt.Ignore())
            .ForMember(x => x.CourseId, opt => opt.MapFrom(so => so.Course.Id))
             .ForMember(x => x.GradeId, opt => opt.MapFrom(so => so.Grade != null ? (int?)so.Grade.Id : null));

            CreateMap<Data.Model.Unenrollment, Model.Unenrollment>().ReverseMap();
            CreateMap<Data.Model.Grade, Domain.Model.Grade>().ReverseMap();
            CreateMap<Data.Model.Student, Domain.Model.Student>().ReverseMap();
        }
       
    }
}
