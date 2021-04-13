using Composite.Component;
using System.Collections.Generic;

namespace Composite.Composites.Translators
{
    public class TranslatorsTeam : IWriter
    {
        public TranslatorsTeam()
        {
            _translators = new List<IWriter>();
        }

        private readonly ICollection<IWriter> _translators;

        public void Add(IWriter translator)
        {
            _translators.Add(translator);
        }

        public void Delete(IWriter translator)
        {
            _translators.Remove(translator);
        }

        public void Write()
        {
            foreach (IWriter translator in _translators)
            {
                translator.Write();
            }
        }
    }
}
