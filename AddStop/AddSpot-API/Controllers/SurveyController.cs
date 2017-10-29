using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AddSpot_API.Models;

namespace AddSpot_API.Controllers
{
    [Route("api/[controller]")]
    public class SurveyController : Controller
    {
        private readonly Context _context;

        public SurveyController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Survey> GetAll()
        {
            return _context.Surveys.ToList();
        }

        [HttpGet("{id}", Name = "GetSurveyById")]
        public IActionResult GetById(long id)
        {
            var item = _context.Surveys.FirstOrDefault(t => t.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            return new ObjectResult(item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Survey updatedSurvey)
        {
            if (updatedSurvey == null || updatedSurvey.Id != id)
            {
                return BadRequest();
            }

            var currentSurvey = _context.Surveys.FirstOrDefault(t => t.Id == id);
            if (currentSurvey == null)
            {
                return NotFound();
            }

            currentSurvey.Date = updatedSurvey.Date;
            currentSurvey.Id = updatedSurvey.Id;
            currentSurvey.IdPersonType = updatedSurvey.IdPersonType;
            currentSurvey.UserID = updatedSurvey.UserID;
            currentSurvey.Question = updatedSurvey.Question;
            

            _context.Surveys.Update(currentSurvey);
            _context.SaveChanges();

            return new NoContentResult();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Survey survey)
        {
            if (survey == null)
            {
                return BadRequest();
            }

            _context.Surveys.Add(survey);
            _context.SaveChanges();

            return CreatedAtRoute("GetSurveyById", new { id = survey.Id }, survey);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var survey = _context.Surveys.FirstOrDefault(t => t.Id == id);

            if (survey == null)
            {
                return NotFound();
            }

            _context.Surveys.Remove(survey);
            _context.SaveChanges();

            return new NoContentResult();
        }
    }
 }