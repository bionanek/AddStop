using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddSpot_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace AddSpot_API.Controllers
{
    
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly UserContext _context;

        public UserController(UserContext context)
        {
            _context = context;

            if(_context.Users.Count() <= 0)
            {
                _context.Users.Add(new User {
                    Login = "user",
                    Password = "user",
                    Name = "Janusz",
                    Surname = "Ananas"
                });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        [HttpGet("{id}", Name = "GetUser")]
        public IActionResult GetById(long id)
        {
            var item = _context.Users.FirstOrDefault(t => t.Id == id);
            if(item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        //// GET: api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
