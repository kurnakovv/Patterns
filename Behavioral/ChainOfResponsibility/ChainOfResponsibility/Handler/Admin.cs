using ChainOfResponsibility.DTO;
using ChainOfResponsibility.Handler.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Handler
{
    public class Admin : ITechicalSupportHandler
    {
        public ITechicalSupportHandler Successor { get; set; }

        public string HandleRequest(User user)
        {
            var questionsList = new List<string>()
            {
                "My computer is flickering",
            };

            string response = "Admin answered: ";

            if (questionsList.Contains(user.Question))
            {
                response += "maybe your drivers do not work, reinstall them.";
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
