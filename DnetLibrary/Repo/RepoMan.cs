using DnetLibrary.Domain;
using DnetLibrary.Repo.EntityRepo;

namespace DnetLibrary.Repo;

public class RepoMan
{
 public MountainRepo Mountains { get; } = new (new ContextLoader<Mountain>(CommonTypes.EntityToken.Mountains).CurrentContext);
 public TempleRepo Temples { get; } = new (new ContextLoader<Temple>(CommonTypes.EntityToken.Temples).CurrentContext);
 
 private class ContextLoader<TEntity>(CommonTypes.EntityToken token) where TEntity : IBaseEntity
 {
  public readonly IRepoContext<TEntity> CurrentContext = new MemoryDataContext<TEntity>(token);
 }
 
}
