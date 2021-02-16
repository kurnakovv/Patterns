using ChainOfResponsibility.DTO;
using ChainOfResponsibility.Handler;
using ChainOfResponsibility.Handler.Abstract;
using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            User sUser = new User("Vasia", "My screen doesn't work");
            User simpleUser = new User("Peter", "My computer is not responding to any actions");
            User advancedUser = new User("Kolya", "My computer is flickering");
            User somedUser = new User("Marina", "My computer burned out");

            ITechicalSupportHandler answeringMachine = new AnsweringMachine();
            ITechicalSupportHandler operatorr = new Operator();
            ITechicalSupportHandler admin = new Admin();

            #region S user (AnsweringMachine)
            ITechicalSupportHandler techicalSupportHandler = answeringMachine;
            Console.WriteLine(techicalSupportHandler.HandleRequest(sUser));
            #endregion

            #region Simple user (Operator)
            techicalSupportHandler.Successor = answeringMachine;
            techicalSupportHandler.Successor = operatorr;
            Console.WriteLine(techicalSupportHandler.HandleRequest(simpleUser));
            #endregion

            #region Advance user
            techicalSupportHandler.Successor = answeringMachine;
            techicalSupportHandler.Successor = operatorr;
            techicalSupportHandler.Successor = admin;
            Console.WriteLine(techicalSupportHandler.HandleRequest(advancedUser));
            #endregion

            #region Advance user (from AnsweringMachine to Admin)
            techicalSupportHandler.Successor = answeringMachine;
            techicalSupportHandler.Successor = admin;
            Console.WriteLine(techicalSupportHandler.HandleRequest(advancedUser));
            #endregion

            #region Some user (Dont gotten request)
            techicalSupportHandler.Successor = answeringMachine;
            techicalSupportHandler.Successor = operatorr;
            techicalSupportHandler.Successor = admin;
            Console.WriteLine(techicalSupportHandler.HandleRequest(somedUser));
            #endregion

            Console.ReadLine();
        }
    }
}
