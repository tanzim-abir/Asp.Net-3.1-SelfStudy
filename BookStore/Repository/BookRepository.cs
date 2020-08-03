using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace BookStore
{
    public class BookRepository
    {
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public List<BookModel> SearchBook(string bookName, string bookAuthor)
        {
            return DataSource().Where(x => x.Title.Contains(bookName) || x.Author.Contains(bookAuthor)).ToList();
        }

        public List<BookModel> DataSource()
        {
            return new List<BookModel>
            {
                new BookModel(){Id = 1, Title = "C#", Author = "microsoft"},
                new BookModel(){Id = 2, Title = "Java", Author = "oracle"},
                new BookModel(){Id = 3, Title = "Kotlin", Author = "google"},
                new BookModel(){Id = 4, Title = "golang", Author = "google"}
            };
        }
    }
}
