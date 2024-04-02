using BookStore.Data;
using BookStore.Logic_Business.Interfaces;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Logic_Business.Repositories
{
    public class CartRepository : ICart
    {
        

        private readonly StoreContext _dbContext;

        public CartRepository(StoreContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Cart?> GetCartByIdAsync(int cartId)
        {
            return await _dbContext.Carts
                .Include(c => c.Books)
                .FirstOrDefaultAsync(c => c.CartId == cartId);
        }

        public async Task AddBookToCartAsync(int cartId, Book book)
        {
            var cart = await GetCartByIdAsync(cartId);
            if (cart != null)
            {
                // Reduce the number of books in stock
                book.BooksInStock--;
                if (book.BooksInStock == 0)
                {
                    book.Avalibality = false;
                }

                // Add the book to the cart
                cart.Books.Add(book);

                // Update the total price of the cart based on the prices of all books in the cart
                cart.TotalPrice = cart.Books.Sum(b => b.Price);

                // Update the date
                cart.DateUpdated = DateTime.Now;

                // Detach the book from the context
                _dbContext.Entry(book).State = EntityState.Detached;

                // Save changes to the database
                await _dbContext.SaveChangesAsync();
            }
        }



        public async Task RemoveBookFromCartAsync(int cartId, Book book)
        {
            var cart = await _dbContext.Carts.Include(c => c.Books).FirstOrDefaultAsync(c => c.CartId == cartId);
            if (cart != null)
            {
                var bookToRemove = cart.Books.FirstOrDefault(b => b.Id == book.Id);
                if (bookToRemove != null)
                {   
                    bookToRemove.BooksInStock++;

                    cart.Books.Remove(bookToRemove);
                    cart.DateUpdated = DateTime.Now;
                    await _dbContext.SaveChangesAsync();
                }
            }
        }




        public Task<Cart> CreateCartAsync()
        {
            var cart = new Cart
            {
                CartNumber = Guid.NewGuid().ToString(),
                DateCreated = DateTime.Now
            };

            _dbContext.Carts.Add(cart);
            _dbContext.SaveChanges();
            return Task.FromResult(cart);
        }

        public async Task DeleteCartAsync(int cartId)
        {
            var cart = await _dbContext.Carts.FindAsync(cartId);

            if (cart != null)
            {
                if (cart.Books != null)
                {
                    _dbContext.Books.RemoveRange(cart.Books); // Delete associated books
                }
                _dbContext.Carts.Remove(cart); // Delete the cart
                await _dbContext.SaveChangesAsync();
            }
        }





        public async Task ClearCartAsync(int cartId)
        {
            var cart = await _dbContext.Carts.FindAsync(cartId);

            if (cart != null && cart.Books is not null)
            {
                
                    _dbContext.Books.RemoveRange(cart.Books); // Delete associated books
                
                cart.DateUpdated = DateTime.Now;
                await _dbContext.SaveChangesAsync();
            }
        }

    }
}
