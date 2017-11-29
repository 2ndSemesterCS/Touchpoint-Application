using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TouchpointDBWebService;

namespace TouchpointDBWebService.Controllers
{
    public class UnderviserController : ApiController
    {
        private TouchpointDBContext db = new TouchpointDBContext();

        // GET: api/Underviser
        public IQueryable<Underviser> GetUnderviser()
        {
            return db.Underviser;
        }

        // GET: api/Underviser/5
        [ResponseType(typeof(Underviser))]
        public IHttpActionResult GetUnderviser(int id)
        {
            Underviser underviser = db.Underviser.Find(id);
            if (underviser == null)
            {
                return NotFound();
            }

            return Ok(underviser);
        }

        // PUT: api/Underviser/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUnderviser(int id, Underviser underviser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != underviser.UnderviserID)
            {
                return BadRequest();
            }

            db.Entry(underviser).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UnderviserExists(id))
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

        // POST: api/Underviser
        [ResponseType(typeof(Underviser))]
        public IHttpActionResult PostUnderviser(Underviser underviser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Underviser.Add(underviser);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = underviser.UnderviserID }, underviser);
        }

        // DELETE: api/Underviser/5
        [ResponseType(typeof(Underviser))]
        public IHttpActionResult DeleteUnderviser(int id)
        {
            Underviser underviser = db.Underviser.Find(id);
            if (underviser == null)
            {
                return NotFound();
            }

            db.Underviser.Remove(underviser);
            db.SaveChanges();

            return Ok(underviser);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UnderviserExists(int id)
        {
            return db.Underviser.Count(e => e.UnderviserID == id) > 0;
        }
    }
}