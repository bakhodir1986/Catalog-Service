using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_Business_Layer_Service.Categories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();

        void AddCategory(Category category);

        void UpdateCategory(Category category);

        void DeleteCategory(Category category);
    }
}
