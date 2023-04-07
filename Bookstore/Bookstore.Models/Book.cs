using System;

//Contains classes representing the core entities of the bookstore (
//Book, Author, Customer, Order, etc.).
// ISP: Interface segregation principle
//clasele nu trebuie sa implementeze fortat interfete pe care nu le folosesc
namespace Bookstore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public decimal Price { get; set; }
    }
}
