using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {   
        //Primary Key
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int BooksInStock { get; set; }

        public bool Avalibality { get; set; }

        public DateTime DateAded { get; set;}= DateTime.Now;


    }
}
