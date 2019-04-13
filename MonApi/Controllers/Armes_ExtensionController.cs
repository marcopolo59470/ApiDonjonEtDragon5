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
    public class Armes_ExtensionController : ApiController
    {
        private MonApiContext db = new MonApiContext();

        // GET: api/Armes_Extension
        public IQueryable<Armes_Extension> GetExtensions()
        {
            return db.Extensions;
        }

        // GET: api/Armes_Extension/5
        [ResponseType(typeof(Armes_Extension))]
        public async Task<IHttpActionResult> GetArmes_Extension(int id)
        {
            Armes_Extension armes_Extension = await db.Extensions.FindAsync(id);
            if (armes_Extension == null)
            {
                return NotFound();
            }

            return Ok(armes_Extension);
        }

        // PUT: api/Armes_Extension/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutArmes_Extension(int id, Armes_Extension armes_Extension)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != armes_Extension.Id)
            {
                return BadRequest();
            }

            db.Entry(armes_Extension).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Armes_ExtensionExists(id))
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

        // POST: api/Armes_Extension
        [ResponseType(typeof(Armes_Extension))]
        public async Task<IHttpActionResult> PostArmes_Extension(Armes_Extension armes_Extension)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Extensions.Add(armes_Extension);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = armes_Extension.Id }, armes_Extension);
        }

        // DELETE: api/Armes_Extension/5
        [ResponseType(typeof(Armes_Extension))]
        public async Task<IHttpActionResult> DeleteArmes_Extension(int id)
        {
            Armes_Extension armes_Extension = await db.Extensions.FindAsync(id);
            if (armes_Extension == null)
            {
                return NotFound();
            }

            db.Extensions.Remove(armes_Extension);
            await db.SaveChangesAsync();

            return Ok(armes_Extension);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Armes_ExtensionExists(int id)
        {
            return db.Extensions.Count(e => e.Id == id) > 0;
        }
    }
}