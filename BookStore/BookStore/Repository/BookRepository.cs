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
                new BookModel(){Id=1,Title="Lord",Author="Baggins", Description="This is the Desctiption of Lord Book.",Category="Fantasty",TotalPages=200,Language="Bhojpuri" },
                new BookModel(){Id=2,Title="Power of now",Author="idontno", Description="This is the Desctiption of Power of now Book.",Category="Self help",TotalPages=38,Language="Nepali" },
                new BookModel(){Id=3,Title="gtav",Author="franklin",Description="This is the Desctiption of gta v Book.",Category="Game",TotalPages=500,Language="English" },
                new BookModel(){Id=4,Title="tervor industries",Author="trevor",Description="This is the Desctiption of Trevor Industries Book.",Category="Business",TotalPages=332,Language="japanese" },
                new BookModel(){Id=5,Title="loveyou",Author="akon",Description="This is the Desctiption of Love You Book.",Category="Love",TotalPages=987,Language="English" }
            };
        }
    }
}
