namespace DnetLibrary.Repo.EntityRepo;

public interface IRepoContext<TEntity>
{
    Task<IEnumerable<TEntity>> GetAll();
    Task<IEnumerable<TEntity>> GetById(Guid id); 
}