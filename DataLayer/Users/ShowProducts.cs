using DataModelLayer;
using System.Collections.Generic;

namespace DataLayer.Users
{
    public class ShowProducts
    {
        private readonly PortalEntities _dbContext;
        public ShowProducts()
        {
            _dbContext = new PortalEntities();
        }

        public IEnumerable<Product> GetAllProduct()
        {
            var products = _dbContext.Products;
            return products;
        }
    }
}
