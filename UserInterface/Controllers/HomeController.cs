using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogicLayer;

namespace UserInterface.Controllers
{
    public class HomeController : Controller
    {
        private CartBs cartBs;

        public HomeController()=> cartBs = new CartBs();
        public ActionResult Index()
        {
<<<<<<< HEAD
           
               
            
=======
            if (User.IsInRole("CanManagePortal"))
                return RedirectToAction("Home", "Admins");
            if (User.IsInRole("User"))
                return RedirectToAction("Index", "User");

>>>>>>> 06c73ce624381c300aafa21ee58abe7bf39c7f81
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
    }
}