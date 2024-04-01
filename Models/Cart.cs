namespace BookStore.Models
{
    public class Cart 
    {
        public int CarrtId { get; set; }

        public string CartNumber { get; set; }

        public List<Book> Books { get; set; }

        public Cart()
        {
            Books = new List<Book>();
        }
        public decimal TotalPrice
        {
            get
            {
                decimal total = 0;
                foreach (var book in Books)
                {
                    total += book.Price;
                }
                return total;
            }
            set { }
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }
        public DateOnly DateCreated { get; set; }

        public DateOnly DateUpdated { get; set;}

        public DateOnly DateDeleted { get; set;}

        public bool IsDeleted { get; set; }


    }
}
