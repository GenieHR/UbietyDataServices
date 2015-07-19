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
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            CloudBlobContainer container = blobClient.GetContainerReference("ubiety");
            container.CreateIfNotExists();

            container.SetPermissions(new BlobContainerPermissions
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            });

            DateTime IST = TimeZoneInfo.ConvertTime(new DateTime(DateTime.Now.Ticks), TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"));

            String blobName = Request.Form["name"] + "/" + IST.ToString("yyyy") + "/" + IST.ToString("MM") + "/" + IST.ToString("dd") + "/" + "AM";

            CloudBlockBlob blockBlob = container.GetBlockBlobReference(blobName);

            if (blockBlob.Exists())
            {
                blockBlob = container.GetBlockBlobReference(blobName.Replace("/AM", "/PM"));
            }

            if (!blockBlob.Exists())
            {
                blockBlob.Metadata.Add("Latitude", Request.Form["latitude"]);
                blockBlob.Metadata.Add("Longitude", Request.Form["longitude"]);

                blockBlob.UploadFromStream(Request.Files[0].InputStream);
            }
        }
    }
}