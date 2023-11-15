using Microsoft.EntityFrameworkCore;

public class DeliveryRepository : BaseRepository<Delivery>, IDeliveryRepository
{
    public DeliveryRepository(AppDbContext context) : base(context)
    {

    }

    public async Task<List<Delivery>> GetByRecipient(Recipient recipient, CancellationToken cancellationToken)
    {
        return await _context.Deliveries.Where(x => x.Recipient.Id.Equals(recipient.Id)).ToListAsync(cancellationToken);
    }


    public async Task<List<Delivery>> GetByStatus(Status status, CancellationToken cancellationToken)
    {
        return await _context.Deliveries.Where(x => x.Status.Equals(status)).ToListAsync(cancellationToken);
    }
}