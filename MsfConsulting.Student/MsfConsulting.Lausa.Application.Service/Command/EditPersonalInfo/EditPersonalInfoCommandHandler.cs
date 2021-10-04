using AutoMapper;
using MediatR;
using MsfConsulting.Lausa.Data.Repository;
using MsfConsulting.Lausa.Data.Model;
using System.Threading;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Application.Service.Command
{
    public class EditPersonalInfoCommandHandler : IRequestHandler<EditPersonalInfoCommand>
    {
        private readonly IRepository<Student> _studentRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EditPersonalInfoCommandHandler(
            IMapper mapper, 
            IRepository<Student> studentRepository,
            IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _studentRepository = studentRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(EditPersonalInfoCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetById(request.Id);
            student = _mapper.Map(request, student);

            _studentRepository.Update(student);
            _unitOfWork.SaveChanges();
            return await Unit.Task;
        }
    }
}
