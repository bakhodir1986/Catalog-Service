using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_Persistence_Service
{
    public class ProductsRepository : IProductsRepository
    {
        public void AddProduct(Product category)
        {
            using (var context = new CatalogDbContext())
            {
                context.Products.Add(category);
                context.SaveChanges();
            }
        }

        public void DeleteProduct(Product category)
        {
            using (var context = new CatalogDbContext())
            {
                context.Products.Remove(category);
                context.SaveChanges();
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            using (var context = new CatalogDbContext())
            {
                return context.Products.ToList();
            }
        }

        public void UpdateProduct(Product category)
        {
            using (var context = new CatalogDbContext())
            {
                context.Products.Update(category);
                context.SaveChanges();
            }
        }
    }
}
