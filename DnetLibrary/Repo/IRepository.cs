namespace DnetLibrary.Repo;

public interface IRepository<TEntity> where TEntity : IBaseEntity
{
    Task<IEnumerable<TEntity>> GetAll();
    Task<IEnumerable<TEntity>> GetById(Guid id);
}