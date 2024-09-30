using Application.Features.UserRoles.Commands.Create;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[UserRoles]")]
    [ApiController]
    public class UserRoleController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateUserRoleCommand createUserRoleCommand)
        {
            CreatedUserRoleResponse createdUserRoleResponse = await Mediator.Send(createUserRoleCommand);
            return StatusCode(201, createdUserRoleResponse);
        }
    }
}
