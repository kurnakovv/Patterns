using Composite.Component;
using System;

namespace Composite.Composites.Developers
{
    public class PythonDeveloper : IWriter
    {
        public void Write()
        {
            Console.WriteLine("Python programmer writes code, while searching for invisible bugs...");
        }
    }
}
