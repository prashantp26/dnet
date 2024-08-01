using DnetLibrary.Domain;

namespace DnetLibrary.Repo.EntityRepo;

public sealed class TempleRepo(IRepoContext<Temple> context) : RepoBase<Temple>(context)
{
    private IRepoContext<Temple> BaseContext => Context;

    public async Task<IEnumerable<Temple>> ShortestTemple()
    {
        var allTemples = await BaseContext.GetAll();
        return allTemples.Where(temple => temple.ToString().Length < 4);
    }
}