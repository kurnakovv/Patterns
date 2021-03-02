using Memento.Memento;
using System;
using System.Collections.Generic;

namespace Memento.Originator
{
    public class Order
    {
        public Order(Basket basket)
        {
            _basket = basket;
        }

        private DateTime _dateOfCreate;
        private Basket _basket;

        public OrderMemento MakeOrder()
        {
            _dateOfCreate = DateTime.Now;
            Console.WriteLine($"Order made {_dateOfCreate}"); // Can be replaced with an event.
            return new OrderMemento(_dateOfCreate, _basket);
        }

        public void RestoreOrder(OrderMemento orderMemento)
        {
            _dateOfCreate = orderMemento.DateOfCreate;
            _basket = orderMemento.Basket;
        }

        public void SetBasket(Basket basket)
        {
            _basket = basket;
        }

        public IEnumerable<string> GetCheckWithItems()
        {
            return _basket.GetAll();
        }
    }
}
