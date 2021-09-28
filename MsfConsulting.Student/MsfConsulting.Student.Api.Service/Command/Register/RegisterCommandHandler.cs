using MediatR;
using MsfConsulting.Business.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MsfConsulting.Business.Model;

namespace MsfConsulting.Student.Api.Service.Command
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand>
    {
        private readonly IStudentService _studentService;
        public RegisterCommandHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public Task<Unit> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var student = new Business.Model.Student() { };

            //************************mapp using automapper******************/

            //if (command.Course1 != null && command.Course1Grade != null)
            //{
            //    Course course = courseRepository.GetByName(command.Course1);
            //    student.Enroll(course, Enum.Parse<Grade>(command.Course1Grade));
            //}

            //if (command.Course2 != null && command.Course2Grade != null)
            //{
            //    Course course = courseRepository.GetByName(command.Course2);
            //    student.Enroll(course, Enum.Parse<Grade>(command.Course2Grade));
            //}

            _studentService.Register(student);
            return Unit.Task;
        }
    }
}
