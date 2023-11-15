using Microsoft.EntityFrameworkCore;

public class RecipientRepository : BaseRepository<Recipient>, IRecipientRepository
{
    public RecipientRepository(AppDbContext context) : base(context)
    {

    }

    public async Task<Recipient> GetByCpf(string cpf, CancellationToken cancellationToken)
    {
        return await _context.Recipients.FirstOrDefaultAsync(x => x.Cpf.Equals(cpf), cancellationToken);
    }

    public async Task<Recipient> GetByName(string name, CancellationToken cancellationToken)
    {
        return await _context.Recipients.FirstOrDefaultAsync(x => x.Name.Equals(name), cancellationToken);
    }
}