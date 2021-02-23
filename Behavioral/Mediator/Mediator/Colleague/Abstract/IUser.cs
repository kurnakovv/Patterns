using Mediator.Mediator.Abstract;

namespace Mediator.Colleague.Abstract
{
    public interface IUser
    {
        string Name { get; }
        IClan Clan { get; }
        string SendMessage(string message);
        string GetMessage(string message);
    }
}
