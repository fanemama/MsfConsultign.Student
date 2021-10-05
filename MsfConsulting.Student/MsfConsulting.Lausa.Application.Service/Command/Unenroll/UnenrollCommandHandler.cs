using MediatR;
using MsfConsulting.Lausa.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MsfConsulting.Lausa.Data.Repository;
using MsfConsulting.Lausa.Data.Model;

namespace MsfConsulting.Lausa.Application.Service.Command
{
    public class UnenrollCommandHandler : BaseCommandHandler, IRequestHandler<UnenrollCommand>
    {
        private readonly IRepository<Student> _studentRepository;
        private readonly IRepository<Enrollment> _enrollmentRepository;
        public UnenrollCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, 
            IRepository<Enrollment> enrollmentRepository, 
            IRepository<Student> studentRepository) : base(mapper, unitOfWork)
        {
            _enrollmentRepository = enrollmentRepository;
            _studentRepository = studentRepository;
        }

        public async Task<Unit> Handle(UnenrollCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetById(request.StudentId);
            var enrollment = await _enrollmentRepository.GetById(request.EnrollCommandId);

            student.UnEnroll(enrollment, request.Comment);
            await _unitOfWork.SaveChanges();

            return await Unit.Task;
        }
    }
}
