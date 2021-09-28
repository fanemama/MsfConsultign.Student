using MediatR;
using MsfConsulting.Lausa.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MsfConsulting.Lausa.Domain.Model;
using MsfConsulting.Lausa.Data.Repository;

namespace MsfConsulting.Lausa.Application.Service.Command
{
    public class TransferCommandHandler : IRequestHandler<TransferCommand>
    {
        private readonly IStudentService _studentService;
        public TransferCommandHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }


        public Task<Unit> Handle(TransferCommand request, CancellationToken cancellationToken)
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

            //Enrollment enrollment = student.GetEnrollment(command.EnrollmentNumber);
            //if (enrollment == null)
            //    return Result.Fail($"No enrollment found with number '{command.EnrollmentNumber}'");

            //enrollment.Update(course, grade);

            //unitOfWork.Commit();


            return Unit.Task;
        }
    }
}
