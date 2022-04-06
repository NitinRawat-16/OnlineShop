using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogicLayer;
using UserInterface.ViewModel;

namespace UserInterface.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        ProductCategoryBs productCategory = new ProductCategoryBs();
        ProductBs product = new ProductBs();
        ProductSizeBs productSize = new ProductSizeBs();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddProduct()
        {
            var categoryViewModel = new ProductViewModel
            {
                ProductCategories = productCategory.GetAll().ToList()
             };
            return View(categoryViewModel);
        }
        
        [HttpPost]
        public ActionResult Save(ProductViewModel productViewModel)
        {
            var ViewModel = new ProductViewModel
            {
                product = productViewModel.product,
                ProductSize = productViewModel.ProductSize,
                ProductCategories = productViewModel.ProductCategories
            };
            productSize.Insert(ViewModel.ProductSize);
            productViewModel.product.ProductSizeId = ViewModel.ProductSize.ProductSizeId;
            productViewModel.product.TotalProductAdded = ViewModel.ProductSize.L 
                + ViewModel.ProductSize.S 
                + ViewModel.ProductSize.M
                + ViewModel.ProductSize.Xl;
            productViewModel.product.ProductAvailability= ViewModel.ProductSize.L
                + ViewModel.ProductSize.S
                + ViewModel.ProductSize.M
                + ViewModel.ProductSize.Xl;
            productViewModel.product.ProductAddedDate = DateTime.Now.Date;
            product.Insert(ViewModel.product);

            return View("Index");
        }
    }
}