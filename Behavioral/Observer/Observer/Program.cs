using Observer.YouTubeObserver.Abstract;
using Observer.YouTubeObserver.ConcreteObservables;
using Observer.YouTubeObserver.ConcreteObservers;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            IAuthor sergeyNemchinskiyAuthor = new Author("Sergey Nemchinskiy");
            ISubscriber maksimSubscriber = new Subscriber("Maksim");
            ISubscriber vasaSubscriber = new Subscriber("Vasya");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(sergeyNemchinskiyAuthor.AddSubscriber(maksimSubscriber));
            Console.WriteLine(sergeyNemchinskiyAuthor.AddSubscriber(vasaSubscriber));
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(sergeyNemchinskiyAuthor.NotifySubscriber());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(sergeyNemchinskiyAuthor.RemoveSubscriber(vasaSubscriber));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(sergeyNemchinskiyAuthor.NotifySubscriber());

            Console.ReadLine();
        }
    }
}
