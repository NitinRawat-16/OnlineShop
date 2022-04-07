using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataModelLayer;

namespace UserInterface.ViewModel
{
    public class ProductViewModel
    {
        public List<ProductCategory> productCategories { get; set; }
        public Product product { get; set; }
        public ProductSize productSize { get; set; }
    }
}