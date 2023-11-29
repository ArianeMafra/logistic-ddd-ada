using FluentValidation;
public sealed class CreateRecipientValidator : AbstractValidator<CreateRecipientRequest>
{
    public CreateRecipientValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.Address).NotEmpty();
        RuleFor(x => x.Cpf).NotEmpty().Length(11).Matches("^[0-9]+$").WithMessage("O CPF deve conter apenas dígitos e ter exatamente 11 caracteres.");
        RuleFor(x => x.Email).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.PhoneNumber).NotEmpty().Matches("^[0-9]+$").WithMessage("O Numerode telefone deve conter apenas dígitos.");

    }
}