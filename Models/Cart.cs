namespace BookStore.Models
{
    public class Cart 
    {
        
            public int CartId { get; set; }

            public string CartNumber { get; set; }

            public List<Book> Books { get; set; }

            public decimal TotalPrice { get; set; }

            public DateTime DateCreated { get; set; }

            public DateTime? DateUpdated { get; set; }

            public DateTime? DateDeleted { get; set; }

            public bool IsDeleted { get; set; }
        



    }
}
