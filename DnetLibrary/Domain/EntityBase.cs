using DnetLibrary.Repo;

namespace DnetLibrary.Domain;

public abstract record EntityBase: IBaseEntity
{
    public virtual Guid Id { get; }
 
    public required string Name;
    public CommonTypes.Region Region;
}