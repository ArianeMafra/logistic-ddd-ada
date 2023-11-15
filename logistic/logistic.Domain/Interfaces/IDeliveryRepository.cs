public interface IDeliveryRepository : IBaseRepository<Delivery>
{
    Task<Delivery> GetByStatus(Status status, CancellationToken cancellationToken);
    Task<Delivery> GetByRecipient(Recipient recipient, CancellationToken cancellationToken);
}