using MediatR;

namespace Application.Features.Participations.Commands.Create;

public class CreateParticipationCommand : IRequest<CreatedParticipationResponse>
{
    public Guid VolunteerId { get; set; }
    public Guid ProjectId { get; set; }
    public Guid BeneficiaryId { get; set; }
}
