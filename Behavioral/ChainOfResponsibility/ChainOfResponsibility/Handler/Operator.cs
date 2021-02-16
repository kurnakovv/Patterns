using ChainOfResponsibility.DTO;
using ChainOfResponsibility.Handler.Abstract;
using System.Collections.Generic;

namespace ChainOfResponsibility.Handler
{
    public class Operator : ITechicalSupportHandler
    {
        public ITechicalSupportHandler Successor { get; set; }

        public string HandleRequest(User user)
        {
            var questionsList = new List<string>()
            {
                "My computer is not responding to any actions",
            };

            string response = "Operator answered: ";

            if (questionsList.Contains(user.Question))
            {
                response += "restart your computer.";
                return response;
            }
            else if (Successor != null)
            {
                return Successor.HandleRequest(user);
            }

            return "no answer, sorry.";
        }
    }
}
