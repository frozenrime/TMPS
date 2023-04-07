using Bookstore.Models;

namespace Bookstore.Domain
{
    public class InMemoryBookRepositoryBase
    {
        private object _books;

        public void AddBook(Book book)
        {
            object p = _books.Add(book);

        }
    }
}