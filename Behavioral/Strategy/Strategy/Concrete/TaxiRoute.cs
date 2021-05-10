using Strategy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy.Concrete
{
    public class TaxiRoute : ISearch
    {
        public List<string> RouteSearch(List<string> listPoints)
        {
            var list = listPoints.OrderBy(a => Guid.NewGuid()).ToList();
            list.Remove(list.First());
            return list;
        }
    }
}
