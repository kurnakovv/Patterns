using System;
using System.Threading;
using Bridge.Abstractions.Abstract;
using Bridge.Implementors.Abstract;

namespace Bridge.Implementors
{
    public class AdminApplication : IApplication
    {
        private readonly IAPIFramework _apiFramework;
        public AdminApplication(
            IAPIFramework apiFramework)
        {
            _apiFramework = apiFramework;
        }

        public void ShowCatByName(string name)
        {
            _apiFramework.Request();

            Console.WriteLine($"Show cat by name: {name} with all statistics...");
        }

        public void ShowCats()
        {
            _apiFramework.Request();

            Console.WriteLine("Show cats with all statistics...");
        }
    }
}