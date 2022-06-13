using DataAccessLayer.Data;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookShopApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        private readonly IBookShopRepository _bookShopRep;

        public BooksController(IBookShopRepository dataRepository)
        {
            _bookShopRep = dataRepository;
        }

        [HttpGet]
        public IEnumerable<Books> GetBooks()
        {
            return _bookShopRep.GetBooksWithPicturesAndSellers();
        }

        [HttpPost]
        public IActionResult Login([FromBody] Books userLogin)
        {
            return Ok(_bookShopRep.AddBook(userLogin));
        }
    }
}
