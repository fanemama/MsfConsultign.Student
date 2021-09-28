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
        public EnrollCommandHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }


        public async Task<Unit> Handle(EnrollCommand request, CancellationToken cancellationToken)
        {

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
