using System;
using Visitor.BL;
using Visitor.Visitor.Abstract;

namespace Visitor.Visitor
{
    public class XmlVisitor : ICityVisitor
    {
        public void VisitMonument(Monument monument)
        {
            string result = $"<Monument>\n <Name>{monument.Name}</Name>\n <DateOfCreate>{monument.DateOfCreate}</DateOfCreate>\n</Monument>\n";
            Console.WriteLine(result);
        }

        public void VisitRestaurant(Restaurant restaurant)
        {
            string result = $"<Restaurant>\n <Title>{restaurant.Title}</Title>\n <CountOfTables>{restaurant.CountOfTables}</CountOfTables>\n</Restaurant>\n";
            Console.WriteLine(result);
        }

        public void VisitTheatre(Theatre theatre)
        {
            string result = $"<Theatre>\n <Title>{theatre.Title}</Title>\n <CountOfAttractions>{theatre.CountOfAttractions}</CountOfAttractions>\n</Theatre>\n";
            Console.WriteLine(result);
        }
    }
}
