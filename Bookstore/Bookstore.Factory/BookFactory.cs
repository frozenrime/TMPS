using Bookstore.Models;
using System;

//Contains factory classes to create instances of the core entities.

namespace Bookstore.Factory
{
    public static class BookFactory
    {
        public static Book Create(int id, string title, Author author, decimal price)
        {
            return new Book { Id = id, Title = title, Author = author, Price = price };
        }
    }
}
