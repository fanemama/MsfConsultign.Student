using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MsfConsulting.Lausa.Dto;
using MsfConsulting.Lausa.Application.Service.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enrollment = MsfConsulting.Lausa.Dto.Enrollment;
using AutoMapper;
using MsfConsulting.Lausa.Domain.Model;

namespace MsfConsulting.Lausa.Student.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {

        private readonly ILogger<StudentController> _logger;
        private readonly IMediator _mediator;
        protected readonly IMapper _mapper;

        public StudentController(ILogger<StudentController> logger, IMediator mediator, IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
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
        public async Task<IActionResult> Register([FromBody] RegisterStudent dto)
        {
             var command = _mapper.Map<RegisterCommand>(dto);
            await _mediator.Send(command);
            return Ok();
        }

        [HttpDelete("unregister/{id}")]
        public async Task<IActionResult> Unregister(int id)
        {
            var command = new UnregisterCommand(id);
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

        

        [HttpPut("edit-personal-info/{id}")]
        public async Task<IActionResult> EditPersonalInfo(int id, [FromBody] Dto.StudentPersonalInfo studentPersonalInfo)
        {
            var command = new EditPersonalInfoCommand(id);
              command = _mapper.Map(studentPersonalInfo, command);

            await _mediator.Send(command);
            return Ok();
        }
    }
}
