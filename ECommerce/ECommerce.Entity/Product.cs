using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public double UnitPrice { get; set; }
        public int StockAmount { get; set; }
        public String Description { get; set; }
        public String Summary { get; set; }
        public String ImageUrl { get; set; }
        public Status Status { get; set; }
        public Category Category { get; set; }
    }

    public enum Status
    {
        Offline,
        Online,
        Draft
    }
}
