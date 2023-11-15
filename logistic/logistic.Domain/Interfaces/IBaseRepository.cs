public interface IBaseRepository<T> where T : BaseEntity
{
    public void Create(T entity);
    public void Update(T entity);
    public void Delete(T entity);

    public Task<T> Get(Guid id, CancellationToken cancellationToken);
    public Task<T> GetAll(Guid id, CancellationToken cancellationToken);

}
