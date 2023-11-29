using AutoMapper;
public class CreateDeliveryMapper : Profile
{
    public CreateDeliveryMapper()
    {
        CreateMap<CreateDeliveryRequest, Delivery>();
        CreateMap<Delivery, CreateDeliveryResponse>();
    }
}