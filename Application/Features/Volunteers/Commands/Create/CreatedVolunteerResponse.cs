namespace Application.Features.Volunteers.Commands.Create;

public class CreatedVolunteerResponse
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Email { get; set; }
    public Guid UserRoleId { get; set; }
    public string? Description { get; set; }
    public string PhoneNumber { get; set; }
    public string? Skills { get; set; }
    public string? Availability { get; set; }
}
