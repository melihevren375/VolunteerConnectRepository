using MediatR;

namespace Application.Features.UserRoles.Commands.Create;

public class CreateUserRoleCommandHandler : IRequestHandler<CreateUserRoleCommand, CreatedUserRoleResponse>
{
    public Task<CreatedUserRoleResponse> Handle(CreateUserRoleCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
