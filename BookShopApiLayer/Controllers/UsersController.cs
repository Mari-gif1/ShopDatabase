using DataAccessLayer.Data;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookShopApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IBookShopRepository _bookShopRep;

        public UsersController(IBookShopRepository dataRepository)
        {
            _bookShopRep = dataRepository;
        }

        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return _bookShopRep.GetUsers();
        }

        [HttpGet("{id:int}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = _bookShopRep.GetUser(id);
            if (user is null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public ActionResult PostUser([FromBody] User user)
        {
            user.Id = _bookShopRep.AddUser(user);

            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user.Id);
        }

        [HttpPut("{id:int}")]
        public ActionResult UpdateUser(int id, User user)
        {
            user.Id = id;
            _bookShopRep.UpdateUser(user);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public ActionResult DeleteUser(int id)
        {
            _bookShopRep.DeleteUser(id);

            return NoContent();
        }
    }
}
