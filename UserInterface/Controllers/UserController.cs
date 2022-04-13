using System.Web.Mvc;
using System.Collections.Generic;
using DataModelLayer;
using BusinessLogicLayer.Users;
using UserInterface.ViewModel;

namespace UserInterface.Controllers
{
    [Authorize(Roles ="User")]
    public class UserController : Controller
    {
        private readonly UserBs _userBs;
        public UserController()
        {
            _userBs = new UserBs();
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowProducts()
        {
           var products = _userBs.ShowAllProducts();
            return View(products);
        }

        public ActionResult Wishlist()
        {
            return View();
        }

        public ActionResult Cart()
        {
            return View();
        }

        public void BuyNow()
        {
           
        }

        public void AddToWishlist()
        {

        }

        public ActionResult AddDeliveryAddress()
        {
            return View();
        }

        public ActionResult AddAddress(DeliveryAddress deliveryAddress)
        {
            _userBs.AddAddress(deliveryAddress);
            return View("ShowProducts");
        }
    }
}