using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookShopWeb.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string Firstname { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string Lastname { get; set; }

        public virtual IList<Book> Books { get; set; }
    }
}
