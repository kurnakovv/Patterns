namespace Observer.YouTubeObserver.Abstract
{
    public interface ISubscriber
    {
        string Name { get; }
        string Update(string authorName);
    }
}
