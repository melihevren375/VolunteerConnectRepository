using Application.Features.Beneficiaries.Commands.Create;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[Beneficiaries]")]
    [ApiController]
    public class BeneficiaryController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateBeneficiaryCommand createBeneficiaryCommand)
        {
            CreatedBeneficiaryResponse createdBeneficiaryResponse = await Mediator.Send(createBeneficiaryCommand);
            return StatusCode(201, createdBeneficiaryResponse);
        }
    }
}
