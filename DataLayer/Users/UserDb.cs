using DataModelLayer;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataLayer.Users
{
    public class UserDb
    {
        private readonly PortalEntities _dbContext;
        public UserDb()
        {
            _dbContext = new PortalEntities();
        }

        public IEnumerable<Product> GetAllProduct()
        {
            var products = _dbContext.Products;
            return products;
        }

        public void AddAddress(DeliveryAddress deliveryAddress)
        {
            _dbContext.DeliveryAddresses.Add(deliveryAddress);
            _dbContext.SaveChanges();
        }

    }
}
