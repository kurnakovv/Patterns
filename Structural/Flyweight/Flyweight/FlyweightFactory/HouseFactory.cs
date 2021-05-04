using Flyweight.Flyweights;
using Flyweight.Flyweights.Abstract;
using System;
using System.Collections.Generic;

namespace Flyweight.FlyweightFactory
{
    public class HouseFactory
    {
        private readonly Dictionary<string, IHouseFlyweight> _houses 
            = new Dictionary<string, IHouseFlyweight>();

        public IHouseFlyweight GetHouseByType(string type)
        {
            IHouseFlyweight house = _houses.GetValueOrDefault(type);

            if (house == null)
            {
                switch (type)
                {
                    case "Brick":
                        Console.WriteLine("Add brick house...");
                        house = new BrickHouse();
                        break;
                    case "Panel":
                        Console.WriteLine("Add panel house...");
                        house = new PanelHouse();
                        break;
                }

                _houses.Add(type, house);
            }

            return house;
        }
    }
}
