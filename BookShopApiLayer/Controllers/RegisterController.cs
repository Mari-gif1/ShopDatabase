using AutoMapper;
using BookShopApiLayer.Models;
using DataAccessLayer.Data;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BookShopApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private IConfiguration _config;
        private readonly IMapper _mapper;
        private readonly IBookShopRepository _bookShopRep;
        public RegisterController(IConfiguration config, IMapper mapper, IBookShopRepository dataRepository)
        {
            _config = config;
            _mapper = mapper;
            _bookShopRep = dataRepository;
        }

        [HttpPost]
        public IActionResult Register([FromBody] UserModel user)
        {
             return Ok(_bookShopRep.AddUser(_mapper.Map<User>(user)));
        }
    }
}
