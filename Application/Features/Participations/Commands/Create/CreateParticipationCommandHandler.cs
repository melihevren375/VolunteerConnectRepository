using MediatR;

namespace Application.Features.Participations.Commands.Create;

public class CreateParticipationCommandHandler : IRequestHandler<CreateParticipationCommand, CreatedParticipationResponse>
{
    public Task<CreatedParticipationResponse> Handle(CreateParticipationCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
