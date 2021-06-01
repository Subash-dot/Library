using BookStore.Models;
using BookStore.Repositary;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {

        private readonly BookRepository _bookrepository = null;

        public ViewResult Index()
        {
            return View();
        }

        public BookController()
        {
            _bookrepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            List<BookModel> data = _bookrepository.GetAllBooks();
            return View();
        }

        public BookModel GetBookById(int id)
        {
            return _bookrepository.GetBookById(id);
        }

        public List<BookModel> SearchBook(string title, string author)
        {
            return _bookrepository.SearchBook(title, author);
        }
    }
}
