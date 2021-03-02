using Memento.Originator;
using System;

namespace Memento.Memento
{
    public class OrderMemento
    {
        public DateTime DateOfCreate { get; private set; }
        public Basket Basket { get; private set; }
        public OrderMemento(DateTime dateOfCreate, Basket basket)
        {
            DateOfCreate = dateOfCreate;
            Basket = basket;
        }
    }
}
