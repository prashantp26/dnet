using DnetLibrary.Domain;
using DnetLibrary.Repo.Data;

namespace DnetLibrary.Repo.EntityRepo;

public class MemoryDataContext<TEntity>(CommonTypes.EntityToken token) : IRepoContext<TEntity>
{
    private readonly MemoryDataService _dataService = new();
    private CommonTypes.EntityToken Token { get; } = token;

    public async Task<IEnumerable<TEntity>> GetAll()
    {
        var list = await _dataService.GetData(Token);
        return (IEnumerable<TEntity>)list;
    }

    public async Task<IEnumerable<TEntity>> GetById(Guid id)
    {
        var list = await _dataService.GetData(Token);
        return (IEnumerable<TEntity>)list.Where(place => place.Id == id);
    }
}