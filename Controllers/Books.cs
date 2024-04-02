using BookStore.Logic_Business.Interfaces;
using BookStore.Logic_Business.Repositories;
using BookStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CSharp;
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
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized("User is not authenticated");
            }

            var book = await _books.GetBook(id);
            if (book == null)
            {
                return NotFound("Book not found");
            }

            return Ok(book);
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Book>> AddBook(Book book)
        {
            var addedBook = await _books.AddBook(book);
            if (addedBook == null)
            {
                return BadRequest("Failed to add book");
            }

            return Ok("Book added successfully");
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<ActionResult<Book>> UpdateBook(int id, Book updatedBook)
        {
            var result = await _books.UpdateBook(id, updatedBook);
            if (result == null)
            {
                return NotFound("Book not found");
            }

            return Ok("Book updated successfully");
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Book>> DeleteBook(int id)
        {
            var deletedBook = await _books.DeleteBook(id);
            if (deletedBook == null)
            {
                return NotFound("Book not found");
            }

            return Ok("Book deleted successfully");
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
