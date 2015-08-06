using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Admin.Models;

namespace Admin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

                ubietydbEntities dbcontext = new ubietydbEntities();

                using (var context = new ubietydbEntities())
                {
                    var allRows = from b in context.EmpStatus
                                  select new SelectListItem
                                  {
                                      Value = b.EmpStatusId.ToString(),
                                      Text = b.StatusName
                                  };
                
                var model = new EmpStatu
                {
                    EmpStatuses = allRows
                };
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Employee()
        {
            ViewBag.Message = "Create Employee";

            return View();
        }



        //public ActionResult EmpStatus()
        //{
        //    EmpStatu objModel = new EmpStatu();
        //    objModel.getAllStatusesList = objModel.getAllList();
        //    return View(objModel);
        //}

        //public ActionResult EmpStatus()
        //{
        //    List<SelectListItem> items = new List<SelectListItem>();

        //    ubietydbEntities dbcontext = new ubietydbEntities();

        //    var allRows = dbcontext.EmpStatus.ToList();

        //    foreach (var result in allRows)
        //    {
        //        items.Add(new SelectListItem { Text = result.EmpStatusId.ToString(), Value = result.StatusName});
        //    }
        //    ViewBag.EmmployeeStatus = items;
        //    return View();

        //}
    }
}