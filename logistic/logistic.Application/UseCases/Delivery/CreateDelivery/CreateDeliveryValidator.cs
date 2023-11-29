using FluentValidation;
public sealed class CreateDeliveryValidator : AbstractValidator<CreateDeliveryRequest>
{
    public CreateDeliveryValidator()
    {
        RuleFor(x => x.Address).NotEmpty();
        RuleFor(x => x.Recipient).NotEmpty();
        RuleFor(x => x.Products).NotEmpty();

    }
}