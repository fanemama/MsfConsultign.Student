using AutoMapper;
using MediatR;
using MsfConsulting.Lausa.Domain.Repository;
using MsfConsulting.Lausa.Domain.Model;
using System.Threading;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Application.Service.Command
{
    public class EditPersonalInfoCommandHandler : BaseCommandHandler, IRequestHandler<EditPersonalInfoCommand>
    {
        private readonly IRepository<Student> _studentRepository;

        public EditPersonalInfoCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IRepository<Student> studentRepository) : base(mapper, unitOfWork)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Unit> Handle(EditPersonalInfoCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetById(request.Id);
            student = _mapper.Map(request, student);

            _studentRepository.Update(student);
            await _unitOfWork.SaveChanges();
            return await Unit.Task;
        }
    }
}
