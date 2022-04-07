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
                productCategories = productCategory.GetAll().ToList()
            };
            return View(categoryViewModel);
        }

        [HttpPost]
        public ActionResult Save(ProductViewModel productViewModel)
        {
            var ViewModel = new ProductViewModel
            {
                product = productViewModel.product,
                productSize = productViewModel.productSize,
                productCategories = productViewModel.productCategories
            };
            productSize.Insert(ViewModel.productSize);
            productViewModel.product.ProductSizeId = ViewModel.productSize.ProductSizeId;
            productViewModel.product.TotalProductAdded = ViewModel.productSize.L
                + ViewModel.productSize.S
                + ViewModel.productSize.M
                + ViewModel.productSize.Xl;
            productViewModel.product.ProductAvailability = ViewModel.productSize.L
                + ViewModel.productSize.S
                + ViewModel.productSize.M
                + ViewModel.productSize.Xl;
            productViewModel.product.ProductAddedDate = DateTime.Now.Date;
            product.Insert(ViewModel.product);

            return View("Index");
        }
    }
}