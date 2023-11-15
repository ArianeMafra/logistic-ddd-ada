public interface IRecipientRepository : IBaseRepository<Recipient>
{
    Task<Recipient> GetByName(string name, CancellationToken cancellationToken);

    Task<Recipient> GetByCpf(string cpf, CancellationToken cancellationToken);
}