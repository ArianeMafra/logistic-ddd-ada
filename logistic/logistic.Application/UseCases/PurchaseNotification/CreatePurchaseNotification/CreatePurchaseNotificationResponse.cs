public sealed record CreatePurchaseNotificationResponse
{
    public Guid Id { get; set; }
    public Recipient Recipient { get; set; }
    public List<Product> Products { get; set; }
}