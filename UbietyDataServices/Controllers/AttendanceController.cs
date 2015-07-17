using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using UbietyDataServices.Models;

namespace UbietyDataServices.Controllers
{
    public class AttendanceController : ApiController
    {
        private ubietydbEntities db = new ubietydbEntities();

        // GET api/Attendance
        public IEnumerable<Attendance> GetAttendances()
        {
            var attendances = db.Attendances.Include(a => a.AttendanceFlag);
            return attendances.AsEnumerable();
        }

        // GET api/Attendance/5
        public Attendance GetAttendance(int id)
        {
            Attendance attendance = db.Attendances.Find(id);
            if (attendance == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return attendance;
        }

        // PUT api/Attendance/5
        public HttpResponseMessage PutAttendance(int id, Attendance attendance)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != attendance.AttendanceId)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            db.Entry(attendance).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST api/Attendance
        public HttpResponseMessage PostAttendance(Attendance attendance)
        {
            if (ModelState.IsValid)
            {
                db.Attendances.Add(attendance);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, attendance);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = attendance.AttendanceId }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // DELETE api/Attendance/5
        public HttpResponseMessage DeleteAttendance(int id)
        {
            Attendance attendance = db.Attendances.Find(id);
            if (attendance == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Attendances.Remove(attendance);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, attendance);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}