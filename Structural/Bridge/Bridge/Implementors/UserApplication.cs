using System;
using Bridge.Abstractions.Abstract;
using Bridge.Implementors.Abstract;

namespace Bridge.Implementors
{
    public class UserApplication : IApplication
    {
        private readonly IAPIFramework _apiFramework;

        public UserApplication(
            IAPIFramework apiFramework)
        {
            _apiFramework = apiFramework;
        }

        public void ShowCatByName(string name)
        {
            _apiFramework.Request();
            
            Console.WriteLine($"Show cat image by name: {name}...");
        }

        public void ShowCats()
        {
            _apiFramework.Request();
            
            Console.WriteLine("Show name and image cats...");
        }
    }
}