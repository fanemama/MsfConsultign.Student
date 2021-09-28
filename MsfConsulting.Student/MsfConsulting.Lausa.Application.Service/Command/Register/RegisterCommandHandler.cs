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
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand>
    {
        private readonly IStudentService _studentService;
        public RegisterCommandHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public async Task<Unit> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var student = new Lausa.Domain.Model.Student() { };

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
            return await Unit.Task;
        }
    }
}
