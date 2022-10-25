using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_Persistence_Service
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public Guid ParentCategoryId { get; set; }
        public Category Parent { get; set; }

        //        Name – required, plain text, max length = 50.
        //Image – optional, URL.
        //Parent Category – optional
    }
}
