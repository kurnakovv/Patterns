using System.Collections.Generic;
using System.Linq;

namespace Memento.Originator
{
    public class Basket
    {
        private readonly ICollection<string> _basketItems = new List<string>();

        public IEnumerable<string> GetAll()
        {
            return _basketItems.ToList();
        }

        public void Add(string item)
        {
            _basketItems.Add(item);
        }

        public void Delete(string item)
        {
            _basketItems.Remove(item);
        }
    }
}
