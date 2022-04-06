
using DataLayer;
using DataModelLayer;

namespace BusinessLogicLayer
{
    public  class ProductSizeBs
    {
        ProductSizeDb db= new ProductSizeDb();
        public void Insert(ProductSize productSize)
        {
            db.Insert(productSize);
        }
    }
}
