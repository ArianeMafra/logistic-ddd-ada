public class PurchaseNotification : BaseEntity
{
    public Recipient Recipient { get; set; }
    public List<Product> Products { get; set; }
}