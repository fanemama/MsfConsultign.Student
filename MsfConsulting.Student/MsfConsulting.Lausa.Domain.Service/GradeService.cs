using AutoMapper;
using MsfConsulting.Lausa.Data.Repository;
using MsfConsulting.Lausa.Domain.Model;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MsfConsulting.Lausa.Domain.Service
{
    public class GradeService : DomainService, IGradeService
    {
        private readonly IRepository<Data.Model.Grade> _repositoryGrade;
        public GradeService(
            IMapper mapper,
            IUnitOfWork unitOfWork,
            IRepository<Data.Model.Grade> repositoryGrade) : base(mapper, unitOfWork)
        {
            _repositoryGrade = repositoryGrade;
        }

        public async Task<Grade> GetByCode(string code)
        {
            var Grade = await _repositoryGrade.GetAll().FirstOrDefaultAsync(x => x.Code == code);
            return _mapper.Map<MsfConsulting.Lausa.Domain.Model.Grade>(Grade);
        }
    }
}
