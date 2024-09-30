namespace Application.Features.Participations.Commands.Create;

public class CreatedParticipationResponse
{
    public Guid Id { get; set; }
    public Guid VolunteerId { get; set; }
    public Guid ProjectId { get; set; }
    public Guid BeneficiaryId { get; set; }
}
