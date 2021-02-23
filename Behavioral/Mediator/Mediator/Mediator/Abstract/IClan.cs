using Mediator.Colleague.Abstract;
using System.Collections.Generic;

namespace Mediator.Mediator.Abstract
{
    public interface IClan
    {
        string Name { get; }
        IEnumerable<string> SendMessage(string message, IUser sender);
        IEnumerable<string> SendLetter<T>(string message, T sender) where T : ILeader;
        string KickUser(IUser user, ILeader leader);
        string AddUser(IUser user);
    }
}
