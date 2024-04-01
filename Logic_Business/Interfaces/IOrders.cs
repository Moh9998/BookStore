using BookStore.Models;

namespace BookStore.Logic_Business.Interfaces
{
    public interface IOrders
    {
        public Task<Orders> AddOrder(Orders order);
        public Task<Orders> GetOrder(int id);
        public Task<List<Orders>> GetOrders();
        public Task<Orders> UpdateOrder(Orders order);
        public Task<Orders> DeleteOrder(int id);
    }
}
