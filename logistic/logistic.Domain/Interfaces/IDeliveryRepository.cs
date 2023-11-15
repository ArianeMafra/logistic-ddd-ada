public interface IDeliveryRepository : IBaseRepository<Delivery>
{
    public Task<List<Delivery>> GetByStatus(Status status, CancellationToken cancellationToken);
    public Task<List<Delivery>> GetByRecipient(Recipient recipient, CancellationToken cancellationToken);
}