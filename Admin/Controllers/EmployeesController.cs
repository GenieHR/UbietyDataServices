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
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System.Web.Configuration;

namespace Admin.Controllers
{
    public class EmployeesController : ApiController
    {
        private ubietydbEntities db = new ubietydbEntities();

        // GET: api/Employees
        public IQueryable<Employee> GetEmployees()
        {
            return db.Employees;
        }

        // GET: api/Employees/5
        [ResponseType(typeof(Employee))]
        public IHttpActionResult GetEmployee(int id)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // PUT: api/Employees/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmployee(int id, Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employee.EmpId)
            {
                return BadRequest();
            }

            db.Entry(employee).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
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

        // POST: api/Employees
        [ResponseType(typeof(Employee))]
        public IHttpActionResult PostEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);

            var user = new IdentityUser() { UserName = employee.Email, Email = employee.Email, PhoneNumber = employee.PrimaryMobile.ToString() };
            IdentityResult result = manager.Create(user, WebConfigurationManager.AppSettings["DefaultPassword"]);

            
            
            if (result.Succeeded)
            {
                employee.AuthUserId = user.Id;
                db.Employees.Add(employee);
                db.SaveChanges() ;
            }
            else
            {

            }
            
            return CreatedAtRoute("DefaultApi", new { id = employee.EmpId }, employee);
        }

        // DELETE: api/Employees/5
        [ResponseType(typeof(Employee))]
        public IHttpActionResult DeleteEmployee(int id)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            db.Employees.Remove(employee);
            db.SaveChanges();

            return Ok(employee);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmployeeExists(int id)
        {
            return db.Employees.Count(e => e.EmpId == id) > 0;
        }

        [Route("api/clientEmps/{ClientId}")]
        [HttpGet]
        public ICollection<Employee> GetclientEmps(int ClientId)
        {
            var context = new ubietydbEntities();
            List<Employee> empCollection = context.Employees.Where(b => b.CompanyId == ClientId).ToList();
            return empCollection;
        }

        //[Route("api/clientEmps/{ClientId}")]
        //[HttpGet]
        //public ICollection<Employee> GetOrgEmp(int ClientId)
        //{
        //    var context = new ubietydbEntities();
        //    context.Configuration.ProxyCreationEnabled = false;

        //    var empclients = context.Employees.Where(b => b.CompanyId == ClientId).ToList();
        //    return empclients;

        //}

    }
}