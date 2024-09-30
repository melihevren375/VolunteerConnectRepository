using MediatR;

namespace Application.Features.UserRoles.Commands.Create;

public class CreateUserRoleCommand : IRequest<CreatedUserRoleResponse>
{
    public string Name { get; set; }
}
