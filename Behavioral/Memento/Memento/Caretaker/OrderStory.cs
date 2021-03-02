using Memento.Memento;
using System.Collections.Generic;
using System.Linq;

namespace Memento.Caretaker
{
    public class OrderStory
    {
        public OrderStory()
        {
            Stories = new List<OrderMemento>();
        }

        public ICollection<OrderMemento> Stories { get; private set; }

        public void PushOrder(OrderMemento orderMemento)
        {
            Stories.Add(orderMemento);
        }

        public OrderMemento PopOrder()
        {
            var orderMemento = Stories.Last();
            Stories.Remove(orderMemento);
            return orderMemento;
        }
    }
}
