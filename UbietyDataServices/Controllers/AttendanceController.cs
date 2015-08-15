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
using System.Data.Spatial;
using System.Spatial;
using System.Runtime.Serialization.Json;


namespace UbietyDataServices.Controllers
{
    [RoutePrefix("api/attendance")]
    public class AttendanceController : ApiController
    {
        
        [Route("punch/{empid}/{shift}")]
        [HttpGet]

        public int MarkAttendance(int empid, int shift)
        {
            var context = new ubietydbEntities();

            Attendance attendance = new Attendance();

            attendance.EmpId = empid;
            attendance.MarkFlagId = shift;
            attendance.MarkTime =  TimeZoneInfo.ConvertTime(new DateTime(DateTime.Now.Ticks), TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"));
            context.Attendances.Add(attendance);
          
            return context.SaveChanges();
        }

        [Route("punch/{empid}/{shift}/{latitude}/{longitude}/{markcount}")]
        [HttpGet]
        public int MarkAttendanceWithLatLon(int empid, int shift, Double latitude, Double longitude, Int16 markcount)
        {
            var context = new ubietydbEntities();

            Attendance attendance = new Attendance();

            attendance.EmpId = empid;
            attendance.MarkFlagId = shift;
            attendance.MarkTime = TimeZoneInfo.ConvertTime(new DateTime(DateTime.Now.Ticks), TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"));
            attendance.latitude = latitude;
            attendance.longitude = longitude;
            attendance.markcount = markcount;
            context.Attendances.Add(attendance);

            return context.SaveChanges();
        }

        [Route("of/{id}")]
        [HttpGet]
        public dynamic getAttendance(int id)
        {
            var context = new ubietydbEntities();
            context.Configuration.ProxyCreationEnabled = false;

              var abc = (from recordset in context.attendancereports
                                where recordset.empid == id 
                                select new AttendanceLineDetail
                                {
                                    inMarkTime = recordset.inmarktime,
                                    inLatitude = recordset.inlatitude,
                                    inLongitude = recordset.inlongitude,
                                    inMarkCount = 1,
                                    empId = recordset.empid,
                                    outMarkTime = recordset.outmarktime,
                                    outLatitude = recordset.outlatitude,
                                    outLongitude = recordset.outlongitude,
                                    outMarkCount = 2
                                });

            return new { attendance = abc };
        }

        [Route("of/temp/{id}")]
        [HttpGet]
        public dynamic getAttendances(int id)
        {
            var context = new ubietydbEntities();
            context.Configuration.ProxyCreationEnabled = false;

            var abc = (from recordset in context.attRepTemp1
                       where recordset.empid == id
                       select recordset);

            return  abc ;


        }

    }


}
