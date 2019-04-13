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
using MonApi.Models;

namespace MonApi.Controllers
{
    public class ArmesController : ApiController
    {
        private MonApiContext db = new MonApiContext();

        // GET: api/Armes
        public IQueryable<Armes> GetArmes()
        {
            return db.Armes;
        }

        // GET: api/Armes/5
        [ResponseType(typeof(Armes))]
        public async Task<IHttpActionResult> GetArmes(int id)
        {
            Armes armes = await db.Armes.FindAsync(id);
            if (armes == null)
            {
                return NotFound();
            }

            return Ok(armes);
        }

        // PUT: api/Armes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutArmes(int id, Armes armes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != armes.Id)
            {
                return BadRequest();
            }

            db.Entry(armes).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArmesExists(id))
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

        // POST: api/Armes
        [ResponseType(typeof(Armes))]
        public async Task<IHttpActionResult> PostArmes(Armes armes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Armes.Add(armes);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = armes.Id }, armes);
        }

        // DELETE: api/Armes/5
        [ResponseType(typeof(Armes))]
        public async Task<IHttpActionResult> DeleteArmes(int id)
        {
            Armes armes = await db.Armes.FindAsync(id);
            if (armes == null)
            {
                return NotFound();
            }

            db.Armes.Remove(armes);
            await db.SaveChangesAsync();

            return Ok(armes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ArmesExists(int id)
        {
            return db.Armes.Count(e => e.Id == id) > 0;
        }
    }
}