using Decorator.Components.Abstract;
using Decorator.Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Decorator.Decorator
{
    public class LibraryCacheDecorator : ILibraryDecorator
    {
        public LibraryCacheDecorator(
            ILibrary library)
        {
            Library = library;
        }

        public ILibrary Library { get; private set; }

        public string Add(string book)
        {
            Library.Add(book);
            var cacheBook = CacheBook(book);

            return cacheBook;
        }

        public string Delete(string book)
        {
            Library.Delete(book);
            var cacheBook = CacheBook(book);

            return cacheBook;
        }

        public IEnumerable<string> GetAll()
        {
            var books = Library.GetAll();
            ICollection<string> cacheBooks = new List<string>();

            foreach(var book in books)
            {
                cacheBooks.Add(CacheBook(book));
            }

            return cacheBooks;
        }

        public string Sell(string book)
        {
            Library.Sell(book);
            var cacheBook = CacheBook(book);

            return cacheBook;
        }

        private string CacheBook(string book)
        {
            // There should be real caching logic.

            var rnd = new Random();

            string cache = new string(book.ToCharArray().
                OrderBy(b => (rnd.Next(2) % 2) == 0).ToArray());

            cache += cache;

            return cache;
        }
    }
}
