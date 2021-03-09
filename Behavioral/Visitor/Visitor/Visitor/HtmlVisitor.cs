using System;
using Visitor.BL;
using Visitor.Visitor.Abstract;

namespace Visitor.Visitor
{
    public class HtmlVisitor : ICityVisitor
    {
        public void VisitMonument(Monument monument)
        {
            //string result = $"<html>\n\t<body>\n\t\t<p>{monument.Name}</p>\n\t\t<p>{monument.DateOfCreate}</p>\n\t</body>\n</html>";
            string result = $"<html>\n <body>\n  <p>{monument.Name}</p>\n  <p>{monument.DateOfCreate}</p>\n </body>\n</html>\n";
            Console.WriteLine(result);
        }

        public void VisitRestaurant(Restaurant restaurant)
        {
            //string result = $"<html>\n\t<body>\n\t\t<p>{restaurant.Title}</p>\n\t\t<p>{restaurant.CountOfTables}</p>\n\t</body>\n</html>";
            string result = $"<html>\n <body>\n  <p>{restaurant.Title}</p>\n  <p>{restaurant.CountOfTables}</p>\n </body>\n</html>\n";
            Console.WriteLine(result);
        }

        public void VisitTheatre(Theatre theatre)
        {
            //string result = $"<html>\n\t<body>\n\t\t<p>{theatre.Title}</p>\n\t\t<p>{theatre.CountOfAttractions}</p>\n\t</body>\n</html>";
            string result = $"<html>\n <body>\n  <p>{theatre.Title}</p>\n  <p>{theatre.CountOfAttractions}</p>\n </body>\n</html>\n";
            Console.WriteLine(result);
        }
    }
}
