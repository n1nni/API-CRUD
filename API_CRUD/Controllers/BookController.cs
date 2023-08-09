using API_CRUD.Data;
using API_CRUD.Models;
using API_CRUD.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpPost("CreateBook")]
        public async Task<IActionResult> CreateBook(BookDBO book)
        {
            try
            {
                Book newBook = new Book
                {
                    Name = book.Name,
                    Author = book.Author
                };
                await _bookService.AddBook(newBook);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        [HttpGet("GetBook/{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            Book book = await _bookService.GetBookById(id);
            if (book != null)
            {
                return Ok(book);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("GetAllBooks")]
        public async Task<IActionResult> GetAllBooks()
        {
            var allBooks =await _bookService.GetAllBooks();
            if (allBooks != null)
            {
                return Ok(allBooks);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpPut("UpdateBook/{id}")]
        public async Task<IActionResult> UpdateBook(int id, BookDBO book)
        {
            try
            {
                Book newBook = new Book
                {
                    Name = book.Name,
                    Author = book.Author
                };
                await _bookService.UpdateBook(id, newBook);
                return Ok(book);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("DeleteBook/{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            try
            {
                await _bookService.DeleteBook(id);
                return NoContent();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
