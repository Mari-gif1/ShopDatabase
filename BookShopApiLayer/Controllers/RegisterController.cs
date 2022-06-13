using BookShopApiLayer.Models;
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
        public RegisterController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost]
        public IActionResult Register([FromBody] UserModel userLogin)
        {
            UserConstants.users.Add(userLogin);
            return Ok();
        }
    }
}
