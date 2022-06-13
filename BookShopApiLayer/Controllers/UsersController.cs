using AutoMapper;
using BookShopApiLayer.Models;
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
        private readonly IMapper mapper;
        private readonly IBookShopRepository _bookShopRep;

        public UsersController(IMapper mapper ,IBookShopRepository dataRepository)
        {
            this.mapper = mapper;
            _bookShopRep = dataRepository;
        }

        [HttpGet]
        public IEnumerable<UserModel> GetUsers()
        {
            return mapper.Map<IEnumerable<UserModel>>(_bookShopRep.GetUsers());
        }

        [HttpGet("{id:int}")]
        public ActionResult<UserModel> GetUser(int id)
        {
            var user = _bookShopRep.GetUser(id);
            if (user is null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<UserModel>(_bookShopRep.GetUsers()));
        }

        [HttpPost]
        public ActionResult PostUser([FromBody] UserModel user)
        {
            user.Id = _bookShopRep.AddUser(mapper.Map<User>(user));
             
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user.Id);
        }

        [HttpPut("{id:int}")]
        public ActionResult UpdateUser(int id, UserModel user)
        {
            user.Id = id;
            _bookShopRep.UpdateUser(mapper.Map<User>(user));
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
