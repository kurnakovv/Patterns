using Composite.Component;
using System;

namespace Composite.Composites.Developers
{
    public class JavaScriptDeveloper : IWriter
    {
        public void Write()
        {
            Console.WriteLine("JS programmer writes code that no one knows how it works...");
        }
    }
}
