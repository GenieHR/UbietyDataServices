using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Auth;
using UbietyDataServices.Models;
using Newtonsoft.Json;

namespace UbietyDataServices
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var context = new ubietydbEntities();
            
            Attendance attendance = new Attendance();

            attendance.EmpId = Convert.ToInt16(Request.Form["empid"]);
            attendance.MarkFlagId = 1;
            attendance.MarkTime = TimeZoneInfo.ConvertTime(new DateTime(DateTime.Now.Ticks), TimeZoneInfo.FindSystemTimeZoneById("india standard time"));
            attendance.latitude = Convert.ToDouble(Request.Form["latitude"]);
            attendance.longitude = Convert.ToDouble(Request.Form["longitude"]);
            attendance.markcount = Convert.ToInt16(Request.Form["count"]);
            
            context.Attendances.Add(attendance);
            
            if (context.SaveChanges() == 1) 
            { 

            //HttpClient client = new HttpClient();
            //client.GetAsync(new Uri("http://ubietyapi.azurewebsites.net/api/attendance/punch/1/1/1.2/2.1/-1"));

                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
                CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

                CloudBlobContainer container = blobClient.GetContainerReference("ubiety");
                container.CreateIfNotExists();

                container.SetPermissions(new BlobContainerPermissions
                {
                    PublicAccess = BlobContainerPublicAccessType.Blob
                });

                DateTime IST = TimeZoneInfo.ConvertTime(new DateTime(DateTime.Now.Ticks), TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"));
                String blobName = Request.Form["name"] + "/" + IST.ToString("yyyy") + "/" + IST.ToString("MM") + "/" + IST.ToString("dd") + "/" + Request.Form["count"].ToString();
                CloudBlockBlob blockBlob = container.GetBlockBlobReference(blobName);
            
                blockBlob.UploadFromStream(Request.Files[0].InputStream);
            }
 
            //if (blockBlob.Exists())
            //{
            //    blockBlob = container.GetBlockBlobReference(blobName.Replace("/AM", "/PM"));
            //}
            //if (!blockBlob.Exists())
            //{
            //    blockBlob.Metadata.Add("Latitude", Request.Form["latitude"]);
            //    blockBlob.Metadata.Add("Longitude", Request.Form["longitude"]);
            //    blockBlob.UploadFromStream(Request.Files[0].InputStream);
            //}
        }
    }
}