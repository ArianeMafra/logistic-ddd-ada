using AutoMapper;
public class CreateAddressMapper : Profile
{
    public CreateAddressMapper()
    {
        CreateMap<CreateAddressRequest, Address>();
        CreateMap<Address, CreateAddressResponse>();
    }
}