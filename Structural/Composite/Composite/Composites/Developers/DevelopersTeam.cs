using Composite.Component;
using System.Collections.Generic;

namespace Composite.Composites.Developers
{
    public class DevelopersTeam : IWriter
    {
        public DevelopersTeam()
        {
            _developers = new List<IWriter>();
        }

        private readonly ICollection<IWriter> _developers;

        public void Add(IWriter developer)
        {
            _developers.Add(developer);
        }

        public void Delete(IWriter developer)
        {
            _developers.Remove(developer);
        }

        public void Write()
        {
            foreach (IWriter developer in _developers)
            {
                developer.Write();
            }
        }
    }
}
