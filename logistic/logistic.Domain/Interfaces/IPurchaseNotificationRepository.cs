public interface IPurchaseNotificationRepository : IBaseRepository<PurchaseNotification>
{
    public Task<List<PurchaseNotification>> GetByRecipient(Recipient recipient, CancellationToken cancellationToken);
}