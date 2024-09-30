namespace Application.Services.Repositories;

public interface IEntityTimestamps
{
    DateTime CreatedDate { get; set; }
    DateTime? DeletedDate { get; set; }
    DateTime? UpdatedDate { get; set; }
}
