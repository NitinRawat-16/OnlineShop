using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using DataModelLayer;

namespace BusinessLogicLayer
{
    public class AdminBll
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
