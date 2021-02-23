using Mediator.Colleague;
using Mediator.Colleague.Abstract;
using Mediator.Mediator;
using Mediator.Mediator.Abstract;
using System;
using System.Collections.Generic;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            IClan clan = new Clan("SuperClan");
            IUser member = new Member("Maksim");
            ILeader coleader = new Coleader("Peter");
            ILeader leader = new Leader("Ivan");

            Console.WriteLine(clan.AddUser(member));
            Console.WriteLine(clan.AddUser(coleader));
            Console.WriteLine(clan.AddUser(leader));
            Console.WriteLine();

            var letters1 = clan.SendLetter("He there, I am your leader!", leader);
            PrintMessages(letters1, ConsoleColor.Red);

            var letters2 = clan.SendLetter("He there, I am your co-leader!", coleader);
            PrintMessages(letters2, ConsoleColor.Green);

            var messages1 = clan.SendMessage("Hi, I am Maksim, what's up?", member);
            PrintMessages(messages1, ConsoleColor.White);

            var messages2 = clan.SendMessage("Hi, I am Peter, what's up?", coleader);
            PrintMessages(messages2, ConsoleColor.White);

            Console.WriteLine(clan.KickUser(member, coleader));
            Console.WriteLine(clan.KickUser(coleader, leader));

            Console.ReadLine();
        }

        private static void PrintMessages(IEnumerable<string> messages,
                                   ConsoleColor messageColor)
        {
            Console.ForegroundColor = messageColor;
            foreach (string item in messages)
            {
                Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
