using BookStore.API.Models;
using BookStore.API.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore.API.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        // GET: api/<BookController>
        [HttpGet("books")]
        public IEnumerable<Book> Get()
        {
            return _bookService.GetBooks();
        }

        // GET api/<BookController>/5
        [HttpGet("book/{id}")]
        public Book Get(int id)
        {
            return _bookService.GetBook(id);
        }

        // POST api/<BookController>
        [HttpPost("add")]
        public void Post([FromBody] Book book)
        {
            _bookService.AddBook(book);
        }

        // PUT api/<BookController>/5
        [HttpPut("update")]
        public void Put([FromBody] Book book)
        {
            _bookService.UpdateBook(book);
        }

        // DELETE api/<BookController>/5
        [HttpDelete("delete/{id}")]
        public Book Delete(int id)
        {
            return _bookService.DeleteBook(id);
        }
    }
}
