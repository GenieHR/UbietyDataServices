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
using UbietyDataServices.Services;
using Newtonsoft.Json;

namespace UbietyDataServices.Services
{
    public partial class MockUpload : System.Web.UI.Page
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

            String blobName = Request.Headers["name"] ;

            CloudBlockBlob blockBlob = container.GetBlockBlobReference(blobName);
            
            blockBlob.UploadFromStream(Request.Files[0].InputStream);
        }
    }
}
