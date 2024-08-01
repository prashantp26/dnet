using DnetLibrary.Repo;

namespace DnetLibrary.Domain;

public record Temple : EntityBase
{
    public override Guid Id { get; } = Guid.NewGuid();
}