namespace Domain.Entities;

public class Beneficiary : User
{
    public Beneficiary(Guid id, string? address, string? needs, string firstName, string lastName,
        DateTime dateOfBirth, string? email, Guid userRoleId, string? description,
        string phoneNumber)
    {
        Address = address;
        Needs = needs;
        Id = id;
        Email = email;
        UserRoleId = userRoleId;
        Description = description;
        PhoneNumber = phoneNumber;
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }

    public Beneficiary()
    {

    }

    public string? Address { get; set; }
    public string? Needs { get; set; }
}
