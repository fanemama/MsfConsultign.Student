using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MsfConsulting.Lausa.Dto;
using MsfConsulting.Lausa.Application.Service.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MsfConsulting.Lausa.Student.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnrollController : ControllerBase
    {


        private readonly ILogger<StudentController> _logger;
        private readonly IMediator _mediator;

        public EnrollController(ILogger<StudentController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPut("enrollments/{id}")]
        public async Task<IActionResult> Transfer(long id, [FromBody] EnrollmentInfo dto)
        {
            var command = new TransferCommand() { Id = id, };

            /// TODO: Automapper
            await _mediator.Send(command);
            return Ok();
        }

        [HttpPost("{id}/deletion")]
        public async Task<IActionResult> Unenroll(long id,  string comment)
        {
            var command = new UnenrollCommand() { Id = id, Comment = comment };

            /// TODO: Automapper
            await _mediator.Send(command);
            return Ok();
        }
    }
}
