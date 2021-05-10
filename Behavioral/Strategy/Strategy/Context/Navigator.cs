using Strategy.Abstract;
using System.Collections.Generic;

namespace Strategy.Context
{
    public class Navigator
    {
        public ISearch Search { private get; set; }

        public Navigator()
        {

        }
        public Navigator(ISearch search)
        {
            Search = search;
        }

        public string AssignRoute(string startPoint, string endPoint)
        {
            List<string> listPoints = new List<string> { "a", "z", "v", "f", "b", };
            listPoints.Remove(startPoint);
            listPoints.Remove(endPoint);

            string route = $"Ideal route: {startPoint} --> ";

            List<string> result = Search.RouteSearch(listPoints);

            foreach (string point in result)
            {
                route += $"{point} --> ";
            }

            route += endPoint;

            return route;
        }
    }
}
