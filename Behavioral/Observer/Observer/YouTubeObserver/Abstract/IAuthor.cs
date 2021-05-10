namespace Observer.YouTubeObserver.Abstract
{
    public interface IAuthor
    {
        string Name { get; }
        string AddSubscriber(ISubscriber subscriber);
        string RemoveSubscriber(ISubscriber subscriber);
        string NotifySubscriber();
    }
}
