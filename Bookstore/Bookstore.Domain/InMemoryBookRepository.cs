using Bookstore.Models;
using System.Collections.Generic;
using System.Linq;


namespace Bookstore.Domain
{
    public class InMemoryBookRepository : InMemoryBookRepositoryBase
    {
        private readonly List<Book> _books;

        public InMemoryBookRepository()
        {
            _books = new List<Book>();
        }

        public Book GetBookById(int id) => _books.FirstOrDefault(book => book.Id == id);

        public List<Book> GetAllBooks() => _books;

        public void UpdateBook(Book book)
        {
            var index = _books.FindIndex(b => b.Id == book.Id);
            if (index != -1)
            {
                _books[index] = book;
            }
        }
    }
}
