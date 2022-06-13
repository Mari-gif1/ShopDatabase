using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }

        public Decimal Cost  { get; set; }

        public string PictureUrl { get; set; }

        public string Genre { get; set; }

        public string SellerName { get; set; }

        public int PublishYear { get; set; }

    }
}
