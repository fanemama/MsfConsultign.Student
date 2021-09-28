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
    public class UnregisterCommandHandler : IRequestHandler<UnregisterCommand>
    {
        private readonly IStudentService _studentService;
        public UnregisterCommandHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }


        public async Task<Unit> Handle(UnregisterCommand request, CancellationToken cancellationToken)
        {

            //************************mapp using automapper******************/

            //Student student = repository.GetById(command.Id);
            //if (student == null)
            //    return Result.Fail($"No student found for Id {command.Id}");

            //repository.Delete(student);
            //unitOfWork.Commit();

            //return Result.Ok();

            return await Unit.Task;
        }
    }
}
