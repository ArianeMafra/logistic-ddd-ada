public interface IPurchaseNotificationRepository : IBaseRepository<PurchaseNotification>
{
    Task<PurchaseNotification> GetByRecipient(Recipient recipient, CancellationToken cancellationToken);
}