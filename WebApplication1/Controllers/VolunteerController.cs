using Application.Features.Volunteers.Commands.Create;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[Volunteers]")]
    [ApiController]
    public class VolunteerController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateVolunteerCommand createVolunteerCommand)
        {
            CreatedVolunteerResponse createdVolunteerResponse = await Mediator.Send(createVolunteerCommand);
            return StatusCode(201, createdVolunteerResponse);
        }
    }
}
