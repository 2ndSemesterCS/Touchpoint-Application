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
    public class KursistsController : ApiController
    {
        private TouchpointDBContext db = new TouchpointDBContext();

        // GET: api/Kursists
        public IQueryable<Kursist> GetKursist()
        {
            return db.Kursist;
        }

        // GET: api/Kursists/5
        [ResponseType(typeof(Kursist))]
        public IHttpActionResult GetKursist(int id)
        {
            Kursist kursist = db.Kursist.Find(id);
            if (kursist == null)
            {
                return NotFound();
            }

            return Ok(kursist);
        }

        // PUT: api/Kursists/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKursist(int id, Kursist kursist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kursist.kursistID)
            {
                return BadRequest();
            }

            db.Entry(kursist).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KursistExists(id))
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

        // POST: api/Kursists
        [ResponseType(typeof(Kursist))]
        public IHttpActionResult PostKursist(Kursist kursist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Kursist.Add(kursist);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = kursist.kursistID }, kursist);
        }

        // DELETE: api/Kursists/5
        [ResponseType(typeof(Kursist))]
        public IHttpActionResult DeleteKursist(int id)
        {
            Kursist kursist = db.Kursist.Find(id);
            if (kursist == null)
            {
                return NotFound();
            }

            db.Kursist.Remove(kursist);
            db.SaveChanges();

            return Ok(kursist);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KursistExists(int id)
        {
            return db.Kursist.Count(e => e.kursistID == id) > 0;
        }
    }
}