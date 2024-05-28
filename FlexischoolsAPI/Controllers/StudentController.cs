using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.DTOs;
using Services.Interfaces;

namespace FlexischoolsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IService _services;

        public StudentController(IService services) => _services = services;

        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok(await _services.StudentService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccountById(int id, CancellationToken cancellationToken)
        {
            var accountDto = await _services.StudentService.GetByIdAsync(id, cancellationToken);

            return Ok(accountDto);
        }

        [HttpGet("GetBySubjectId")]
        public async Task<IActionResult> Retrieve(int subjectId, CancellationToken cancellationToken)
        {
            var response = await _services.StudentService.RetrieveAsync(subjectId, cancellationToken);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] StudentForCreationDto studentForCreationDto, CancellationToken cancellationToken)
        {
            var response = await _services.StudentService.AddAsync(studentForCreationDto, cancellationToken);

            return CreatedAtAction(nameof(Add), new { id = response.Id }, response);
        }
    }
}
