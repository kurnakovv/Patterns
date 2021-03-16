using Decorator.Components.Abstract;
using Decorator.Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.IO;

namespace Decorator.Decorator
{
    public class LibraryLoggerDecorator : ILibraryDecorator
    {
        public LibraryLoggerDecorator(
            ILibrary library)
        {
            Library = library;
        }

        public ILibrary Library { get; private set; }
        private const string PATH_TO_FILE = "test.txt";
        private string LOG_MESSAGE = string.Empty;

        public string Add(string book)
        {
            Library.Add(book);
            var logMessage = $"Added book to library: {book}. Date: {DateTime.Now}\r\n";
            AddLogMessage(logMessage);

            return book;
        }

        public string Delete(string book)
        {
            Library.Delete(book);
            LOG_MESSAGE += $"Deleted book from library: {book}. Date: {DateTime.Now}\r\n";
            AddLogMessage(LOG_MESSAGE);

            return book;

        }

        public IEnumerable<string> GetAll()
        {
            var books = Library.GetAll();
            LOG_MESSAGE += $"Get all books form library. Date: {DateTime.Now}\r\n";
            AddLogMessage(LOG_MESSAGE);

            return books;
        }

        public string Sell(string book)
        {
            Library.Sell(book);
            LOG_MESSAGE += $"Selled a book: {book}. Date: {DateTime.Now}\r\n";
            AddLogMessage(LOG_MESSAGE);

            return book;
        }

        private void AddLogMessage(string message)
        {
            using(var sw = new StreamWriter(PATH_TO_FILE))
            {
                sw.WriteLine(message);
            }
        }
    }
}
