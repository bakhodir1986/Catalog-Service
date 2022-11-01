using Catalog_Business_Layer_Service.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_Business_Layer_Service
{
    public class ProductService : IProductMService
    {
        private readonly IProductsRepository productsRepository;

        public ProductService(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }
        public void AddProduct(Product product)
        {
            if (product == null) throw new ArgumentNullException("invalid product");
            productsRepository.AddProduct(product);
        }

        public void DeleteProduct(Product product)
        {
            if (product == null) throw new ArgumentNullException("invalid product");
            productsRepository.DeleteProduct(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            return productsRepository.GetProducts();
        }

        public void UpdateProduct(Product product)
        {
            if (product == null) throw new ArgumentNullException("invalid product");
            productsRepository.UpdateProduct(product);
        }
    }
}
