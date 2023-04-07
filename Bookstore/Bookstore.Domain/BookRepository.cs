using Bookstore.Models;
using System;
using System.Collections.Generic;

namespace Bookstore.Domain
{
    //This class will represent a book entity in
    //the system and will contain the core business
    //logic of the bookstore.
   
        public interface IBookRepository
        {
            Book GetBookById(int id);
            List<Book> GetAllBooks();
            void AddBook(Book book);
            void UpdateBook(Book book);
            void DeleteBook(int id);
        void AddBook(Book book);
    }
}
