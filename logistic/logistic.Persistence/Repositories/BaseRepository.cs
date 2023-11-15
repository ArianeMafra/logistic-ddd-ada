using Microsoft.EntityFrameworkCore;
public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    protected readonly AppDbContext _context;
    public BaseRepository(AppDbContext context)
    {
        _context = context;

    }

    public void Create(T entity)
    {
        entity.DateCreated = DateTime.Now;
        _context.Add(entity);
    }

    public void Delete(T entity)
    {
        entity.DateDeleted = DateTime.Now;
        _context.Remove(entity);
    }

    public async Task<T> Get(Guid id, CancellationToken cancellationToken)
    {
        return await _context.Set<T>().FirstOrDefaultAsync(x=>x.Id.Equals(id), cancellationToken);
    }

    public async Task<List<T>> GetAll(Guid id, CancellationToken cancellationToken)
    {
        return await _context.Set<T>().ToListAsync(cancellationToken);
    }

    public void Update(T entity)
    {
        entity.DateUpdated = DateTime.Now;
        _context.Update(entity);
    }
}