using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModelLayer;

namespace DataLayer
{
    public  class ProductCategoryDb
    {
        OnlineShop db= new OnlineShop();
        public IEnumerable<ProductCategory> GetAll()
        {
            return db.ProductCategories;
        }
    }
}
