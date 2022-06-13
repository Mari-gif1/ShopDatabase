using AutoMapper;
using BookShopApiLayer.Models;
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
        private readonly IMapper _mapper;
        public BooksController(IBookShopRepository dataRepository, IMapper mapper)
        {
            _bookShopRep = dataRepository;
            _mapper = mapper;
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

        [HttpGet("{id:int}")]
        public BookModel GetBook([FromBody] int id)
        {
            var user = _bookShopRep.GetUser(id);
            if (user is null)
            {
                return null;
            }

            return _mapper.Map<BookModel>(_bookShopRep.GetBook(id));
        }
    }
}
