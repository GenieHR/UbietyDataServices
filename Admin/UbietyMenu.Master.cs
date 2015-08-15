using Admin.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Admin
{
    public partial class UbietyMenu : System.Web.UI.MasterPage
    {
        public String loggedinuser = "";
        protected void Page_Load(object sender, EventArgs e)
        {
             loggedinuser = Page.User.Identity.Name;
        }
    }
}