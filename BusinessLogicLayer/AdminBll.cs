using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModelLayer;
using DataLayer;
namespace BusinessLogicLayer
{
    public  class AdminBll
    {
        AdminDll adminDll;

        public AdminBll()
        {
            adminDll = new AdminDll();  
        }


        public IEnumerable<Product> GetProducts()
        {
            return adminDll.GetProducts();
        }

    }
}
