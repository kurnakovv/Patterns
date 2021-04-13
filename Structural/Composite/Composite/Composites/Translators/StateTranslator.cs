using Composite.Component;
using System;

namespace Composite.Composites.Translators
{
    public class StateTranslator : IWriter
    {
        public void Write()
        {
            Console.WriteLine("State translator translates the official text...");
        }
    }
}
