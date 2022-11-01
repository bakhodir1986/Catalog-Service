using Catalog_Business_Layer_Service.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_Business_Layer_Service
{
    public interface IProductMService
    {
        IEnumerable<Product> GetProducts();

        void AddProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(Product product);
    }
}
