using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UbietyDataServices.Models;
using Newtonsoft.Json;

namespace UbietyDataServices.Services
{
    public partial class register : System.Web.UI.Page
    {
        protected string Page_Load(object sender, EventArgs e)
        {
            using (var context = new ubietydbEntities())
            {
                var empQuery = from st in context.Employees
                where st.Email.ToUpper() == Request.Form["email"].ToUpper() && (st.PrimaryMobile == Convert.ToInt64( Request.Form["mobile"]))
                select st;
   
                if (empQuery.Count() == 1)
                {
                    return "ok";
                }
             }
            return "not ok";
        }   
    }
}