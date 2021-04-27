using System;
using System.Threading;
using Bridge.Abstractions.Abstract;

namespace Bridge.Abstractions
{
    public class LinuxAPI : IAPIFramework
    {
        public void Request()
        {
            Console.WriteLine("Process the request using Linux...");
            Thread.Sleep(100);
        }
    }
}