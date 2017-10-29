using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddSpot_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace AddSpot_API.Controllers
{
    [Route("api/[controller]")]
    public class AdvertisementController : Controller
    {
        private readonly Context _context;

        public AdvertisementController(Context context)
        {
            _context = context;

            //if (_context.Adverts.Count() <= 0)
            //{
            //    _context.Adverts.Add(new Advertisement()
            //    {
                    
            //    });
            //    _context.SaveChanges();
            //}
        }

        [HttpGet]
        public IEnumerable<Advertisement> GetAll()
        {
            return _context.Adverts.ToList();
        }

        [HttpGet("{id}", Name = "GetAdvert")]
        public IActionResult GetById(long id)
        {
            var item = _context.Adverts.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Advertisement advert)
        {
            if (advert == null)
                return BadRequest();
            _context.Adverts.Add(advert);
            _context.SaveChanges();

            return CreatedAtRoute("GetAdvert", new { id = advert.Id }, advert);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Advertisement updatedAdvert)
        {
            if (updatedAdvert == null || updatedAdvert.Id != id)
                return BadRequest();

            var currentAdvert = _context.Adverts.FirstOrDefault(t => t.Id == id);
            if (currentAdvert == null)
                return NotFound();

            currentAdvert.AddedFromLat = updatedAdvert.AddedFromLat;
            currentAdvert.AddedFromLong = updatedAdvert.AddedFromLong;
            currentAdvert.DateAdded = updatedAdvert.DateAdded;
            currentAdvert.DestLat = updatedAdvert.DestLat;
            currentAdvert.DestLong = updatedAdvert.DestLong;
            currentAdvert.MateAccepted = updatedAdvert.MateAccepted;
            currentAdvert.MateId = updatedAdvert.MateId;
            currentAdvert.OwnerAccepted = updatedAdvert.OwnerAccepted;
            currentAdvert.OwnerId = updatedAdvert.OwnerId;
            currentAdvert.RequiredAge = updatedAdvert.RequiredAge;
            currentAdvert.RequiredSex = updatedAdvert.RequiredSex;
            currentAdvert.State = updatedAdvert.State;
            currentAdvert.TripDate = updatedAdvert.TripDate;

            _context.Adverts.Update(currentAdvert);
            _context.SaveChanges();

            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var advert = _context.Adverts.FirstOrDefault(t => t.Id == id);
            if (advert == null)
                return NotFound();

            _context.Adverts.Remove(advert);
            _context.SaveChanges();

            return new NoContentResult();
        }

        [HttpPost("{userId}/{advertId}", Name="JoinToAdvert")]
        public IActionResult JoinToAdvert(long userId, long advertId)
        {
            _context.Users.FirstOrDefault(f => f.Id == userId);
            var advert = new Advertisement() { Id = advertId };

            return new NoContentResult();
        }
    }
}
