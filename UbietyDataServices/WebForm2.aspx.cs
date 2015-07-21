using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Security.Cryptography;
using System.Globalization;
using System.Text;
using System.Xml.Linq;
using System.IO;
using System.Xml;

namespace UbietyDataServices
{


    public partial class WebForm2 : System.Web.UI.Page
    {
      //  protected IEnumerable<IListBlobItem>
      //GetDirectoryList(string directoryName, string subDirectoryName)
      //  {
      //      CloudStorageAccount storageAccount =  CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
      //      CloudBlobClient cloudBlobClient = storageAccount.CreateCloudBlobClient();
      //      //cloudBlobClient.get
            
      //      CloudBlobDirectory directory = cloudBlobClient.d(directoryName);
      //      CloudBlobDirectory subDirectory = directory.GetSubdirectory(subDirectoryName);

      //      return subDirectory.ListBlobs();

      //  }


        protected void Page_Load(object sender, EventArgs e)
        {

            string Account = "ghrstorage";
            string Key = "Fft87Yha7U0YHtitCoYFEUL7fQyiiexqvlIqBoKTuksZrj5wKOhjpb6wLOenCxQrPJY+se4y1VcocF61hfrxmA==";
            string Container = "ubiety/EMP001/2015/07/20/AM";
            DateTime dt = DateTime.UtcNow;
            string dtnow = dt.ToString();
            string StringToSign = String.Format("HEAD\n"
                + "\n" // content encoding
                + "\n" // content language
                + "\n" // content length
                + "\n" // content md5
                + "\n" // content type
                + "\n" // date
                + "\n" // if modified since
                + "\n" // if match
                + "\n" // if none match
                + "\n" // if unmodified since
                + "\n" // range
                + "x-ms-date:" + dt.ToString("R") + "\nx-ms-version:2012-02-12\n" // headers
                + "/{0}/{1}\ncomp:metadata", Account, Container);

            string auth = SignThis(StringToSign, Key, Account);
            string method = "HEAD";
            string urlPath = string.Format("https://{0}.blob.core.windows.net/{1}?comp=metadata", Account, Container);
            Uri uri = new Uri(urlPath);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = method;
            request.Headers.Add("x-ms-date", dt.ToString("R"));
            request.Headers.Add("x-ms-version", "2012-02-12");
            request.Headers.Add("Authorization", auth);

            //using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            //{
            //    StreamReader ResponseDataStream = new StreamReader(response.GetResponseStream());
            //    String res = ResponseDataStream.ReadToEnd();

            //    XmlDocument XMLDoc = new XmlDocument();
            // //   XMLDoc.LoadXml(res);

            //    //XMLDoc.Save("E:/myfilename.xml");
            //}

        }

        private static String SignThis(String StringToSign, string Key, string Account)
        {
            String signature = string.Empty;
            byte[] unicodeKey = Convert.FromBase64String(Key);
            using (HMACSHA256 hmacSha256 = new HMACSHA256(unicodeKey))
            {
                Byte[] dataToHmac = System.Text.Encoding.UTF8.GetBytes(StringToSign);
                signature = Convert.ToBase64String(hmacSha256.ComputeHash(dataToHmac));
            }

            String authorizationHeader = String.Format(
                  CultureInfo.InvariantCulture,
                  "{0} {1}:{2}",
                  "SharedKey",
                  Account,
                  signature);

            return authorizationHeader;
        }
        

    }
}