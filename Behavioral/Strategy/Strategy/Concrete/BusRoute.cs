using Strategy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy.Concrete
{
    public class BusRoute : ISearch
    {
        public List<string> RouteSearch(List<string> listPoints)
        {
            var rnd = new Random();
            int n = listPoints.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                string value = listPoints[k];
                listPoints[k] = listPoints[n];
                listPoints[n] = value;
            }
            listPoints.Remove(listPoints.Last());

            return listPoints;
        }
    }
}
