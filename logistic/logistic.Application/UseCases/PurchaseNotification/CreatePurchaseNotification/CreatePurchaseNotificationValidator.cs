using FluentValidation;
public sealed class CreatePurchaseNotificationValidator : AbstractValidator<CreatePurchaseNotificationRequest>
{
    public CreatePurchaseNotificationValidator()
    {
        RuleFor(x => x.Recipient).NotEmpty();
        RuleFor(x => x.Products).NotEmpty();
    }
}