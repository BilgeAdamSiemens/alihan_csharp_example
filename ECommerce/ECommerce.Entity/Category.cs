using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
