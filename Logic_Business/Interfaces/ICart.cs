using BookStore.Models;

namespace BookStore.Logic_Business.Interfaces
{
    public interface ICart
    {
        Task<Cart> GetCartByIdAsync(int cartId);

        Task<Cart> CreateCartAsync();

        Task AddBookToCartAsync(int cartId, Book book);

        Task RemoveBookFromCartAsync(int cartId, Book book);

        Task DeleteCartAsync(int cartId);

        Task ClearCartAsync(int cartId);

    
    }
}
