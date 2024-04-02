using BookStore.Logic_Business.Interfaces;
using BookStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cart : ControllerBase
    {
        private readonly ICart _cart;
        public Cart( ICart cart)
        {
            _cart = cart;
        }

        [HttpGet("{cartId}")]
        public async Task<IActionResult> GetCart(int cartId)
        {
            var cart = await _cart.GetCartByIdAsync(cartId);
            if (cart == null)
            {
                return NotFound("Cart not found");
            }

            return Ok(cart);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCart()
        {
            var cart = await _cart.CreateCartAsync();
            return Ok(cart);
        }
        [HttpPost("{cartId}")]
        public async Task<IActionResult> AddBookToCart(int cartId, [FromBody] Book book)
        {
            await _cart.AddBookToCartAsync(cartId, book);

            return Ok("Book added to cart");
        }
        [HttpDelete("{cartId}/remove")]
        public async Task<IActionResult> RemoveBookFromCart(int cartId, [FromBody] Book book)
        {
            await _cart.RemoveBookFromCartAsync(cartId, book);
            return Ok("Book removed from cart");
        }

      
      



    }
}
