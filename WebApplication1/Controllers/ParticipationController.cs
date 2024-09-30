using Application.Features.Participations.Commands.Create;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[Participations]")]
    [ApiController]
    public class ParticipationController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateParticipationCommand createParticipationCommand)
        {
            CreatedParticipationResponse createdParticipationResponse = await Mediator.Send(createParticipationCommand);
            return StatusCode(201, createdParticipationResponse);
        }
    }
}
