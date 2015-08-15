using System.Collections.Generic;
using System.Web.Http;
using UbietyDataServices.Models;
using System.Linq;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Web.Http.Results;
using System;
using System.Text;
using System.IO;

namespace UbietyDataServices.Controllers
{
    [RoutePrefix("api/employees")]
    public class EmployeesController : ApiController
    {
        [Route("GetEmpDetails/{empnum}/{email}/{mobileno}")]
        [HttpGet]
        public IQueryable<EmployeeDTO> GetEmpDetail(string empnum, string email, Int64 mobileno)
        {
            var context = new ubietydbEntities();
            
            Random random = new Random();
            int Otp = random.Next(10000, 100000);
            context.Configuration.ProxyCreationEnabled = false;

            var dataset2 = (from recordset in context.Employees
                            where recordset.EmpNum.ToUpper() == empnum.ToUpper() && recordset.Email.ToUpper() == email.ToUpper() && recordset.PrimaryMobile == mobileno
                            select new EmployeeDTO
                            {
                                EmpId = recordset.EmpId,
                                EmpNum = recordset.EmpNum,
                                EmpName = recordset.EmpName,
                                EmpStatus = recordset.EmpStatus,
                                Email = recordset.Email,
                                Otp = Otp
                            });

            return dataset2;
        }

        [Route("GetEmpDetails/")]
        [HttpGet]
        public IQueryable<EmployeeDTO> GetEmpList()
        {
            var context = new ubietydbEntities();
            context.Configuration.ProxyCreationEnabled = false;

            var dataset2 = (from recordset in context.Employees
                            where recordset.EmpStatus == 1 
                            select new EmployeeDTO
                            {
                                EmpId = recordset.EmpId,
                                EmpNum = recordset.EmpNum,
                                EmpName = recordset.EmpName,
                                Email = recordset.Email,
                                MobileNum = recordset.PrimaryMobile,
                                ProfilePicURL = recordset.ProfilePic
                            });
            return dataset2;

        }

        [Route("GetEmpDetail/of/{id}")]
        [HttpGet]
        public dynamic GetEmpDetailsOf(int id)
        {
            var context = new ubietydbEntities();
            context.Configuration.ProxyCreationEnabled = false;

            var dataset2 = (from recordset in context.Employees
                            where recordset.EmpId == id 
                            select new EmployeeDTO
                            {
                                EmpId = recordset.EmpId,
                                EmpNum = recordset.EmpNum,
                                EmpName = recordset.EmpName,
                                Email = recordset.Email,
                                MobileNum = recordset.PrimaryMobile,
                                ProfilePicURL = recordset.ProfilePic
                            });
            return new { employee = dataset2 };
        }
    }
}
