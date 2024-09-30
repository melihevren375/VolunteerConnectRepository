namespace Domain.Entities;

public class Participation : Entity
{
    public Participation(Guid id,
       Guid volunteerId, Guid projectId, Guid beneficiaryId)
    {
        Id = id;
        VolunteerId = volunteerId;
        ProjectId = projectId;
        BeneficiaryId = beneficiaryId;
    }

    public Participation()
    {

    }

    public Guid VolunteerId { get; set; }
    public Guid ProjectId { get; set; }
    public Guid BeneficiaryId { get; set; }
    public Volunteer Volunteer { get; set; }
    public Project Project { get; set; }
    public Beneficiary Beneficiary { get; set; }
}
