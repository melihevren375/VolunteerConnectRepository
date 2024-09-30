namespace Application.Features.Projects.Commands.Create;

public class CreatedProjectResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? DueDate { get; set; }
    public int? MaxVolunteers { get; set; }
}
