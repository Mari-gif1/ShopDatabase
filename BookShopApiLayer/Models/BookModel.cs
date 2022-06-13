using System;

namespace BookShopApiLayer.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }

        public Decimal Cost { get; set; }

        public string PictureUrl { get; set; }

        public string Genre { get; set; }

        public string SellerName { get; set; }

        public int PublishYear { get; set; }
        public string ImageUrl { get; set; }
    }
}
