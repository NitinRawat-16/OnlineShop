
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataModelLayer;

namespace DataLayer
{
    public class AdminDll
    {
        OnlineShop _context;
        public AdminDll()
        {
            _context = new OnlineShop();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.Include(p=>p.ProductCategory).ToList();
        }
    }
}
