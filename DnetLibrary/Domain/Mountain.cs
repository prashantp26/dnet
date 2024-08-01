using DnetLibrary.Repo;
namespace DnetLibrary.Domain;

public record Mountain : EntityBase
{
    public override Guid Id { get; } = Guid.NewGuid();
}