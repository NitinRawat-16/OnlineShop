using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModelLayer;

namespace DataLayer
{
    public  class ProductSizeDb
    {
        OnlineShop db= new OnlineShop();
        public void Insert(ProductSize productSize)
        {
            db.ProductSizes.Add(productSize);
            db.SaveChanges();
        }
    }
}
