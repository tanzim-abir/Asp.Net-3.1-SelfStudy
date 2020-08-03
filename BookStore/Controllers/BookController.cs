using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View();
        }
        public BookModel GetBookById(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBook(string bookName, string bookAuthor)
        {
            return _bookRepository.SearchBook(bookName, bookAuthor);
        }

    }
}
