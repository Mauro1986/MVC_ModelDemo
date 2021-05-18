using MVC_ModelDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_ModelDemo.Repository
{
    public class BookRepo
    {
        public List<Book> GetAllBooks()
        {

            return FakeDatabase();
        }

        public Book GetDetail(int id)
        {
            return FakeDatabase().Find(book => book.Id.Equals(id));
        }

        public Book EditBook(int id)
        { 
           
        return FakeDatabase().Find(book => book.Id.Equals(id));
        }
        public Book UpdateBook(Book newbook)
        {
            var oldBook = FakeDatabase().FirstOrDefault(b => b.Id.Equals(newbook.Id));
            FakeDatabase().Remove(oldBook);
            FakeDatabase().Add(newbook);
            return newbook;
        }
        private List<Book> FakeDatabase()
        {
            return new List<Book>()
            {
                new Book() { Id = 10, Title = "MVC Core", Autor = "Mauro", YearPublished = 2020, Pages = 333 },
                new Book() { Id = 11, Title = "abc Core", Autor = "Jeff", YearPublished = 2020, Pages = 322 },
                new Book() { Id = 12, Title = "def Core", Autor = "Louis", YearPublished = 2020, Pages = 344 },
                new Book() { Id = 13, Title = "ghi Core", Autor = "Fernand", YearPublished = 2020, Pages = 355 },
                new Book() { Id = 14, Title = "jkl Core", Autor = "Jean-marie", YearPublished = 2020, Pages = 336 },

            };
        }
    }
}
