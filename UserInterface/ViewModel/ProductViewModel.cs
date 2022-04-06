using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataModelLayer;

namespace UserInterface.ViewModel
{
    public class ProductViewModel
    {
        public List<ProductCategory> ProductCategories { get; set; }
        public ProductSize ProductSize { get; set; }
        public Product product { get; set; }
    }
}