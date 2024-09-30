namespace Domain.Entities;

public class Project : Entity
{
    public Project(Guid id,
        string name, string description, DateTime startDate, DateTime? dueDate,
        int? maxVolunteers)
    {
        Id = id;
        Name = name;
        Description = description;
        StartDate = startDate;
        DueDate = dueDate;
        MaxVolunteers = maxVolunteers;
    }

    public Project()
    {

    }

    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? DueDate { get; set; }
    public int? MaxVolunteers { get; set; }
    public List<Volunteer> Volunteers { get; set; }
    public List<Beneficiary> Beneficiaries { get; set; }
    public List<Participation> Participations { get; set; }
}
