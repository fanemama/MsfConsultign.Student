using AutoMapper;
using MsfConsulting.Lausa.Data.Repository;
using MsfConsulting.Lausa.Domain.Model;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 

namespace MsfConsulting.Lausa.Domain.Service
{
    public class CourseService : DomainService, ICourseService
    {
        private readonly IRepository<Data.Model.Course> _repositoryCourse;
        public CourseService(
            IMapper mapper,
            IUnitOfWork unitOfWork,
            IRepository<Data.Model.Course> repositoryCourse) : base(mapper, unitOfWork)
        {
            _repositoryCourse = repositoryCourse;
        }

        public async Task<Course> GetByCode(string code) {
            var course = await _repositoryCourse.GetAll().FirstOrDefaultAsync(x => x.Code == code);
            return _mapper.Map<MsfConsulting.Lausa.Domain.Model.Course>(course);
    }
    }
}
