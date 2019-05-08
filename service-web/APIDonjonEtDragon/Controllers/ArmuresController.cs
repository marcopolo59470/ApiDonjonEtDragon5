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
    public class ArmuresController : ApiController
    {
        private APIDonjonEtDragonContext db = new APIDonjonEtDragonContext();

        // GET: api/Armures
        public IQueryable<Armures> GetArmures()
        {
            if (!db.Armures.Any())
            {
                _ = PostArmures(new Armures { Id_armure = 1, Name_armure = "Harnois", VO_Name_armure = "Plate", CA = 18, Force = "15", Poids_armure = 32, Prix_armure = "1500 po", Description_armure = "Le harnois est constitué de plaques de métal entrecroisées qui couvrent l'ensemble du corps. L'ensemble inclut des gants, des bottes en cuir épais, un casque à visière, et d'épaisses couches de rembourrage sous l'armure. Des boucles et des sangles distribuent le poids sur le corps.." });
            }

            return db.Armures;
        }

        // GET: api/Armures/5
        [ResponseType(typeof(Armures))]
        public async Task<IHttpActionResult> GetArmures(int id)
        {
            Armures armures = await db.Armures.FindAsync(id);
            if (armures == null)
            {
                return NotFound();
            }

            return Ok(armures);
        }

        // PUT: api/Armures/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutArmures(int id, Armures armures)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != armures.Id_armure)
            {
                return BadRequest();
            }

            db.Entry(armures).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArmuresExists(id))
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

        // POST: api/Armures
        [ResponseType(typeof(Armures))]
        public async Task<IHttpActionResult> PostArmures(Armures armures)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Armures.Add(armures);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = armures.Id_armure }, armures);
        }

        // DELETE: api/Armures/5
        [ResponseType(typeof(Armures))]
        public async Task<IHttpActionResult> DeleteArmures(int id)
        {
            Armures armures = await db.Armures.FindAsync(id);
            if (armures == null)
            {
                return NotFound();
            }

            db.Armures.Remove(armures);
            await db.SaveChangesAsync();

            return Ok(armures);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ArmuresExists(int id)
        {
            return db.Armures.Count(e => e.Id_armure == id) > 0;
        }
    }
}