using System.Collections.Generic;

namespace Decorator.Components.Abstract
{
    public interface ILibrary
    {
        IEnumerable<string> GetAll();
        string Add(string book);
        string Delete(string book);
        string Sell(string book);
    }
}
