using AutoMapper;
using MsfConsulting.Lausa.Read.Application.Service.Query;
using MsfConsulting.Lausa.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Read.Api.Mapping
{
    public class ReadApiProfile: Profile
    {
        public ReadApiProfile()
        {
            CreateMap<Dto.StudentFilter, SearchStudentQuery>();
        }
       
    }
}
