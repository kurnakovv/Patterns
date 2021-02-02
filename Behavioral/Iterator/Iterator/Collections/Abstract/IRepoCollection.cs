using Iterator.Iterators.Abstract;

namespace Iterator.Collections.Abstract
{
    public interface IRepoCollection
    {
        ICommitIterator CreateIterator();
        int CountCommits { get; }
    }
}
