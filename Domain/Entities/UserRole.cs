namespace Domain.Entities;

public class UserRole : Entity
{
    public UserRole(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

    public UserRole()
    {

    }

    public string Name { get; set; }
    public List<User> User { get; set; }
}
