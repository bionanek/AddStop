using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AddSpot_API.Models;

namespace AddSpot_API.Controllers
{
    [Route("api/[controller]")]
    public class PersonTypeController : Controller
    {
        private readonly Context _context;

        public PersonTypeController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<PersonType> GetAll()
        {
            return _context.PersonTypes.ToList();
        }

        [HttpGet("{id}", Name = "GetPersonTypeById")]
        public IActionResult GetById (long id)
        {
            var item = _context.PersonTypes.FirstOrDefault(t => t.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            return new ObjectResult(item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] PersonType updatedPersonType)
        {
            if (updatedPersonType == null || updatedPersonType.Id != id)
            {
                return BadRequest();
            }

            var currentPersonType = _context.PersonTypes.FirstOrDefault(t => t.Id == id);

            if (currentPersonType == null)
            {
                return NotFound();
            }

            currentPersonType.Id = updatedPersonType.Id;
            currentPersonType.Name = updatedPersonType.Name;

            _context.PersonTypes.Update(currentPersonType);
            _context.SaveChanges();

            return new NoContentResult();
        }

        [HttpPost]
        public IActionResult Create([FromBody] PersonType personType)
        {
            if (personType == null)
            {
                return BadRequest();
            }

            _context.PersonTypes.Add(personType);
            _context.SaveChanges();

            return CreatedAtRoute("GetPersonTypeById", new { id = personType.Id }, personType);
            
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var personType = _context.PersonTypes.FirstOrDefault(t => t.Id == id);

            if (personType == null)
            {
                return NotFound();
            }

            _context.PersonTypes.Remove(personType);
            _context.SaveChanges();

            return new NoContentResult();
        }
    }
}