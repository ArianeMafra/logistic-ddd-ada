using AutoMapper;
public class CreateRecipientMapper : Profile
{
    public CreateRecipientMapper()
    {
        CreateMap<CreateRecipientRequest, Recipient>();
        CreateMap<Recipient, CreateRecipientResponse>();
    }
}