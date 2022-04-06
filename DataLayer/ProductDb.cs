using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModelLayer;

namespace DataLayer
{
    public  class ProductDb
    {
        OnlineShop db= new OnlineShop();
        public IEnumerable<Product> GetAll()
        {
            return db.Products;
        }

        public void  Insert(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }
    }
}
