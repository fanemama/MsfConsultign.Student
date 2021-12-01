using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MsfConsulting.Lausa.Dto;
using MsfConsulting.Lausa.Application.Service.Command;
using System.Threading.Tasks;
using AutoMapper;
using MsfConsulting.Lausa.Application.Service.Command.SetLocation;
using Microsoft.AspNetCore.SignalR;
using MsfConsulting.Lausa.Api.Hubs;
using MsfConsulting.Lausa.Domain.Model;
using Location = MsfConsulting.Lausa.Dto.Location;

namespace MsfConsulting.Lausa.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {

        private readonly ILogger<StudentController> _logger;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly IHubContext<LocationHub> _locationHub;

        public StudentController(ILogger<StudentController> logger, IMediator mediator, IMapper mapper, IHubContext<LocationHub> locationHub)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
            _locationHub = locationHub;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterStudent dto)
        {
            var command = _mapper.Map<RegisterCommand>(dto);
            var result = await _mediator.Send(command);
            return Ok(_mapper.Map<Dto.Student>(result));
        }

        [HttpDelete("unregister/{id}")]
        public async Task<IActionResult> Unregister(int id)
        {
            var command = new UnregisterCommand(id);
            await _mediator.Send(command);
            return Ok();
        }

        [HttpPost("{id}/enroll")]
        public async Task<IActionResult> Enroll(int id, [FromBody] Enroll dto)
        {
            var command = new EnrollCommand(id);
            command = _mapper.Map(dto, command);
            var result = await _mediator.Send(command);
            return Ok(_mapper.Map<Dto.Enrollment>(result));
        }

        [HttpPost("{id}/unenroll")]
        public async Task<IActionResult> Unenroll(int id, Unenroll dto)
        {
            var command = new UnenrollCommand(id);
            command = _mapper.Map(dto, command);
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

        [HttpPost("set-live-location/{studentId}")]
        public async Task<IActionResult> SetLiveLocation(int studentId, SetLocation location)
        {
            var command = new SetLocationCommand(studentId);
            command = _mapper.Map(location, command);
            var result = await _mediator.Send(command);
            await _locationHub.Clients.All.SendAsync("LocationChanged", _mapper.Map<Location>(result));
            return Ok();
        }
    }
}
