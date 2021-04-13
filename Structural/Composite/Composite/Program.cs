using Composite.Component;
using Composite.Composites.Developers;
using Composite.Composites.Translators;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IWriter writer = new CSDeveloper();
            writer.Write();

            writer = new JavaScriptDeveloper();
            writer.Write();

            writer = new PythonDeveloper();
            writer.Write();

            Console.WriteLine();

            var developersTeam = new DevelopersTeam();

            developersTeam.Add(new CSDeveloper());
            developersTeam.Add(new CSDeveloper());
            developersTeam.Add(new JavaScriptDeveloper());
            developersTeam.Add(new PythonDeveloper());

            writer = developersTeam;
            writer.Write();

            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.WriteLine();

            writer = new StateTranslator();
            writer.Write();

            writer = new TechicalTranslator();
            writer.Write();

            Console.WriteLine();

            var translatorsTeam = new TranslatorsTeam();

            translatorsTeam.Add(new TechicalTranslator());

            writer = translatorsTeam;

            writer.Write();

            Console.ReadLine();
        }
    }
}
