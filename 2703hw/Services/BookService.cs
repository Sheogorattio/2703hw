using _2703hw.Models;

namespace _2703hw.Services
{
    public class BookService
    {
        private List<Book> _books;
        public BookService()
        {
            _books = new List<Book>()
            {
                new Book() {Id=1, Title="Lord of the Flies", Author=" William Golding", Genre="Dystopian", Year=1954},
                new Book() {Id=2, Title="Blood Meridian", Author=" Cormac McCarthy", Genre="Western", Year=1985},
                new Book() {Id=3, Title="For Whom the Bell Tols", Author="Ernest Hemingway", Genre="War novel", Year=1940},

            };
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }
        public void AddBook(Book book)
        {
            _books.Add(book);
        }

    }
}
