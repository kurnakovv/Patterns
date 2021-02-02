using Iterator.Collections.Abstract;
using Iterator.Iterators;
using Iterator.Iterators.Abstract;
using Iterator.Models;
using System.Collections.Generic;

namespace Iterator.Collections
{
    class DefaultRepoCollection : IDefaultCollection
    {
        private readonly List<Commit> _commits = new List<Commit>();
        public int CountCommits { get; private set; }

        public string AddCommit(Commit commit)
        {
            _commits.Add(commit);
            return $"Added commit {commit.Hash}";
        }

        public ICommitIterator CreateIterator()
        {
            return new CommitIterator(this);
        }

        public List<Commit> GetLatest()
        {
            List<Commit> list = new List<Commit>();
            int counter = 0;

            foreach (var item in _commits)
            {
                if (counter != 2)
                {
                    list.Add(item);
                    counter++;
                }
            }

            return list;
        }

        public List<Commit> GetLog()
        {
            return _commits;
        }
    }
}
