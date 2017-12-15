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
    public class SeriesController : ApiController
    {
        private TouchpointDBContext db = new TouchpointDBContext();

        // GET: api/Series
        public IQueryable<Serie> GetSerie()
        {
            return db.Serie;
        }

        // GET: api/Series/5
        [ResponseType(typeof(Serie))]
        public IHttpActionResult GetSerie(int id)
        {
            Serie serie = db.Serie.Find(id);
            if (serie == null)
            {
                return NotFound();
            }

            return Ok(serie);
        }

        // PUT: api/Series/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSerie(int id, Serie serie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != serie.SerieID)
            {
                return BadRequest();
            }

            db.Entry(serie).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SerieExists(id))
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

        // POST: api/Series
        [ResponseType(typeof(Serie))]
        public IHttpActionResult PostSerie(Serie serie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Serie.Add(serie);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = serie.SerieID }, serie);
        }

        // DELETE: api/Series/5
        [ResponseType(typeof(Serie))]
        public IHttpActionResult DeleteSerie(int id)
        {
            Serie serie = db.Serie.Find(id);
            if (serie == null)
            {
                return NotFound();
            }

            db.Serie.Remove(serie);
            db.SaveChanges();

            return Ok(serie);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SerieExists(int id)
        {
            return db.Serie.Count(e => e.SerieID == id) > 0;
        }
    }
}