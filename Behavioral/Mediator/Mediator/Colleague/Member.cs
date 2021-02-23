using Mediator.Colleague.Abstract;
using Mediator.Mediator.Abstract;
using System.Linq;

namespace Mediator.Colleague
{
    public class Member : IUser
    {
        public Member(string name)
        {
            Name = name;
        }

        public IClan Clan { get; }
        public string Name { get; private set; }

        public string GetMessage(string message)
        {
            return $"{this.Name} reseived message: {message}";
        }

        public string SendMessage(string message)
        {
            return Clan.SendMessage(message, this).ToList().ToString();
        }
    }
}
