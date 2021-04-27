using System;
using System.Threading;
using Bridge.Abstractions.Abstract;

namespace Bridge.Abstractions
{
    public class WindowsAPI : IAPIFramework
    {
        public void Request()
        {
            Console.WriteLine("Process the request using Windows OS...");
            Thread.Sleep(750);
        }
    }
}