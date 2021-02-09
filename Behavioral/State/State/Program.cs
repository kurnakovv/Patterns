using State.Context;
using State.State;
using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Article firstArticle = new Article(new DraftState());
            firstArticle.Text = "My first article.";
            RedMessage(firstArticle.Render());
            Console.WriteLine(firstArticle.GetState());

            GreenMessage(firstArticle.Publish());
            Console.WriteLine(firstArticle.GetState());

            GreenMessage(firstArticle.Publish());
            Console.WriteLine(firstArticle.GetState());

            GreenMessage(firstArticle.Publish());
            Console.WriteLine(firstArticle.GetState());

            GreenMessage(firstArticle.Publish());
            Console.WriteLine(firstArticle.GetState());

            Console.WriteLine("\n=========================================\n");

            Article lastArticle = new Article(new ContentState());
            lastArticle.Text = "My last article.";
            
            Console.WriteLine(lastArticle.GetState());

            RedMessage(lastArticle.Render());
            Console.WriteLine(lastArticle.GetState());

            Console.ReadLine();
        }

        private static void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
