using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_Business_Layer_Service.Categories
{
    public class Category
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
        public string Url { get; set; }
        public Category Parent { get; set; }
    }
}
