using MediatR;
public sealed record CreateRecipientRequest(string Name, Address Address, string Cpf, string Email, string PhoneNumber)
    : IRequest<CreateRecipientResponse>;