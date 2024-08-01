namespace DnetLibrary.Repo;

// any new domain type inherits basic repo functionality from this class
public abstract class RepoBase<TEntity>:  IRepository<TEntity> where TEntity: IBaseEntity

{
    public Task<IEnumerable<TEntity>> GetAll()
    {
        return Task.FromResult(Enumerable.Empty<TEntity>());
    }

    public Task<IEnumerable<TEntity>> GetById(Guid id)
    {
        return Task.FromResult(Enumerable.Empty<TEntity>());
    }
}