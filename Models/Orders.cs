namespace BookStore.Models
{
    public class Orders 
    {
        public int Id { get; set; }

        public string OrderNumber { get; set; }

        public string OrderStatus { get; set; }

        public string CustomerId { get; set; }
        = string.Empty;

        public string CustomerName { get; set; } = string.Empty;

        public string CustomerEmail { get; set; } = string.Empty;

        public string paymentMethod { get; set; } 



    }
}
