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
    public class SortsController : ApiController
    {
        private APIDonjonEtDragonContext db = new APIDonjonEtDragonContext();

        // GET: api/Sorts
        public IQueryable<Sorts> GetSorts()
        {
            if (!db.Sorts.Any())
            {
                _ = PostSorts(new Sorts { Id_sorts = 1, Name_sorts = "Amis", VO_Name_sort = "Friends", Ecole = "enchantement", Niveau = 0, Tps_incant = "action", Portée = "personnelle", IsConcentration = true, Durée =1, Effet= "Pour la durée du sort, vous avez l'avantage à tous vos jets de Charisme effectués contre une créature de votre choix qui n'a pas une attitude hostile envers vous. Lorsque le sort prend fin, la créature réalise que vous avez utilisé la magie pour l'influencer et devient hostile à votre égard. Une créature plutôt violente risque de vous attaquer. D'autres créatures peuvent vous demander de l'argent ou un service (à la discrétion du MD), cela dépend de la nature de l'échange que vous avez eu avec la créature. ", Race_use= "Barde ; Ensorceleur ; Magicien ; Sorcier" });
                }

            return db.Sorts;
        }

        // GET: api/Sorts/5
        [ResponseType(typeof(Sorts))]
        public async Task<IHttpActionResult> GetSorts(int id)
        {
            Sorts sorts = await db.Sorts.FindAsync(id);
            if (sorts == null)
            {
                return NotFound();
            }

            return Ok(sorts);
        }

        // PUT: api/Sorts/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSorts(int id, Sorts sorts)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sorts.Id_sorts)
            {
                return BadRequest();
            }

            db.Entry(sorts).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SortsExists(id))
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

        // POST: api/Sorts
        [ResponseType(typeof(Sorts))]
        public async Task<IHttpActionResult> PostSorts(Sorts sorts)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sorts.Add(sorts);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = sorts.Id_sorts }, sorts);
        }

        // DELETE: api/Sorts/5
        [ResponseType(typeof(Sorts))]
        public async Task<IHttpActionResult> DeleteSorts(int id)
        {
            Sorts sorts = await db.Sorts.FindAsync(id);
            if (sorts == null)
            {
                return NotFound();
            }

            db.Sorts.Remove(sorts);
            await db.SaveChangesAsync();

            return Ok(sorts);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SortsExists(int id)
        {
            return db.Sorts.Count(e => e.Id_sorts == id) > 0;
        }
    }
}