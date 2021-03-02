using Memento.Caretaker;
using Memento.Memento;
using Memento.Originator;
using System;
using System.Linq;
using System.Threading;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderStory orderStory = new OrderStory();

            Basket basket1 = new Basket();
            basket1.Add("Water");
            basket1.Add("Bread");
            basket1.Add("Milk");

            Order order = new Order(basket1);
            orderStory.PushOrder(order.MakeOrder());

            GetBasketItems(order);

            Thread.Sleep(1000);

            Basket basket2 = new Basket();
            basket2.Add("Juice");
            basket2.Add("Chicken");

            order.SetBasket(basket2);

            orderStory.PushOrder(order.MakeOrder());
            GetBasketItems(order);

            Console.WriteLine("Go back to first order...");
            orderStory.PopOrder();
            var orderMemento = orderStory.PopOrder();
            order.RestoreOrder(orderMemento);

            GetBasketItems(order);

            Console.ReadLine();
        }

        private static void GetBasketItems(Order order)
        {
            foreach (var item in order.GetCheckWithItems())
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}
