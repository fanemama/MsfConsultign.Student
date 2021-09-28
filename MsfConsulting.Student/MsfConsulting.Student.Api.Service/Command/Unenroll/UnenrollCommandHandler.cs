using MediatR;
using MsfConsulting.Business.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MsfConsulting.Business.Model;
using MsfConsulting.Domain.Repository;

namespace MsfConsulting.Student.Api.Service.Command
{
    public class UnenrollCommandHandler : IRequestHandler<UnenrollCommand>
    {
        private readonly IStudentService _studentService;
        public UnenrollCommandHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }


        public async Task<Unit> Handle(UnenrollCommand request, CancellationToken cancellationToken)
        {

            //************************mapp using automapper******************/

            // Student student = studentRepository.GetById(command.Id);
            //    if (student == null)
            //        return Result.Fail($"No student found for Id {command.Id}");

            //    if (string.IsNullOrWhiteSpace(command.Comment))
            //        return Result.Fail("Disenrollment comment is required");

            //    Enrollment enrollment = student.GetEnrollment(command.EnrollmentNumber);
            //    if (enrollment == null)
            //        return Result.Fail($"No enrollment found with number '{command.EnrollmentNumber}'");

            //    student.RemoveEnrollment(enrollment, command.Comment);

            //    unitOfWork.Commit();

            //    return Result.Ok();

            //_studentService.Register(student);

            return await Unit.Task;
        }
    }
}
