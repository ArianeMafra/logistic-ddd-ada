using MediatR;
public sealed record CreatePurchaseNotificationRequest(Recipient Recipient, List<Product> Products)
    : IRequest<CreatePurchaseNotificationResponse>;