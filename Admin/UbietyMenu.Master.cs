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
        public String designation = "";
        public int roleId;

        protected void Page_Load(object sender, EventArgs e)
        {
            String str = System.Web.HttpContext.Current.User.Identity.GetUserId();
            using (var context = new ubietydbEntities())
            {
                 var employee = context.Employees
                    .Where(b => b.AuthUserId.Equals(str)) 
                    .FirstOrDefault();

                 loggedinuser = employee.EmpName;
                 designation = employee.Designation;
                 roleId = employee.RoleId.HasValue?employee.RoleId.Value:0;
            }
        }
    }
}