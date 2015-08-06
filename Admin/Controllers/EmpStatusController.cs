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
using Admin.Models;

namespace Admin.Controllers
{
    public class EmpStatusController : ApiController
    {
        private ubietydbEntities db = new ubietydbEntities();

        // GET: api/EmpStatus
        public IEnumerable<EmpStatu> GetEmpStatus()
        {
            return db.EmpStatus;
        }

        // GET: api/EmpStatus/5
        [ResponseType(typeof(EmpStatu))]
        public IHttpActionResult GetEmpStatu(int id)
        {
            EmpStatu empStatu = db.EmpStatus.Find(id);
            if (empStatu == null)
            {
                return NotFound();
            }

            return Ok(empStatu);
        }

        // PUT: api/EmpStatus/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmpStatu(int id, EmpStatu empStatu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != empStatu.EmpStatusId)
            {
                return BadRequest();
            }

            db.Entry(empStatu).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpStatuExists(id))
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

        // POST: api/EmpStatus
        [ResponseType(typeof(EmpStatu))]
        public IHttpActionResult PostEmpStatu(EmpStatu empStatu)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EmpStatus.Add(empStatu);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = empStatu.EmpStatusId }, empStatu);
        }

        // DELETE: api/EmpStatus/5
        [ResponseType(typeof(EmpStatu))]
        public IHttpActionResult DeleteEmpStatu(int id)
        {
            EmpStatu empStatu = db.EmpStatus.Find(id);
            if (empStatu == null)
            {
                return NotFound();
            }

            db.EmpStatus.Remove(empStatu);
            db.SaveChanges();

            return Ok(empStatu);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmpStatuExists(int id)
        {
            return db.EmpStatus.Count(e => e.EmpStatusId == id) > 0;
        }
    }
}