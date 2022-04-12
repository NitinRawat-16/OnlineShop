﻿using System.Web.Mvc;
using System.Collections.Generic;
using DataModelLayer;
using BusinessLogicLayer.Users;

namespace UserInterface.Controllers
{
    public class UserController : Controller
    {
        private readonly ViewProducts _viewProducts;
        public UserController()
        {
            _viewProducts = new ViewProducts();
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowProducts()
        {
           var products = _viewProducts.ShowAllProducts();
            return View(products);
        }


    }
}