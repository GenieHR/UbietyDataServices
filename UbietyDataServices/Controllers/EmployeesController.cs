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
        public IQueryable<EmployeeDTO> GetEmpetail(string empnum, string email, Int64 mobileno)
        {
            var context = new ubietydbEntities();
            
Random random = new Random();
            int Otp = random.Next(10000, 100000);
            context.Configuration.ProxyCreationEnabled = false;

            var dataset2 = (from recordset in context.Employees
                            where recordset.EmpNum == empnum && recordset.Email == email && recordset.PrimaryMobile == mobileno
                            select new EmployeeDTO
                            {
                                EmpId = recordset.EmpId,
                                EmpNum = recordset.EmpNum,
                                EmpName = recordset.EmpName,
                                EmpStatus = recordset.EmpStatus,
                                Email = recordset.Email,
                                Otp = Otp
                            });

            if (dataset2.Count() == 1)
            {

           //// ?&&&&&20Platform

           //     var request = (HttpWebRequest)WebRequest.Create("http://smsc.biz/httpapi/send");

           //     ViaNettSMS s = new ViaNettSMS("laks@geniehr.com", "hr1bz");

           //     s.SendSMS()

           //     var postData = "?username=lakshman.pilaka@gmail.com";
           //     postData += "&password=Laks@5347";
           //     postData += "&sender_id=SMSIND";
           //     postData += "&route=T";
           //     postData += "&phonenumber=7032906292";
           //     postData += "&message=Test%20sms%20from%20lakshman.pilaka@gmail.com.%20Thanks%20for%20choosing%20our%20service%20-%20USERNAME%20SERVICE%20-%20SMSC%";
                
           //     var data = Encoding.ASCII.GetBytes(postData);

           //     request.Method = "POST";
           //     request.ContentType = "application/x-www-form-urlencoded";
           //     request.ContentLength = data.Length;

           //     using (var stream = request.GetRequestStream())
           //     {
           //         stream.Write(data, 0, data.Length);
           //     }



           //     var response = (HttpWebResponse)request.GetResponse();
           //     var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
           //     responseString.ToString();
            } 

            return dataset2;
        }
    }
}
