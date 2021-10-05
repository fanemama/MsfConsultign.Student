using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MsfConsulting.Lausa.Dto;
using MsfConsulting.Lausa.Application.Service.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace MsfConsulting.Lausa.Student.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnrollController : ControllerBase
    {


        private readonly ILogger<StudentController> _logger;
        private readonly IMediator _mediator;
        protected readonly IMapper _mapper;

        public EnrollController(ILogger<StudentController> logger, IMediator mediator, IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update(long id, [FromBody] EnrollmentInfo dto)
        {
            var command = new UpadteEnrollmentCommand(id) ;
            command = _mapper.Map(dto, command);
            /// TODO: Automapper
            await _mediator.Send(command);
            return Ok();
        }


    }
}
