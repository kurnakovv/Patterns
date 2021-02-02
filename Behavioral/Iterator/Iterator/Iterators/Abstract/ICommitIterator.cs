using Iterator.Models;
using System.Collections.Generic;

namespace Iterator.Iterators.Abstract
{
    public interface ICommitIterator
    {
        Commit Next();
        Commit Previous();
        Commit Current();
        Commit First();
        Commit Last();
        List<Commit> GetCommits();
        List<Commit> GetLatest();
        void SetPosition(int position);
    }
}
