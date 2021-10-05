using AutoMapper;
using MediatR;
using MsfConsulting.Lausa.Data.Model;
using MsfConsulting.Lausa.Data.Repository;
using MsfConsulting.Lausa.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Application.Service.Command
{
    public class EnrollCommandHandler : BaseCommandHandler, IRequestHandler<EnrollCommand>
    {
        private readonly IRepository<Student> _studentRepository;
        private readonly IReferentialRepository<Course> _courseRepository;
        private readonly IReferentialRepository<Grade> _gradeRepository;

        public EnrollCommandHandler(
            IMapper mapper, 
            IUnitOfWork unitOfWork,
            IRepository<Student> studentRepository,
            IReferentialRepository<Course> courseRepository,
            IReferentialRepository<Grade> gradeRepository) : base(mapper, unitOfWork)
        {
            _courseRepository = courseRepository;
            _gradeRepository = gradeRepository;
            _studentRepository = studentRepository;
        }

        public async Task<Unit> Handle(EnrollCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetById(request.StudentId);

            var course = await _courseRepository.GetByCode(request.Course);
            if (course is null) throw new ArgumentException($"Course with code '{request.Course}' not foumd");

            var grade = await _gradeRepository.GetByCode(request.Grade);
            if (grade is null) throw new ArgumentException($"Grade with code '{request.Grade}' not foumd");
            
            student.Enroll(course, grade);
            _studentRepository.Update(student);
            await _unitOfWork.SaveChanges();

            return await Unit.Task;
        }
    }
}
