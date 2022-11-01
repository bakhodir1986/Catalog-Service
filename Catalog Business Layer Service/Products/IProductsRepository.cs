using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_Business_Layer_Service.Products
{
    public interface IProductsRepository
    {
        IEnumerable<Product> GetProducts();

        void AddProduct(Product category);

        void UpdateProduct(Product category);

        void DeleteProduct(Product category);
    }
}
