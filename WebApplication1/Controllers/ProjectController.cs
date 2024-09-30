using Application.Features.Projects.Commands.Create;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[Projects]")]
    [ApiController]
    public class ProjectController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateProjectCommand createProjectCommand)
        {
            CreatedProjectResponse createdProjectResponse = await Mediator.Send(createProjectCommand);
            return StatusCode(201, createdProjectResponse);
        }
    }
}
