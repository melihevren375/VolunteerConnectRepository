using MediatR;

namespace Application.Features.Projects.Commands.Create;

public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, CreatedProjectResponse>
{
    public Task<CreatedProjectResponse> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
