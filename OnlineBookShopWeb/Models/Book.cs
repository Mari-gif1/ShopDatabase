using System.ComponentModel.DataAnnotations;

namespace OnlineBookShopWeb.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Image { get; set; }
        public decimal Cost { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
    }
}