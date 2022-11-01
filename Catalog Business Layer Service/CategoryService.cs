using Catalog_Business_Layer_Service.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_Business_Layer_Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void AddCategory(Category category)
        {
            if (category == null) throw new ArgumentNullException("Invalid category");
            categoryRepository.AddCategory(category);
        }

        public void DeleteCategory(Category category)
        {
            if (category == null) throw new ArgumentNullException("Invalid category");
            categoryRepository.DeleteCategory(category);
        }

        public IEnumerable<Category> GetCategories()
        {
            return categoryRepository.GetCategories();
        }

        public void UpdateCategory(Category category)
        {
            if (category == null) throw new ArgumentNullException("Invalid category");
            categoryRepository.UpdateCategory(category);
        }
    }
}
