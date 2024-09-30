using MediatR;

namespace Application.Features.Volunteers.Commands.Create;

public class CreateVolunteerCommandHandler : IRequestHandler<CreateVolunteerCommand, CreatedVolunteerResponse>
{
    public Task<CreatedVolunteerResponse> Handle(CreateVolunteerCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
