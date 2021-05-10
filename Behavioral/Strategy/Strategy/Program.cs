using Strategy.Concrete;
using Strategy.Context;
using System;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Simple implementation
            //var navigator = new Navigator(new WalkingRoute());
            //Console.WriteLine(navigator.AssignRoute("a", "b"));
            //Console.WriteLine();

            //navigator = new Navigator(new BusRoute());
            //Console.WriteLine(navigator.AssignRoute("z", "f"));
            //Console.WriteLine();

            //navigator = new Navigator(new TaxiRoute());
            //Console.WriteLine(navigator.AssignRoute("a", "f"));
            //Console.WriteLine();

            //Console.ReadLine();
            #endregion

            #region UI implementation
            var navigator = new Navigator();
            var listOfTransports = new List<string> { "B - Bus", "T - Taxi", "W - Without transport" };
            var listOfPoints = new List<string> { "a", "z", "v", "f", "b" };
            var outputTransports = string.Empty;
            var outputPoints = string.Empty;

            foreach (var transport in listOfTransports)
            {
                outputTransports += $"{transport}\n";
            }
            Console.WriteLine(outputTransports);

            Console.Write("Select the mode of transport (symbol): ");
            var inputTransport = Console.ReadKey();
            Console.Clear();

            foreach (var point in listOfPoints)
            {
                outputPoints += $"{point}\n";
            }
            Console.WriteLine(outputPoints);
            Console.WriteLine("Specify points for building a route");

            Console.Write("Enter start point (symbol): ");
            string inputStartPoint = Console.ReadLine();

            Console.Write("Enter end point (symbol): ");
            string inputEndPoint = Console.ReadLine();

            switch (inputTransport.Key)
            {
                case ConsoleKey.B:
                    navigator = new Navigator(new BusRoute());
                    break;
                case ConsoleKey.T:
                    navigator = new Navigator(new TaxiRoute());
                    break;
                case ConsoleKey.W:
                    navigator = new Navigator(new WalkingRoute());
                    break;
            }

            Console.WriteLine(navigator.AssignRoute(inputStartPoint, inputEndPoint));

            Console.ReadLine();
            #endregion
        }
    }
}
