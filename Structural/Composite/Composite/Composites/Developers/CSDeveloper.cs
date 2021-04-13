using Composite.Component;
using System;

namespace Composite.Composites.Developers
{
    public class CSDeveloper : IWriter
    {
        public void Write()
        {
            Console.WriteLine("C# programmer write the code using strange syntactic sugar...");
        }
    }
}
