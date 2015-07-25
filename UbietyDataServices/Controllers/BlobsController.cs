using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
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
    [RoutePrefix("api/get")]
    public class BlobsController : ApiController
    {
        [Route("blobsof/{empnum}/{year}/{month}/{day}")]
        [HttpGet]
        public string getBlobs(String empnum, String year, String month, String day)
        {
            
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference("ubiety");

            String uriString;

            //if (year == "0")
            //{
            //    uriString = empnum + "/";
            //}
            //else if (month == "0")
            //{
            //    uriString = empnum + "/" + year ;
            //}
            //else if(day == "0")
            //{
            //    uriString = empnum + "/" + year + "/" + month + "/";
            //}
            //else
            //{
               uriString = empnum + "/" + year + "/" + month + "/" + day;
            //}

            CloudBlobDirectory cbd = container.GetDirectoryReference(uriString);

            List<EmployeeeBlobs> blobList = new List<EmployeeeBlobs>();
            EmployeeeBlobs empBlobs;

            foreach (IListBlobItem item in cbd.ListBlobs())
            {
                if (item.GetType() == typeof(CloudBlockBlob))
                {
                    empBlobs = new EmployeeeBlobs();
                    
                    CloudBlockBlob blob = (CloudBlockBlob)item;
                    
                    blob.FetchAttributes();

                    empBlobs.blobURL =   blob.Name;
                    empBlobs.longitude = blob.Metadata["Longitude"];
                    empBlobs.latitude = blob.Metadata["Latitude"];

                    blobList.Add(empBlobs);
                }
            }
            return JsonConvert.SerializeObject(blobList, Formatting.None);
        }


    }
}
