using Iterator.Collections.Abstract;
using Iterator.Iterators.Abstract;
using Iterator.Models;
using System.Collections.Generic;
using System.Linq;

namespace Iterator.Iterators
{
    public class CommitIterator : ICommitIterator
    {
        private IDefaultCollection _defaultCollection;
        private int _position = 0;
        public CommitIterator(IDefaultCollection defaultCollection)
        {
            _defaultCollection = defaultCollection;
            _position = _defaultCollection.GetLog().Count;
        }

        public void SetPosition(int position)
        {
            _position = position;
        }

        public Commit Current()
        {
            return _defaultCollection.GetLog()[_position];
        }

        public Commit First()
        {
            return _defaultCollection.GetLog().First();
        }

        public Commit Last()
        {
            return _defaultCollection.GetLog().Last();
        }

        public Commit Next()
        {
            if(_position != _defaultCollection.GetLog().Count)
            {
                return _defaultCollection.GetLog()[_position + 1];
            }

            return null;
        }

        public Commit Previous()
        {
            if (_position != 0)
            {
                return _defaultCollection.GetLog()[_position - 1];
            }

            return null;
        }

        public List<Commit> GetCommits()
        {
            return _defaultCollection.GetLog();
        }

        public List<Commit> GetLatest()
        {
            return _defaultCollection.GetLatest();
        }
    }
}
