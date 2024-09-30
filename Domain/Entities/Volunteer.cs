namespace Domain.Entities;

public class Volunteer : User
{

    public Volunteer(Guid id, string? skills, string? availability)
    {
        Id = id;
        Skills = skills;
        Availability = availability;
    }

    public Volunteer()
    {

    }

    public string? Skills { get; set; }
    public string? Availability { get; set; }
}
