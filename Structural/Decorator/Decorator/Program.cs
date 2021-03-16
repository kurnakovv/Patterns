using Decorator.Components;
using Decorator.Components.Abstract;
using Decorator.Decorator;
using System;
using System.Collections.Generic;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ILibrary library = new Library();

            library.Add("Code complete");
            library.Add("Pro Git");
            GetAllBooks(library.GetAll());

            // Now action will be recorded in a file.
            library = new LibraryLoggerDecorator(library);
            
            library.Sell("Pro Git");
            library.Add("Clean code");
            GetAllBooks(library.GetAll());

            library = new LibraryCacheDecorator(library);
            Console.WriteLine(library.Delete("Clean code"));

            ILibrary libraryCache = new Library();
            libraryCache = new LibraryCacheDecorator(libraryCache);
            Console.WriteLine(libraryCache.Add("TestBook"));

            Console.ReadLine();
        }

        private static void GetAllBooks(IEnumerable<string> books)
        {
            foreach(string book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
