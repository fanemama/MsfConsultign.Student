using MediatR;
using MsfConsulting.Lausa.Domain.Service;
using MsfConsulting.Lausa.Data.Repository;
using MsfConsulting.Lausa.Data.Model;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace MsfConsulting.Lausa.Application.Service.Command
{
    public class UnregisterCommandHandler : IRequestHandler<UnregisterCommand>
    {
        private readonly IRepository<Student> _studentRepository;
        private readonly IUnitOfWork _unitOfWork;
        public UnregisterCommandHandler(IRepository<Student> studentRepository, IUnitOfWork unitOfWork)
        {
            _studentRepository = studentRepository;
            _unitOfWork = unitOfWork;
        }


        public async Task<Unit> Handle(UnregisterCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetById(request.Id);
            if (student is null) throw new ArgumentException($"student with id '{request.Id}' not found");
           
            _studentRepository.Delete(student);
            _unitOfWork.SaveChanges();

            return await Unit.Task;
        }
    }
}
