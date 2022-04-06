using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataModelLayer;
using BusinessLogicLayer;

namespace UserInterface.Controllers
{
    public class AdminsController : Controller
    {
        AdminBll adminBll;
        public AdminsController ()
        {
            adminBll = new AdminBll();
        }


        // GET: Admin
        public ActionResult Home()
        {

            return View(adminBll.GetProducts());
        }

        public ActionResult ProductList()
        {
            return View();
        }

        public ActionResult ProductAlert()
        {
            return View();
        }

        public ActionResult ProductConfirm()
        {
            return View();
        }

        public ActionResult TodayExpectedDelivery()
        {
            return View();
        }



    }
}