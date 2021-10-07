using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MsfConsulting.Lausa.Dto;
using System.Threading.Tasks;
using MsfConsulting.Lausa.Read.Application.Service.Query;
using AutoMapper;
using MsfConsulting.Lausa.Read.Application.Service.Query.GetStudentById;

namespace MsfConsulting.Lausa.Read.Api.Controllers
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
        public async Task<IActionResult> Search([FromQuery]StudentFilter studentFilter)
        {
            var command = _mapper.Map<SearchStudentQuery>(studentFilter);
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Search(int id)
        {
            var command = new GetStudentByIdQuery(id);
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
