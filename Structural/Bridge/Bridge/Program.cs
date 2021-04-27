using System;
using Bridge.Abstractions;
using Bridge.Implementors;
using Bridge.Implementors.Abstract;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplication application = new AdminApplication(new LinuxAPI());
            application.ShowCats();
            application.ShowCatByName("Barsic");

            Console.WriteLine();

            application = new AdminApplication(new MacOSAPI());
            application.ShowCats();
            application.ShowCatByName("Mursic");
            
            Console.WriteLine();

            application = new UserApplication(new WindowsAPI());
            application.ShowCats();
            application.ShowCatByName("Mursic");

            Console.ReadLine();
        }
    }
}
