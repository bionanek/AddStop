using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AddSpot_API.Models;

namespace AddSpot_API.Controllers
{
    [Route("api/[controller]")]
    public class QuestionsController : Controller
    {
        private readonly Context _context;

        public QuestionsController (Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Questions> GetAll()
        {
            return _context.Questions.ToList();
        }

        [HttpGet("{id}", Name = "GetQuestionById")]
        public IActionResult GetById (long id)
        {
            var item = _context.Questions.FirstOrDefault(t => t.ID == id);

            if (item == null)
            {
                return NotFound();
            }

            return new ObjectResult(item); 
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Questions updatedQuestions)
        {
            if (updatedQuestions == null || updatedQuestions.ID != id)
            {
                return BadRequest();
            }

            var currentQuestions = _context.Questions.FirstOrDefault(t => t.ID == id);

            if (currentQuestions == null)
            {
                return NotFound();
            }

            currentQuestions.ID = updatedQuestions.ID;
            currentQuestions.Content = updatedQuestions.Content;

            _context.Questions.Update(currentQuestions);
            _context.SaveChanges();

            return new NoContentResult();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Questions questions)
        {
            if (questions == null)
            {
                return BadRequest();
            }

            _context.Questions.Add(questions);
            _context.SaveChanges();

            return CreatedAtRoute("GetQuestionById", new { id = questions.ID }, questions);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var questions = _context.Questions.FirstOrDefault(t => t.ID == id);

            if (questions == null)
            {
                return NotFound();
            }

            _context.Questions.Remove(questions);
            _context.SaveChanges();

            return new NoContentResult();
        }

    }
}
