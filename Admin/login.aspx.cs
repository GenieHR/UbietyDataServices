using Admin.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Admin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var roleManager = new RoleManager<Microsoft.AspNet.Identity.EntityFramework.IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
            //if (!roleManager.RoleExists("OrgEmployee"))
            //    roleManager.Create(new IdentityRole("OrgEmployee"));
        }

        protected override void OnInit(EventArgs e)
        {
            Button b = new Button();
            b.CssClass = "btn btn-primary block full-width m-b";
            b.ID = "Button";
            b.Text = "Login";
            
            b.Click += new EventHandler(b_Click);
            form1.Controls.Add(b);
        }

        void b_Click(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();

            TextBox tbUserName = (TextBox)form1.FindControl("username");
            TextBox tbPassword = (TextBox)form1.FindControl("password");

            var userManager = new UserManager<IdentityUser>(userStore);
            var user = userManager.Find(tbUserName.Text, tbPassword.Text);

            if (user != null)
            {
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);

                if (Request.QueryString["ReturnUrl"] == null)
                Response.Redirect("~/dashboard.aspx");
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }
    }
}