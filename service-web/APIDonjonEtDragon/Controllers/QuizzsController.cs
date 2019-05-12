using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using APIDonjonEtDragon.Models;

namespace APIDonjonEtDragon.Controllers
{
    public class QuizzsController : ApiController
    {
        private APIDonjonEtDragonContext db = new APIDonjonEtDragonContext();

        // GET: api/Quizzs
        public IQueryable<Quizz> GetQuizzs()
        {
            return db.Quizzs;
        }

        // GET: api/Quizzs/5
        [ResponseType(typeof(Quizz))]
        public async Task<IHttpActionResult> GetQuizz(int id)
        {
            Quizz quizz = await db.Quizzs.FindAsync(id);
            if (quizz == null)
            {
                return NotFound();
            }

            return Ok(quizz);
        }

        // PUT: api/Quizzs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutQuizz(int id, Quizz quizz)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != quizz.Id_Player)
            {
                return BadRequest();
            }

            db.Entry(quizz).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuizzExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Quizzs
        [ResponseType(typeof(Quizz))]
        public async Task<IHttpActionResult> PostQuizz(Quizz quizz)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Quizzs.Add(quizz);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = quizz.Id_Player }, quizz);
        }

        // DELETE: api/Quizzs/5
        [ResponseType(typeof(Quizz))]
        public async Task<IHttpActionResult> DeleteQuizz(int id)
        {
            Quizz quizz = await db.Quizzs.FindAsync(id);
            if (quizz == null)
            {
                return NotFound();
            }

            db.Quizzs.Remove(quizz);
            await db.SaveChangesAsync();

            return Ok(quizz);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool QuizzExists(int id)
        {
            return db.Quizzs.Count(e => e.Id_Player == id) > 0;
        }
    }
}