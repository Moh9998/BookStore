using BookStore.Logic_Business.Interfaces;
using BookStore.Logic_Business.Repositories;
using BookStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using System.Web.Http.ModelBinding;

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
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized("User is not authenticated");
            }

            // Your logic to get the book by id
            var book = await _books.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }


        [HttpPost]
        public async Task<Book> AddBook(Book book)
        {
            return await _books.AddBook(book);
        }
     
        [HttpPut("{id}")]
            public async Task<Book?> UpdateBook(int id, Book updatedBook)
        {
            return await _books.UpdateBook(id, updatedBook);
        }
        [Authorize]
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
        [HttpGet("filter")]
        public async Task<List<Book>> FilterBooks(string filter)
        {
            return await _books.FilterBooks(filter);
        }
    }
}
