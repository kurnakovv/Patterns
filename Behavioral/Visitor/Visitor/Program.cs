using System;
using Visitor.BL;
using Visitor.Visitor;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = new City();
            var monument = new Monument()
            {
                Name = "monument named after Pushkin",
                DateOfCreate = DateTime.Now,
            };

            var restaurant = new Restaurant()
            {
                Title = "Povoreshkin",
                CountOfTables = 10,
            };

            var theatre = new Theatre()
            {
                Title = "Vakhtangov theater",
                CountOfAttractions = 5,
            };

            city.Add(monument);
            city.Add(restaurant);
            city.Add(theatre);

            Console.WriteLine("XML graphic:");
            Console.WriteLine();

            city.Accept(new XmlVisitor());

            Console.WriteLine("Html graphic:");
            Console.WriteLine();

            city.Accept(new HtmlVisitor());

            Console.ReadLine();
        }
    }
}
