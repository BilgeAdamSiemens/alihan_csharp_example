using System;
using System.Collections.Generic;

namespace Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public List<Post> Posts { get; set; }
    }
}