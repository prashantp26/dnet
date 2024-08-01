using DnetLibrary.Domain;

namespace DnetLibrary.Repo.EntityRepo

{
    public sealed class MountainRepo(IRepoContext<Mountain> context) : RepoBase<Mountain>(context)
    {
        private IRepoContext<Mountain> BaseContext => Context; //context inherited from RepoBase

        public async Task<IEnumerable<Mountain>> TallestPeak()
        {
            var allMountains = await BaseContext.GetAll();
            return allMountains.Where(mountain => mountain.ToString().Length > 5);
        }
    }
}
    
