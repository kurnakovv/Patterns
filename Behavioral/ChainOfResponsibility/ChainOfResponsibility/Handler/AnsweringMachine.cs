using ChainOfResponsibility.DTO;
using ChainOfResponsibility.Handler.Abstract;
using System.Collections.Generic;

namespace ChainOfResponsibility.Handler
{
    public class AnsweringMachine : ITechicalSupportHandler
    {
        public ITechicalSupportHandler Successor { get; set; }

        public string HandleRequest(User user)
        {
            var questionsList = new List<string>() 
            { 
                "My screen doesn't work", 
                "My computer is frozen", 
            };

            string response = "Bot answered: ";

            if(questionsList.Contains(user.Question))
            {
                response += "shake the mouse.";
                return response;
            }
            else if(Successor != null)
            {
                return Successor.HandleRequest(user);
            }

            return "no answer, sorry.";
        }
    }
}
