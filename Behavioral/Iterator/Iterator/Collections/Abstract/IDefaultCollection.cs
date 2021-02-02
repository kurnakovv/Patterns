using Iterator.Models;
using System.Collections.Generic;

namespace Iterator.Collections.Abstract
{
    public interface IDefaultCollection : IRepoCollection
    {
        string AddCommit(Commit commit);
        List<Commit> GetLog();
        List<Commit> GetLatest();
    }
}
