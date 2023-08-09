using API_CRUD.Models;

namespace API_CRUD.Service
{
    public interface IBookService
    {
        Task AddBook(Book book);
        Task<Book> GetBookById(int id);
        Task<IEnumerable<Book>> GetAllBooks();
        Task UpdateBook(int id, Book book);
        Task DeleteBook(int id);
    }
}
