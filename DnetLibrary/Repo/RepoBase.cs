using DnetLibrary.Repo.EntityRepo;

namespace DnetLibrary.Repo;

// any new domain type inherits basic repo functionality from this class
public abstract class RepoBase<TEntity>(IRepoContext<TEntity> context):  IRepository<TEntity> where TEntity: IBaseEntity
{
    protected readonly IRepoContext<TEntity> Context = context;

    public Task<IEnumerable<TEntity>> GetAll()
    {
        return Context.GetAll();
    }

    public Task<IEnumerable<TEntity>> GetById(Guid id)
    {
        return Context.GetById(id);
    }
}