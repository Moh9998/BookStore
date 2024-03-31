using BookStore.Models;

namespace BookStore.Logic_Business.Interfaces
{
    public interface IBooks
    {
        public Task<IEnumerable<Book>> GetBooks();

        public Task<Book> GetBook(int id);

        public Task<Book> AddBook(Book book);

        public Task<Book?> UpdateBook(int id, Book updatedBook);

        public Task<Book> DeleteBook(int id);

        public Task<Book?> SearchBook(string result);

        public Task<List<Book>> FilterBooks(string filter);
    }
}
