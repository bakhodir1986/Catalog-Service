using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog_Business_Layer_Service.Categories;

namespace Catalog_Business_Layer_Service.Products
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name 
        {
            get
            {
                return Name;
            } 
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("value");
                if (value.Length > 50) throw new ArgumentException("Name can not be longer then 50");
                Name = value;
            }
        }
        public string Description { get; set; }
        public string Image { get; set; }
        [Required]
        public Category Category 
        { 
            get
            {
                return Category;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                Category = value;
            }
        }
        [Required]
        public decimal Price 
        { 
            get { return Price; }
            set { if (value < 0) throw new ArgumentOutOfRangeException("value"); Price = value; }
        }
        [Required]
        public uint Amount { 
            get { return Amount; }
            set { if (value < 0) throw new ArgumentOutOfRangeException("value"); Amount = value; }
        }
    }
}
