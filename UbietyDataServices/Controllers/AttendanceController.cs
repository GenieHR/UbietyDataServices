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
using System.Data.Entity;

namespace UbietyDataServices.Controllers
{
    [RoutePrefix("api/attendance")]
    public class AttendanceController : ApiController
    {
        [Route("punch/{empid}/{shift}")]
        [HttpGet]

        public int MarkAttendance(int empid, int shift)
        {
            var ctx = new ubietydbEntities();

            Attendance attendance = new Attendance();

            attendance.EmpId = empid;
            attendance.MarkFlagId = shift;
            attendance.MarkTime =  TimeZoneInfo.ConvertTime(new DateTime(DateTime.Now.Ticks), TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"));
            ctx.Attendances.Add(attendance);
          
            return ctx.SaveChanges();
            
        }

    }
}
