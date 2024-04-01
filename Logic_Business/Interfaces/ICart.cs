using BookStore.Models;

namespace BookStore.Logic_Business.Interfaces
{
    public interface ICart
    {
        public decimal TotalPrice { get; set; }
        public void AddBook(Book book);
        public void RemoveBook(Book book);
    }
}
