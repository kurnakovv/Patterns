using System.Collections.Generic;

namespace Strategy.Abstract
{
    public interface ISearch
    {
        List<string> RouteSearch(List<string> listPoints);
    }
}
