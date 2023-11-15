using System.Reflection.Metadata.Ecma335;

public sealed class Recipient : BaseEntity
{
    public string Name { get; set; }
    public Address Address { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

}
