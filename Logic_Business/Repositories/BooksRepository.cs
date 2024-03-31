using BookStore.Data;
using BookStore.Logic_Business.Interfaces;
using BookStore.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Logic_Business.Repositories
{
    public class BooksRepository : IBooks
    {

        private readonly StoreContext _context;
        public BooksRepository(StoreContext context)
        {
            _context= context;
        }

        public async Task<Book> AddBook(Book book)
        {
            var NewBook = new Book
            {
                Title = book.Title,
                Author = book.Author,
                Genre = book.Genre,
                Price = book.Price,
                Avalibality = book.Avalibality,
                DateAded = book.DateAded
            };
            _context.Books.Add(NewBook);
            await _context.SaveChangesAsync();
            return NewBook;
        }

        public async Task<Book> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return null;
            }
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public Task<Book> GetBook(int id)
        {
            var book = _context.Books.First(x => x.Id == id);
            return Task.FromResult(book);
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            List<Book> books = await _context.Books.ToListAsync();
            return books;
        }

        public async  Task<Book?> SearchBook(string result)
        {
           var book = await _context.Books.FirstOrDefaultAsync(x => x.Title == result || x.Author == result || x.Genre == result);
            if (book is null)
            {
                return null;
            }
            return book;

        }

        public async Task<Book?> UpdateBook(int id)
        {
            var result = _context.Books.First(x => x.Id == id);
            if (result is null)
            {
                return null;
            }
              



            await _context.SaveChangesAsync();
            return result;

        }
    }
}
