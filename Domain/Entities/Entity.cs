using Application.Services.Repositories.IEntityTimeStamps;
namespace Domain.Entities;

public abstract class Entity : IEntityTimeStamps
{
    protected Entity(Guid id)
    {
        Id = id;
    }

    protected Entity()
    {
        Id = default;
    }

    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
