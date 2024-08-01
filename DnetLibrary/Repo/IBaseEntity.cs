namespace DnetLibrary.Repo;

// All domain types that persist through the repo class implement this
public interface IBaseEntity
{
    Guid Id { get; }
}