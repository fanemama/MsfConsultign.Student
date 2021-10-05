using AutoMapper;
using MediatR;
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
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand>
    {
        private readonly IStudentService _studentService;
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;
        public RegisterCommandHandler(IStudentService studentService, IMapper mapper, ICourseService courseService)
        {
            _studentService = studentService;
            _mapper = mapper;
            _courseService = courseService;
        }

        public async Task<Unit> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var student = _mapper.Map<Domain.Model.Student>(request);
            foreach (var courseCode in request.Enrollements)
            {
                var course = await _courseService.GetByCode(courseCode);
                if (course is null) throw new ArgumentException($"Course with code '{course}' not foumd");

                student.Enroll(course);
            }

            _studentService.Register(student);
            return await Unit.Task;
        }
    }
}
