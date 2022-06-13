using System.ComponentModel.DataAnnotations;

namespace OnlineBookShopWeb.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int? Year { get; set; }
        public string Image { get; set; }
        public decimal? Price { get; set; }
        [Required]
        public int? AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
