using MediatR;
public sealed record CreateDeliveryRequest (Address Address, Recipient Recipient, List<Product> Products)
    : IRequest<CreateDeliveryResponse>;