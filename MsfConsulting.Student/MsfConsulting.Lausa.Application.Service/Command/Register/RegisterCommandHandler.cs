using AutoMapper;
using MediatR;
using MsfConsulting.Lausa.Domain.Model;
using MsfConsulting.Lausa.Domain.Repository;
using MsfConsulting.Lausa.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Application.Service.Command
{
    public class RegisterCommandHandler : BaseCommandHandler, IRequestHandler<RegisterCommand, Student>
    {
        private readonly IRepository<Student>  _studentRepository;
        private readonly IReferentialRepository<Course> _courseRepository;

        public RegisterCommandHandler(
            IMapper mapper, 
            IUnitOfWork unitOfWork,
            IRepository<Student> studentRepository,
            IReferentialRepository<Course> courseRepository
            ) : base(mapper, unitOfWork)
        {
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
        }

        public async Task<Student> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var student = _mapper.Map<Student>(request);
            foreach (var courseCode in request.Enrollements)
            {
                var course = await _courseRepository.GetByCode(courseCode);
                if (course is null) throw new ArgumentException($"Course with code '{course}' not foumd");

                student.Enroll(course);
            }

            _studentRepository.Insert(student);
            await _unitOfWork.SaveChanges();
            return student;
        }
    }
}
