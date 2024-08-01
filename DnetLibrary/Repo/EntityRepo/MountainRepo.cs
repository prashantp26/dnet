using DnetLibrary.Domain;

namespace DnetLibrary.Repo.EntityRepo

{
    public class MountainRepo(IRepoContext<Mountain> context) : RepoBase<Mountain>(context)
    {
        public IRepoContext<Mountain> BaseContext => Context; //context inherited from RepoBase

        public Task<IEnumerable<Mountain>> TallestPeak()
        {
            return Task.FromResult(Enumerable.Empty<Mountain>());
        }
    }
}
    
