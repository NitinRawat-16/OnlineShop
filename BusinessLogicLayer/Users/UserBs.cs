using DataLayer.Users;
using DataModelLayer;
using System.Collections.Generic;

namespace BusinessLogicLayer.Users
{
    public class UserBs
    {
        private readonly UserDb _userDb;
        public UserBs()
        {
            _userDb = new UserDb();
        }

        public IEnumerable<Product> ShowAllProducts()
        {
            var products = _userDb.GetAllProduct();
            return products;
        }

        public void AddAddress(DeliveryAddress delivery)
        {
            _userDb.AddAddress(delivery);
        }

    }
}
