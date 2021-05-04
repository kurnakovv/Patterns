using Flyweight.Flyweights.Abstract;
using System;

namespace Flyweight.Flyweights
{
    public class BrickHouse : IHouseFlyweight
    {
        public void Build(double longitude, double latitude, int floors)
        {
            Console.WriteLine($"Built a brick house:\n\tLongitude - {longitude}\n\tLatitude - {latitude}\n\tFloors - {floors}");
        }
    }
}
