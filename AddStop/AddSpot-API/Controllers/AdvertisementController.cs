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

            if (_context.Adverts.Count() <= 0)
            {
                _context.Adverts.Add(new Advertisement()
                {
                    Owner = _context.Users.FirstOrDefault(t => t.Id == 1),
                    Mate = _context.Users.FirstOrDefault(t => t.Id == 1),
                    DestLat = 10.10m,
                    DestLong = 10.10m,
                    AddedFromLat = 10.10m,
                    AddedFromLong = 10.10m,
                    TripDate = DateTime.Today,
                    RequiredAge = 19,
                    RequiredSex = Enums.Sex.MALE,
                    OwnerAccepted = true,
                    MateAccepted = true,
                    State = Enums.AdvertState.ACCEPTED,
                    DateAdded = DateTime.Today
                });
                _context.SaveChanges();
            }
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
            currentAdvert.Mate = updatedAdvert.Mate;
            currentAdvert.OwnerAccepted = updatedAdvert.OwnerAccepted;
            currentAdvert.Owner = updatedAdvert.Owner;
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

        [HttpPut("{userId}/{advertId}", Name="JoinToAdvert")]
        public IActionResult JoinToAdvert(long userId, long advertId)
        {
            var user = _context.Users.FirstOrDefault(f => f.Id == userId);
            //var advert = _context.Adverts.FirstOrDefault(f => f.Id == advertId);

            if (user == null)
                return NotFound();


            var advert = new Advertisement() { Id = advertId, Mate = user };

            using (var context = _context)
            {
                context.Adverts.Attach(advert);
                context.Entry(advert).Property(x => x.Mate).IsModified = true;
                context.SaveChanges(); 
            }

            //var currentAdvert = _context.Adverts.FirstOrDefault(t => t.Id == advertId);
            //if (currentAdvert == null)
            //    return NotFound();

            //currentAdvert.AddedFromLat = currentAdvert.AddedFromLat;
            //currentAdvert.AddedFromLong = currentAdvert.AddedFromLong;
            //currentAdvert.DateAdded = currentAdvert.DateAdded;
            //currentAdvert.DestLat = currentAdvert.DestLat;
            //currentAdvert.DestLong = currentAdvert.DestLong;
            //currentAdvert.MateAccepted = currentAdvert.MateAccepted;
            //currentAdvert.Mate = user;
            //currentAdvert.OwnerAccepted = currentAdvert.OwnerAccepted;
            //currentAdvert.Owner = currentAdvert.Owner;
            //currentAdvert.RequiredAge = currentAdvert.RequiredAge;
            //currentAdvert.RequiredSex = currentAdvert.RequiredSex;
            //currentAdvert.State = currentAdvert.State;
            //currentAdvert.TripDate = currentAdvert.TripDate;

            //_context.Adverts.Update(currentAdvert);
            //_context.SaveChanges();
            return new NoContentResult();
        }
    }
}
