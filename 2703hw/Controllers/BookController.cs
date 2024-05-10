using _2703hw.Models;
using _2703hw.Services;
using _2703hw.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Text;

namespace _2703hw.Controllers
{
    public class BookController : Controller
    {
        private readonly BookService _bookService;
        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            var books = _bookService.GetAllBooks();
            return View(books);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(BookViewModel model)
        {
            if(ModelState.IsValid)
            {
                var book = new Book
                {
                    Title = model.Title,
                    Author = model.Author,
                    Genre = model.Genre,
                    Year = model.Year
                };
                _bookService.AddBook(book);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

    }
}
