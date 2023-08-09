using API_CRUD.Data;
using API_CRUD.Models;

namespace API_CRUD.Service
{
    public class BookService : IBookService
    {
        private readonly IMockDbContext? _dbContext;

        public BookService(IMockDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddBook(Book book)
        {
            book.Id = _dbContext.Books.Count + 1;
            _dbContext.Books.Add(book);
        }



        public async Task<Book> GetBookById(int id)
        {
            Book book = _dbContext.Books.FirstOrDefault(b=> b.Id == id);
            return book;
        }
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return _dbContext.Books;
        }

        public async Task UpdateBook(int id, Book book)
        {
            Book findBook = _dbContext.Books.FirstOrDefault(b => b.Id == id);

            if (findBook != null)
            {
                findBook.Name = book.Name;
                findBook.Author = book.Author;
            }

        }

        public async Task DeleteBook(int id)
        {
            Book book = _dbContext.Books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                _dbContext.Books.Remove(book);
            }


        }
    }
}
