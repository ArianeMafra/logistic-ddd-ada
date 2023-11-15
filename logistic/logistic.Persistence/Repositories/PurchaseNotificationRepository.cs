using Microsoft.EntityFrameworkCore;

public class PurchaseNotificationRepository : BaseRepository<PurchaseNotification>, IPurchaseNotificationRepository
{
    public PurchaseNotificationRepository(AppDbContext context) : base(context)
    {

    }

    public async Task<List<PurchaseNotification>> GetByRecipient(Recipient recipient, CancellationToken cancellationToken)
    {
        return await _context.PurchaseNotifications.Where(x => x.Recipient.Id.Equals(recipient.Id)).ToListAsync(cancellationToken);
    }
}