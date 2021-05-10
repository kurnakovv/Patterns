using Observer.YouTubeObserver.Abstract;

namespace Observer.YouTubeObserver.ConcreteObservers
{
    public class Subscriber : ISubscriber
    {
        public string Name { get; private set; }

        public Subscriber(string name)
        {
            Name = name;
        }

        public string Update(string authorName)
        {
            return $"{Name}, {authorName} posted a new video!";
        }
    }
}
