using MediatR;
using MsfConsulting.Lausa.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MsfConsulting.Lausa.Domain.Repository;
using AutoMapper;
using MsfConsulting.Lausa.Domain.Model;

namespace MsfConsulting.Lausa.Application.Service.Command
{
    public class UpadteEnrollmentCommandHandler:  BaseCommandHandler, IRequestHandler<UpadteEnrollmentCommand>
    {
        private readonly IRepository<Enrollment> _enrollmentRepository;
        private readonly IReferentialRepository<Course> _courseRepository;
        private readonly IReferentialRepository<Grade> _gradeRepository;
        public UpadteEnrollmentCommandHandler(IMapper mapper, IUnitOfWork unitOfWork,
        IRepository<Enrollment> enrollmentRepository, IReferentialRepository<Grade> gradeRepository, IReferentialRepository<Course> courseRepository) : base(mapper, unitOfWork)
        {
            _enrollmentRepository = enrollmentRepository;
            _gradeRepository = gradeRepository;
            _courseRepository = courseRepository;
        }


        public async Task<Unit> Handle(UpadteEnrollmentCommand request, CancellationToken cancellationToken)
        {

            var enrollment = await _enrollmentRepository.GetById(request.Id);

            var course = await _courseRepository.GetByCode(request.Course);
            if (course is null) throw new EnrollmentException($"Course with code '{request.Course}' not foumd");

            var grade = await _gradeRepository.GetByCode(request.Grade);
            if (grade is null) throw new EnrollmentException($"Grade with code '{request.Grade}' not foumd");

            enrollment.Course = course;
            enrollment.Grade = grade;
            await _unitOfWork.SaveChanges();

            return await Unit.Task;
        }
    }
}
