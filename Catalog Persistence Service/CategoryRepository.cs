using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_Persistence_Service
{
    public class CategoryRepository : ICategoryRepository
    {
        public void AddCategory(Category category)
        {
            using (var context = new CatalogDbContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        public void DeleteCategory(Category category)
        {
            using (var context = new CatalogDbContext())
            {
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            using (var context = new CatalogDbContext())
            {
                return context.Categories.ToList();
            }
        }

        public void UpdateCategory(Category category)
        {
            using (var context = new CatalogDbContext())
            {
                context.Categories.Update(category);
                context.SaveChanges();
            }
        }
    }
}
