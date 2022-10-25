using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_Persistence_Service
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public uint Amount { get; set; }
//        Name – required, plain text, max length = 50.
//Description – optional, can contain html.
//Image – optional, URL.
//Category – required, one item can belong to only one category.
//Price – required, money.
//Amount – required, positive int.
    }
}
