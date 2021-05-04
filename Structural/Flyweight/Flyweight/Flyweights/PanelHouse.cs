using Flyweight.Flyweights.Abstract;
using System;

namespace Flyweight.Flyweights
{
    public class PanelHouse : IHouseFlyweight
    {
        public void Build(double longitude, double latitude, int floors)
        {
            Console.WriteLine($"Built a panel house:\n\tLongitude - {longitude}\n\tLatitude - {latitude}\n\tFloors - {floors}");
        }
    }
}
