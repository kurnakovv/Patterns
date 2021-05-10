using Observer.YouTubeObserver.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.YouTubeObserver.ConcreteObservables
{
    public class Author : IAuthor
    {
        private readonly List<ISubscriber> _subscribers = new List<ISubscriber>();

        public string Name { get; private set; }
        public Author(string name)
        {
            Name = name;
        }

        public string AddSubscriber(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);

            return $"{Name}, {subscriber.Name} subscribed to you.";
        }

        public string NotifySubscriber()
        {
            string subscriberList = string.Empty;

            foreach (ISubscriber subscriber in _subscribers)
                subscriberList += $"{subscriber.Update(Name)}\n";

            return subscriberList;
        }

        public string RemoveSubscriber(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);

            return $"{Name}, {subscriber.Name} unsubscribed from you.";
        }
    }
}
