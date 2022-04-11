using DataLayer.Users;
using DataModelLayer;
using System.Collections.Generic;

namespace BusinessLogicLayer.Users
{
    public class ViewProducts
    {
        private readonly ShowProducts _showProducts;
        public ViewProducts()
        {
            _showProducts = new ShowProducts();
        }

        public IEnumerable<Product> ShowAllProducts()
        {
            var products = _showProducts.GetAllProduct();
            return products;
        }
    }
}
