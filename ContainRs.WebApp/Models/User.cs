namespace ContainRs.WebApp.Models;

public class User
{
    public User(string name, string email, string cPF)
    {
        Name = name;
        Email = email;
        CPF = cPF;
    }

    public Guid Id { get; set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string CPF { get; private set; }
    public string? PhoneNumber { get; set; }
    public string? CEP { get; set; }
    public string? Street { get; set; }
    public string? HouseNumber { get; set; }
    public string? AddressComplement { get; set; }
    public string? Neighborhood { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
}
