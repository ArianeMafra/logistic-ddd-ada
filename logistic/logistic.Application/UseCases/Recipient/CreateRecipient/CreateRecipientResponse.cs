public sealed record CreateRecipientResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Address Address { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}