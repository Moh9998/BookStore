using BookStore.Logic_Business.Interfaces;
using BookStore.Models;

namespace BookStore.Logic_Business.Repositories
{
    public class OrdersRepository : IOrders
    {
        public Task<Orders> AddOrder(Orders order)
        {
            throw new NotImplementedException();
        }

        public Task<Orders> DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Orders> GetOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Orders>> GetOrders()
        {
            throw new NotImplementedException();
        }

        public Task<Orders> UpdateOrder(Orders order)
        {
            throw new NotImplementedException();
        }
    }
}
