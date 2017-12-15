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
    public class UndervisningsStedsController : ApiController
    {
        private TouchpointDBContext db = new TouchpointDBContext();

        // GET: api/UndervisningsSteds
        public IQueryable<UndervisningsSted> GetUndervisningsSted()
        {
            return db.UndervisningsSted;
        }

        // GET: api/UndervisningsSteds/5
        [ResponseType(typeof(UndervisningsSted))]
        public IHttpActionResult GetUndervisningsSted(int id)
        {
            UndervisningsSted undervisningsSted = db.UndervisningsSted.Find(id);
            if (undervisningsSted == null)
            {
                return NotFound();
            }

            return Ok(undervisningsSted);
        }

        // PUT: api/UndervisningsSteds/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUndervisningsSted(int id, UndervisningsSted undervisningsSted)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != undervisningsSted.UndervisningsStedID)
            {
                return BadRequest();
            }

            db.Entry(undervisningsSted).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UndervisningsStedExists(id))
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

        // POST: api/UndervisningsSteds
        [ResponseType(typeof(UndervisningsSted))]
        public IHttpActionResult PostUndervisningsSted(UndervisningsSted undervisningsSted)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UndervisningsSted.Add(undervisningsSted);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = undervisningsSted.UndervisningsStedID }, undervisningsSted);
        }

        // DELETE: api/UndervisningsSteds/5
        [ResponseType(typeof(UndervisningsSted))]
        public IHttpActionResult DeleteUndervisningsSted(int id)
        {
            UndervisningsSted undervisningsSted = db.UndervisningsSted.Find(id);
            if (undervisningsSted == null)
            {
                return NotFound();
            }

            db.UndervisningsSted.Remove(undervisningsSted);
            db.SaveChanges();

            return Ok(undervisningsSted);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UndervisningsStedExists(int id)
        {
            return db.UndervisningsSted.Count(e => e.UndervisningsStedID == id) > 0;
        }
    }
}