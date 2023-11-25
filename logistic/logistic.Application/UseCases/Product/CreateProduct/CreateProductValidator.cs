using FluentValidation;
public class CreateProductValidator : AbstractValidator<CreateProductRequest>
{
    public CreateProductValidator()
    {
        RuleFor(x => x.ProductName).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.ProductPrice).NotNull().GreaterThan(0);
        RuleFor(x => x.Quantity).NotNull().GreaterThan(0);
    }
}