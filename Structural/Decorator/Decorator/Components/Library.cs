using Decorator.Components.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Decorator.Components
{
    public class Library : ILibrary
    {
        private readonly ICollection<string> _books = new List<string>();
        public string Add(string book)
        {
            _books.Add(book);

            return book;
        }

        public string Delete(string book)
        {
            _books.Remove(book);

            return book;
        }

        public IEnumerable<string> GetAll()
        {
            var books = _books.ToList();

            return books;
        }

        public string Sell(string book)
        {
            Delete(book);

            return book;
        }
    }
}
