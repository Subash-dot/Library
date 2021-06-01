using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositary
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string author, string title)
        {
            return DataSource().Where(x=>x.Author == author || x.Title == title).ToList();
        }

        public List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="Lord",Author="Baggins" },
                new BookModel(){Id=1,Title="Power of now",Author="idontno" },
                new BookModel(){Id=1,Title="gtav",Author="franklin" },
                new BookModel(){Id=1,Title="tervor industries",Author="trevor" },
                new BookModel(){Id=1,Title="loveyou",Author="akon" }
            };
        }
    }
}
