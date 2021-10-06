using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MsfConsulting.Lausa.Dto;
using System.Threading.Tasks;
using MsfConsulting.Lausa.Read.Application.Service.Query;

namespace MsfConsulting.Lausa.Read.Api.Controllers
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
            var command = new SearchStudentQuery();
            var students = await _mediator.Send(command);
            return Ok(students);
        }
    }
}
