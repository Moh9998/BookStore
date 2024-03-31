using BookStore.Logic_Business.Interfaces;
using BookStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/Books")]
    [ApiController]
    public class Books : ControllerBase
    {
        private readonly IBooks _books;

        public Books(IBooks books)
        {
            _books = books;
        }

        [HttpGet]
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _books.GetBooks();
        }

        [HttpGet("{id}")]
        public async Task<Book> GetBook(int id)
        {
            return await _books.GetBook(id);
        }

        [HttpPost]
        public async Task<Book> AddBook(Book book)
        {
            return await _books.AddBook(book);
        }

        [HttpPut("{id}")]
        public async Task<Book?> UpdateBook(int  id)
        {
            var book = await _books.UpdateBook(id);
            if (book == null)
            {
                return null;
            }
            return book;
        }

        [HttpDelete("{id}")]
        public async Task<Book> DeleteBook(int id)
        {
            return await _books.DeleteBook(id);
        }

        [HttpGet("search")]
        public async Task<Book?> SearchBook(string title)
        {
            return await _books.SearchBook(title);
            
        }   
    }
}
