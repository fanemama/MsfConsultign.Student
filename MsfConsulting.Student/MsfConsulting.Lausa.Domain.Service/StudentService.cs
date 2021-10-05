using AutoMapper;
using MsfConsulting.Lausa.Data.Repository;
using MsfConsulting.Lausa.Domain.Model;
using DataModel = MsfConsulting.Lausa.Data.Model;
using System;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Domain.Service
{
    public class StudentService : DomainService, IStudentService
    {
        private readonly IRepository<DataModel.Student> _studentRepository;
        public StudentService(
            IMapper mapper, 
            IUnitOfWork unitOfWork,
            IRepository<DataModel.Student> studentRepository) : base(mapper, unitOfWork)
        {
            this._studentRepository = studentRepository;
        }

        public void UpdatePersonalInfo(StudentPersonalInfo studentPersonalInfo)
        {
            throw new NotImplementedException();
        }

        public void Enroll(int id, Enrollment enrollment)
        {
            throw new NotImplementedException();
        }

        public void Register(Student student)
        {
            var studentToregidter = _mapper.Map<DataModel.Student>(student);
            _studentRepository.Insert(studentToregidter);
            _unitOfWork.SaveChanges();
        }

        public void Unenroll(int id, Enrollment enrollment)
        {
            throw new NotImplementedException();
        }

        public void Unregister(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Student> GetById(int id)
        {
            var result = await this._studentRepository.GetById(id);
            return _mapper.Map<Student>(result);
        }
    }
}
