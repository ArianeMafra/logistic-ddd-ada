using FluentValidation;
public sealed class CreateAddressValidator : AbstractValidator<CreateAddressRequest>
{
    public CreateAddressValidator()
    {
        RuleFor(x => x.Street).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.Number).NotEmpty().GreaterThan(0);
        RuleFor(x => x.Neighborhood).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.ZipCode).NotEmpty().Length(8).Matches("^[0-9]+$").WithMessage("O CEP deve conter apenas dígitos e ter exatamente 8 caracteres.");
        RuleFor(x => x.AddressLine2).MaximumLength(50);
        RuleFor(x => x.City).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.State).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.Country).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.Region).NotEmpty().IsInEnum().WithMessage("A região especificada não é válida.");
    }
}