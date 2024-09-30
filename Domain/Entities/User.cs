namespace Domain.Entities;

public abstract class User : Entity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Email { get; set; }
    public Guid UserRoleId { get; set; }
    public string? Description { get; set; }
    public string PhoneNumber { get; set; }
    public UserRole UserRole { get; set; }
    public List<Project> Projects { get; set; }
    public List<Participation> Participations { get; set; }
}
