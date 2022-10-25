using Catalog_Business_Layer_Service;
using Catalog_Persistence_Service;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Catalog_Service.Controllers
{
    public class ProductController
    {
        private readonly IProductManager productManager;

        public ProductController(IProductManager productManager)
        {
            this.productManager = productManager;
        }

        [HttpGet(Name = "GetAllProducts")]
        public IEnumerable<Product> Get()
        {
            return productManager.GetProducts();
        }

        [HttpPost(Name = "AddCategory")]
        [ValidateAntiForgeryToken]
        public void Add(Product product)
        {
            productManager.AddProduct(product);
        }

        [HttpPut(Name = "UpdateCategory")]
        [ValidateAntiForgeryToken]
        public void Update(Product product)
        {
            productManager.UpdateProduct(product);
        }

        [HttpDelete(Name = "RemoveCategory")]
        public void Remove(Product product)
        {
            productManager.DeleteProduct(product);
        }
    }
}
