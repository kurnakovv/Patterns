using Composite.Component;
using System;

namespace Composite.Composites.Translators
{
    public class TechicalTranslator : IWriter
    {
        public void Write()
        {
            Console.WriteLine("Technical translator translate smart text...");
        }
    }
}
