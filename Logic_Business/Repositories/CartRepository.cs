using BookStore.Logic_Business.Interfaces;
using BookStore.Models;

namespace BookStore.Logic_Business.Repositories
{
    public class CartRepository : ICart
    {
        public decimal TotalPrice
        {
            get => 
            
            set => throw new NotImplementedException();
        }

        public void AddBook(Book book)
        {
            
        }

        public void RemoveBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
