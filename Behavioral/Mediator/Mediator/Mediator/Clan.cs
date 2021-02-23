using Mediator.Colleague.Abstract;
using Mediator.Mediator.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Mediator.Mediator
{
    public class Clan : IClan
    {
        public Clan(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
        private readonly ICollection<IUser> _users = new List<IUser>();

        public string AddUser(IUser user)
        {
            _users.Add(user);
            return $"Added new user: {user.Name} in {Name}";
        }

        public string KickUser(IUser user, ILeader leader)
        {
            _users.Remove(user);

            return $"{leader.Name} kicked user: {user.Name} from {Name}";
        }

        public IEnumerable<string> SendLetter<T>(string message, T sender) where T : ILeader
        {
            ICollection<string> messages = new List<string>();

            foreach (IUser user in _users)
            {
                messages.Add(user.GetMessage($"{message} from {sender.Name}"));
            }

            return messages.ToList();
        }

        public IEnumerable<string> SendMessage(string message, IUser sender)
        {
            ICollection<string> messages = new List<string>();

            foreach (IUser user in _users)
            {
                if (user != sender)
                {
                    messages.Add(user.GetMessage($"{message} from {sender.Name}"));
                }
            }

            return messages;
        }
    }
}
