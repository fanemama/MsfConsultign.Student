using AutoMapper;
using MediatR;
using MsfConsulting.Lausa.Domain.Model;
using MsfConsulting.Lausa.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Application.Service.Command.SetLocation
{
    public class SetLocationCommandHandler : BaseCommandHandler, IRequestHandler<SetLocationCommand, Location>
    {
        private readonly IRepository<Student> _studentRepository;
        public SetLocationCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IRepository<Student> studentRepository) : base(mapper, unitOfWork)
        {
            _studentRepository = studentRepository;
        }


        public async Task<Location> Handle(SetLocationCommand request, CancellationToken cancellationToken)
        {

            var student = await _studentRepository.GetById(request.StudentId);

            if (student is null) throw new LocationException($"student  not foumd");

            var location = _mapper.Map<Location>(request);
            student.LiveLocation = location;
            await _unitOfWork.SaveChanges();

            return location;
        }
    }
}

