using DnetLibrary.Domain;

namespace DnetLibrary.Repo.EntityRepo;

public class MemoryDataContext<TEntity>: IRepoContext<TEntity>
{
    public MemoryDataContext(CommonTypes.EntityToken token)
    {
    }

    public Task<IEnumerable<TEntity>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TEntity>> GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}