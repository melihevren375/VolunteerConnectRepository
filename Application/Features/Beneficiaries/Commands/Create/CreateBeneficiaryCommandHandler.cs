using MediatR;

namespace Application.Features.Beneficiaries.Commands.Create;

public class CreateBeneficiaryCommandHandler : IRequestHandler<CreateBeneficiaryCommand, CreatedBeneficiaryResponse>
{
    public Task<CreatedBeneficiaryResponse>? Handle(CreateBeneficiaryCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
