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
    public class StudentController : ControllerBase
    {

        private readonly ILogger<StudentController> _logger;
        private readonly IMediator _mediator;

        public StudentController(ILogger<StudentController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search(string enrolled, int? number)
        {
            /// TODO: Automapper
            var command = new Lausa.Application.Service.Query.SearchStudentQuery();
            var students = await _mediator.Send(command);
            return Ok(students);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] Lausa.Dto.Student dto)
        {
            /// TODO: Automapper
            var command = new RegisterCommand();
            await _mediator.Send(command);
            return Ok();
        }

        [HttpDelete("unregister/{id}")]
        public async Task<IActionResult> Unregister(long id)
        {
            var command = new UnregisterCommand() {Id = id };
            await _mediator.Send(command);
            return Ok();
        }

        [HttpPost("{id}/enrollments")]
        public async Task<IActionResult> Enroll(long id, [FromBody] Enrollment dto)
        {
            var command = new EnrollCommand() { Id = id };
            
            /// TODO: Automapper
            await _mediator.Send(command);
            return Ok();
        }

        

        [HttpPut("{id}")]
        public async Task<IActionResult> EditPersonalInfo(long id, [FromBody] StudentPersonalInfo dto)
        {
            var command = new EditPersonalInfoCommand();
            /// TODO: Automapper
            await _mediator.Send(command);
            return Ok();
        }
    }
}
