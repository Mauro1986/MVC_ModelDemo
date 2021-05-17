using Microsoft.AspNetCore.Mvc;
using MVC_ModelDemo.Models;
using MVC_ModelDemo.Repository;
using MVC_ModelDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_ModelDemo.Controllers
{
    public class BookController : Controller
    {

        //private readonly BookRepo _bookrepository = null;
        BookRepo _bookrepository = new BookRepo();
        public IActionResult Index()
        {
            Book book = new Book();
            book.Id = 1;
            book.Title = "Mvc Core";
            book.Autor = "Murach";
            book.YearPublished = 2020;
            book.Pages = 380;

            Author author = new Author();
            author.Id = 22;
            author.FirstName = "Tony";
            author.LastName = "Montana";

            AuthorBook authorbook = new AuthorBook();
            authorbook.Book = book;
            authorbook.Author = author;

            //ViewBag.Book = book;
            return View(authorbook);
        }

        public IActionResult GetAllBooks()
        {
           var books= _bookrepository.GetAllBooks();
            return View(books);
        }
    }
}
