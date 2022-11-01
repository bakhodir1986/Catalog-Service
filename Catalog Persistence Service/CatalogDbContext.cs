using Catalog_Business_Layer_Service.Categories;
using Catalog_Business_Layer_Service.Products;
using Microsoft.EntityFrameworkCore;

namespace Catalog_Persistence_Service
{
    public class CatalogDbContext : DbContext
    {
        public CatalogDbContext() : base() {
            
        }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }
    }
}
