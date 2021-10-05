using AutoMapper;
using MediatR;
using MsfConsulting.Lausa.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Application.Service.Command
{
    public class EnrollCommandHandler : IRequestHandler<EnrollCommand>
    {
        private readonly IStudentService _studentService;
        private readonly ICourseService _courseService;
        private readonly IGradeService _gradeService;
        private readonly IMapper _mapper;
        public EnrollCommandHandler(IStudentService studentService, ICourseService courseService, IMapper mapper, IGradeService gradeService)
        {
            _studentService = studentService;
            _courseService = courseService;
            _mapper = mapper;
            _gradeService = gradeService;
        }


        public async Task<Unit> Handle(EnrollCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentService.GetById(request.StudentId);

            var course = await _courseService.GetByCode(request.Course);
            if (course is null) throw new ArgumentException($"Course with code '{request.Course}' not foumd");

            var grade = await _gradeService.GetByCode(request.Grade);
            if (grade is null) throw new ArgumentException($"Course with code '{request.Grade}' not foumd");
            
            student.Enroll(course, grade);
            //************************mapp using automapper******************/

            //Student student = studentRepository.GetById(command.Id);
            //if (student == null)
            //    return Result.Fail($"No student found with Id '{command.Id}'");

            //Course course = courseRepository.GetByName(command.Course);
            //if (course == null)
            //    return Result.Fail($"Course is incorrect: '{command.Course}'");

            //bool success = Enum.TryParse(command.Grade, out Grade grade);
            //if (!success)
            //    return Result.Fail($"Grade is incorrect: '{command.Grade}'");

            //student.Enroll(course, grade);

            //unitOfWork.Commit();

            return await Unit.Task;
        }
    }
}
