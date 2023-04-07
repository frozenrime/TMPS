using Bookstore.Domain;
using Bookstore.Factory;
using Bookstore.Models;
using System;
using System.Collections.Generic;


//Contains classes that interact with the user and use the other modules.
namespace Bookstore.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author { Id = 1, Name = "John Doe" };
            Book book = BookFactory.Create(1, "Example Book", author, 9.99M);

           

            Console.WriteLine("Books in the bookstore:");
            foreach (var b in GetAllBooks())
            {
                Console.WriteLine($"{b.Title} by {b.Author.Name} - ${b.Price}");
            }
        }

    }
}
