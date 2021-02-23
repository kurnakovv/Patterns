using Mediator.Colleague.Abstract;
using Mediator.Mediator.Abstract;

namespace Mediator.Colleague
{
    public class Coleader : ILeader
    {
        public Coleader(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        public IClan Clan { get; }

        public string AddUser(IUser user)
        {
            string addUserMessage = Clan.AddUser(user);

            return addUserMessage;
        }

        public string GetMessage(string message)
        {
            return $"{this.Name} reseived message: {message}";
        }

        public string KickUser(IUser user, ILeader leader)
        {
            string removeUserMessage = Clan.KickUser(user, leader);

            return removeUserMessage;
        }

        public string SendMessage(string message)
        {
            return Clan.SendMessage(message, this).ToString();
        }
    }
}
