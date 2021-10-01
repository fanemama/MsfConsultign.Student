using AutoMapper;
using MsfConsulting.Lausa.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Domain.Service
{
    public abstract class DomainService
    {
        protected readonly IMapper _mapper;
        protected readonly IUnitOfWork _unitOfWork;
        public DomainService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
    }
}
