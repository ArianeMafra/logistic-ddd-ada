public interface IRecipientRepository : IBaseRepository<Recipient>
{
    public Task<Recipient> GetByName(string name, CancellationToken cancellationToken);

    public Task<Recipient> GetByCpf(string cpf, CancellationToken cancellationToken);
}