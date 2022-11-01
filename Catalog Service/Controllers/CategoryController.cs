using Catalog_Business_Layer_Service;
using Catalog_Business_Layer_Service.Categories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog_Service.Controllers
{
    public class CategoryController
    {
        private readonly ICategoryService categoryManager;

        public CategoryController(ICategoryService categoryManager)
        {
            this.categoryManager = categoryManager;
        }

        [HttpGet(Name = "GetAllCategory")]
        public IEnumerable<Category> Get()
        {
            return categoryManager.GetCategories();
        }

        [HttpPost(Name = "AddCategory")]
        [ValidateAntiForgeryToken]
        public void Add(Category category)
        {
            categoryManager.AddCategory(category);
        }

        [HttpPut(Name = "UpdateCategory")]
        [ValidateAntiForgeryToken]
        public void Update(Category category)
        {
            categoryManager.UpdateCategory(category);
        }

        [HttpDelete(Name = "RemoveCategory")]
        public void Remove(Category category)
        {
            categoryManager.DeleteCategory(category);
        }
    }
}
