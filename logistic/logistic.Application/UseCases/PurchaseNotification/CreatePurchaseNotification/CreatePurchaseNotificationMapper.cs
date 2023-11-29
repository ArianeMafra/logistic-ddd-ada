using AutoMapper;
public class CreatePurchaseNotificationMapper : Profile
{
    public CreatePurchaseNotificationMapper()
    {
        CreateMap<CreatePurchaseNotificationRequest, PurchaseNotification>();
        CreateMap<PurchaseNotification, CreatePurchaseNotificationResponse>();
    }
}